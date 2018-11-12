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
        private string connStr;
        public WinPrizeShowForm(DateTime openTime,string connStr)
        {
            InitializeComponent();
            this.connStr = connStr;

            startTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            startTimeTP.Value = openTime;
            endTimeTP.Value = DateTime.Now;
            winPrizes = new WinPrizeCollection(connStr);
            winPrizes.ReadDB(startTimeTP.Value,endTimeTP.Value);
        }

        private void WinPrizeShowForm_Load(object sender, EventArgs e)
        {
            prizeLv.Columns.Add("奖项", 100, HorizontalAlignment.Left);
           // prizeLv.Columns.Add("抽取时间", 100, HorizontalAlignment.Left);


            personLv.Columns.Add("姓名", 80, HorizontalAlignment.Left);
        //    personLv.Columns.Add("抽取时间", 150, HorizontalAlignment.Left);
            personLv.Columns.Add("感言", 300, HorizontalAlignment.Left);
            personLv.Columns.Add("图片", 100, HorizontalAlignment.Left);

            this.RefreshPrize();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            winPrizes.ReadDB(startTimeTP.Value,endTimeTP.Value);

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
            WinPrize wp = winPrizes.GetWinPrize(prizeIndex);
            List<Person> persons = wp.Persons;
            foreach(var pr in persons)
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

            for(int i=0;i<winPrizes.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                var wp = winPrizes.GetWinPrize(i);
                item.Text = wp.Prize.Name;
          //      item.SubItems.Add(wp.DrawTime.ToString("yyyy-MM-dd HH:mm:ss"));
                prizeLv.Items.Add(item);
            }
            prizeLv.EndUpdate();
        }

        private void prizeLv_SelectedIndexChanged(object sender, EventArgs e)
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

        private void exportBt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "";
            sfd.Filter = "文本文件| *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                for(int i=0;i< winPrizes.Count;i++)
                {
                    WinPrize wp = winPrizes.GetWinPrize(i);
                    sw.Write(wp.Prize.Name + "\r\n");
                    foreach(var per in wp.Persons)
                    {
                        sw.Write(per.Name + ",");
                    }
                    sw.Write("\r\n");
                   
                }
                sw.Close();
                fs.Close();
            }
        }
    }
}
