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
            _wins = winPrizes.filterTime(startTimeTP.Value, endTimeTP.Value);
            this.RefreshPrize();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshPerson(int prizeIndex)
        {
            string pn = prizeLv.Items[prizeIndex].Text;
            var slist = _wins.FindAll(c => c.PrizeName == pn);

            personLv.Items.Clear();
            personLv.BeginUpdate();
            foreach (var wp in slist)
            {
                ListViewItem item = new ListViewItem();
                item.Text = wp.PersonName;
                item.SubItems.Add(wp.PersonMessage);
                personLv.Items.Add(item);
            }
            personLv.EndUpdate();
        }
        private void RefreshPrize()
        {
            prizeLv.Items.Clear();
            prizeLv.BeginUpdate();

            var plist = new List<string>();
            foreach(var wp in _wins)
            {
                if( !plist.Contains(wp.PrizeName))
                {
                    plist.Add(wp.PrizeName);
                    ListViewItem item = new ListViewItem();
                    prizeLv.Items.Add(wp.PrizeName);
                }
            }
            prizeLv.EndUpdate();
        }

        private void prizeLv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void exportBt_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = prizeLv.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            RefreshPerson(index);
        }
    }
}
