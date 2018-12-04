using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cyCJ.Models;
using cyCJ.Views;
using cyCJ.Util;

namespace cyCJ.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 配置控件
        }

        // 打开抽奖人群设置对话框
        private void setPersonBt_Click(object sender, EventArgs e)
        {
            var pform = new PersonSetForm();
            pform.StartPosition = FormStartPosition.CenterParent;
            pform.ShowDialog();
        }

        // 打开抽奖奖项设置对话框
        private void setPrizeBt_Click(object sender, EventArgs e)
        {
            var pform = new PrizeSetForm();
            pform.StartPosition = FormStartPosition.CenterParent;
            pform.ShowDialog();
        }

        // 打开抽奖页面
        private void drawBt_Click(object sender, EventArgs e)
        {
            var dform = new DrawPrizeForm(startTimeTP.Value);
            dform.ShowDialog();
        }

        // 设置抽奖页面静态背景
        private void updateshowBg_Click(object sender, EventArgs e)
        {
        }

        // 设置抽奖页面播放抽奖动画时的背景
        private void updateBg_Click(object sender, EventArgs e)
        {
        }

        // 设置抽奖底色
        private void setMBt_Click(object sender, EventArgs e)
        {
        }

        // 设置抽奖页面内容字体
        private void setFontCBt_Click(object sender, EventArgs e)
        {
        }

        // 设置抽奖页面标题字体
        private void settfBt_Click(object sender, EventArgs e)
        {
        }

        // 修改抽取时是否显示名字选项
        private void showNameCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void InitImDB()
        {
        }

        // 重画展示页面缩略图
        private void PaintShowPage()
        {
        }

        // 重画抽奖页面缩略图
        private void PaintDrawPage()
        {
        }

        // 从字体对话框中取得字体
        private bool GetFontFromDlg(ref CFont font)
        {
            return true;
        }

        // 从颜色对话框中取颜色
        private bool GetColorFromDlg(out Color color)
        {
            color = new Color();
            return true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void winprizeShowBt_Click(object sender, EventArgs e)
        {
            WinPrizeShowForm wpForm = new WinPrizeShowForm(startTimeTP.Value);
            wpForm.StartPosition = FormStartPosition.CenterParent;
            wpForm.ShowDialog();
        }

        private void drawTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
