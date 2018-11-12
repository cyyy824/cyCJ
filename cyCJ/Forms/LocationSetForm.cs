using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cyCJ.Models;
using cyCJ.Views;

namespace cyCJ.Forms
{
    public partial class LocationSetForm : Form
    {
        public LocationSetForm(Config config,ImageDB imgdb)
        {
            InitializeComponent();
        }

        private void autoCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LocationSetForm_Load(object sender, EventArgs e)
        {
        }

        private void setMBt_Click(object sender, EventArgs e)
        {

        }

        private void updateBt_Click(object sender, EventArgs e)
        {
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
        }

        private void okBt_Click(object sender, EventArgs e)
        {


        }

        // 重画抽奖页面缩略图
        private void PaintDrawPage()
        {
        }

        private void isShowCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xTb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void yTb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void wTb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void hTb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        // 从颜色对话框中取颜色
        private bool GetColorFromDlg(out Color color)
        {
            color = new Color();
            return true;
        }

        private void txTb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
