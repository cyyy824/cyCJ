using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cyCJ.Models;
using cyCJ.Views;

namespace cyCJ.Forms
{
    public partial class WinPrizeShowForm : Form
    {
        private WinPrizeCollection winPrizes;
        private List<WinPrize> _wins=null;
        public WinPrizeShowForm(DateTime openTime)
        {
            InitializeComponent();

            startTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            startTimeTP.Value = openTime;
            endTimeTP.Value = DateTime.Now;

            winPrizes = new WinPrizeCollection();
            winPrizes.ReadDB();
            _wins = winPrizes.filterTime(startTimeTP.Value, endTimeTP.Value);
        }

        private void WinPrizeShowForm_Load(object sender, EventArgs e)
        { 
            prizeLv.Columns.Add("奖项", 100, HorizontalAlignment.Left);
            // prizeLv.Columns.Add("抽取时间", 100, HorizontalAlignment.Left);
            personLv.Columns.Add("姓名", 80, HorizontalAlignment.Left);
            personLv.Columns.Add("备注", 300, HorizontalAlignment.Left);

            this.RefreshPrize();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            this.RefreshPrize();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshPerson(int prizeIndex)
        {
            personLv.Items.Clear();
            personLv.BeginUpdate();
            WinPrize wp = winPrizes.Get(prizeIndex);
            List<Person> persons = wp.Persons;
            foreach (var pr in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pr.Name;

                //    item.SubItems.Add(wp.DrawTime.ToString("yyyy-MM-dd HH:mm:ss"));
                item.SubItems.Add(pr.Text);
                item.SubItems.Add(pr.Picpath);
                personLv.Items.Add(item);
            }
            personLv.EndUpdate();
        }
        private void RefreshPrize()
        {
            prizeLv.Items.Clear();
            prizeLv.BeginUpdate();

            for (int i = 0; i < winPrizes.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                var wp = winPrizes.Get(i);
                item.Text = wp.PrizeName;
                prizeLv.Items.Add(item);
            }
            prizeLv.EndUpdate();
        }

        private void prizeLv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void exportBt_Click(object sender, EventArgs e)
        {
        }
    }
}
