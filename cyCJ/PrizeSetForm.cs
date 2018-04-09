using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyCJ
{
    public partial class PrizeSetForm : Form
    {
        private PrizeCollection prizes;
        public PrizeSetForm(PrizeCollection prizes)
        {
            InitializeComponent();
            this.prizes = prizes;
        }

        private void PrizeSetForm_Load(object sender, EventArgs e)
        {
            this.prizeListLv.Columns.Add("奖项", 150, HorizontalAlignment.Left);
            this.prizeListLv.Columns.Add("抽取数量", 100, HorizontalAlignment.Left);
            this.prizeListLv.Columns.Add("图片", 100, HorizontalAlignment.Left);
            this.prizeListLv.VirtualListSize = prizes.Count;
        }

        private void prizeListLv_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (this.prizes== null || this.prizes.Count == 0)
            {
                return;
            }
            ListViewItem item = new ListViewItem();
            var prize = prizes.GetPrize(e.ItemIndex);
            item.Text = prize.Name;
            item.SubItems.Add(prize.Num.ToString());
            item.SubItems.Add(prize.Picpath);
            e.Item = item;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            var epdlg = new EditPrizeForm("添加", new Prize("",0,""));
            epdlg.StartPosition = FormStartPosition.CenterParent;
            if (epdlg.ShowDialog() == DialogResult.OK)
            {
                prizes.Add(epdlg.Prize);
                this.prizeListLv.VirtualListSize = prizes.Count;
                prizeListLv.Invalidate();
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = prizeListLv.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            Prize tprize = new Prize(prizes.GetPrize(index).Name, prizes.GetPrize(index).Num, prizes.GetPrize(index).Picpath);
            var epdlg = new EditPrizeForm("修改", tprize);
            epdlg.StartPosition = FormStartPosition.CenterParent;

            if (epdlg.ShowDialog() == DialogResult.OK)
            {
                prizes.UpdatePrize(index, tprize);
                prizeListLv.Invalidate();
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = prizeListLv.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            prizes.DeletePrize(index);
            this.prizeListLv.VirtualListSize = prizes.Count;
            prizeListLv.Invalidate();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
