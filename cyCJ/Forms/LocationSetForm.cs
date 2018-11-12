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
        private Config config;
        private ImageDB imdb;
        private Config tconfig;

        public LocationSetForm(Config config,ImageDB imgdb)
        {
            this.config = config;
            imdb = imgdb;

            tconfig = new Config();
            tconfig.colorStr = config.colorStr;
            tconfig.isAutoMaskLocation = config.isAutoMaskLocation;
            tconfig.isDrawMask = config.isDrawMask;
            tconfig.maskX = config.maskX;
            tconfig.maskY = config.maskY;
            tconfig.maskW = config.maskW;
            tconfig.maskH = config.maskH;
            tconfig.tX = config.tX;
            tconfig.tY = config.tY;
            tconfig.tFont.colorStr = config.tFont.colorStr;
            tconfig.tFont.family = config.tFont.family;
            tconfig.tFont.size = config.tFont.size;
            
            tconfig.mFont.colorStr = config.mFont.colorStr;
            tconfig.mFont.family = config.mFont.family;
            tconfig.mFont.size = config.mFont.size;

            InitializeComponent();
        }

        private void autoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (autoCB.Checked)
            {
                tconfig.isAutoMaskLocation = 1;
                tconfig.maskX = imdb.ScreenSize.Width / 5 / 2;
                tconfig.maskY = imdb.ScreenSize.Height / 4 - imdb.ScreenSize.Height / 8;
                tconfig.maskW = imdb.ScreenSize.Width - imdb.ScreenSize.Width / 5;
                tconfig.maskH = imdb.ScreenSize.Height - imdb.ScreenSize.Height / 4;
                tconfig.tX = imdb.ScreenSize.Width / 2 - imdb.ScreenSize.Width / 8;
                tconfig.tY = imdb.ScreenSize.Height / 20;

                xTb.Text = tconfig.maskX.ToString();
                yTb.Text = tconfig.maskY.ToString();
                wTb.Text = tconfig.maskW.ToString();
                hTb.Text = tconfig.maskH.ToString();

                txTb.Text = tconfig.tX.ToString();
                tyTb.Text = tconfig.tY.ToString();

            }
            else
            {
                tconfig.isAutoMaskLocation = 0;
            }
            if(tconfig.isAutoMaskLocation!=0)
            {
                xTb.Enabled = false;
                yTb.Enabled = false;
                wTb.Enabled = false;
                hTb.Enabled = false;
                txTb.Enabled = false;
                tyTb.Enabled = false;
            }
            else
            {
                xTb.Enabled = true;
                yTb.Enabled = true;
                wTb.Enabled = true;
                hTb.Enabled = true;
                txTb.Enabled = true;
                tyTb.Enabled = true;
            }


        }

        private void LocationSetForm_Load(object sender, EventArgs e)
        {
            this.autoCB.Checked = tconfig.isAutoMaskLocation == 0 ? false : true;
            this.isShowCB.Checked = tconfig.isDrawMask == 0 ? false : true;

            xTb.Text = config.maskX.ToString();
            yTb.Text = config.maskY.ToString();
            wTb.Text = config.maskW.ToString();
            hTb.Text = config.maskH.ToString();
            txTb.Text = config.tX.ToString();
            tyTb.Text = config.tY.ToString();
            if(tconfig.isAutoMaskLocation!=0)
            {
                xTb.Enabled = false;
                yTb.Enabled = false;
                wTb.Enabled = false;
                hTb.Enabled = false;
                txTb.Enabled = false;
                tyTb.Enabled = false;
            }
            else
            {
                xTb.Enabled = true;
                yTb.Enabled = true;
                wTb.Enabled = true;
                hTb.Enabled = true;
                txTb.Enabled = true;
                tyTb.Enabled = true;
            }
            this.setMBt.BackColor = ColorTranslator.FromHtml(tconfig.colorStr);
            PaintDrawPage();
        }

        private void setMBt_Click(object sender, EventArgs e)
        {
            Color mcolor;
            if (!GetColorFromDlg(out mcolor))
                return;
            tconfig.colorStr = System.Drawing.ColorTranslator.ToHtml(mcolor);
            this.setMBt.BackColor = mcolor;

        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            try{tconfig.maskX = int.Parse(xTb.Text);}
            catch{ tconfig.maskX = 0; }
            try{tconfig.maskY = int.Parse(yTb.Text);}
            catch{ tconfig.maskY = 0; }
            try{tconfig.maskW = int.Parse(wTb.Text);}
            catch{ tconfig.maskW = 0; }
            try{tconfig.maskH = int.Parse(hTb.Text);}
            catch{ tconfig.maskH = 0; }
            try{tconfig.tX = int.Parse(txTb.Text);}
            catch{ tconfig.tX = 0; }
            try{tconfig.tY = int.Parse(tyTb.Text);}
            catch{ tconfig.tY = 0; }

            PaintDrawPage();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBt_Click(object sender, EventArgs e)
        {

            try{tconfig.maskX = int.Parse(xTb.Text);}
            catch{ tconfig.maskX = 0; }
            try{tconfig.maskY = int.Parse(yTb.Text);}
            catch{ tconfig.maskY = 0; }
            try{tconfig.maskW = int.Parse(wTb.Text);}
            catch{ tconfig.maskW = 0; }
            try{tconfig.maskH = int.Parse(hTb.Text);}
            catch{ tconfig.maskH = 0; }
            try{tconfig.tX = int.Parse(txTb.Text);}
            catch{ tconfig.tX = 0; }
            try{tconfig.tY = int.Parse(tyTb.Text);}
            catch{ tconfig.tY = 0; }

            config.colorStr = tconfig.colorStr;
            config.isAutoMaskLocation = tconfig.isAutoMaskLocation;
            config.isDrawMask = tconfig.isDrawMask;
            config.maskX = tconfig.maskX;
            config.maskY = tconfig.maskY;
            config.maskW = tconfig.maskW;
            config.maskH = tconfig.maskH;
            config.tX = tconfig.tX;
            config.tY = tconfig.tY;
            config.tFont.colorStr = tconfig.tFont.colorStr;
            config.tFont.family = tconfig.tFont.family;
            config.tFont.size = tconfig.tFont.size;
            
            config.mFont.colorStr = tconfig.mFont.colorStr;
            config.mFont.family = tconfig.mFont.family;
            config.mFont.size = tconfig.mFont.size;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        // 重画抽奖页面缩略图
        private void PaintDrawPage()
        {
            Image im = imdb.DrawBg;
            if (im == null)
            {
                MessageBox.Show("没有设置抽奖背景图");
                return;
            }
            Bitmap bit = new Bitmap(imdb.ScreenSize.Width, imdb.ScreenSize.Height);
            Graphics g = Graphics.FromImage(bit);
            PaintNameView vi = new PaintNameView(new Rectangle(0, 0, imdb.ScreenSize.Width, imdb.ScreenSize.Height),
                new Rectangle(tconfig.maskX, tconfig.maskY, tconfig.maskW, tconfig.maskH),
                tconfig,
                imdb,
                null);
            vi.SetPrize(new Prize("一等奖", 5, ""));
            List<Person> ps = new List<Person>();
            ps.Add(new Person("张三"));
            ps.Add(new Person("李四"));
            vi.PaintResult(ps, g);
            drawPage.Image = bit;
        }

        private void isShowCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isShowCB.Checked)
            {
                tconfig.isDrawMask = 1;
            }
            else
            {
                tconfig.isDrawMask = 0;
            }

        }

        private void xTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void yTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void wTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void hTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 从颜色对话框中取颜色
        private bool GetColorFromDlg(out Color color)
        {
            ColorDialog cd = new ColorDialog(); //新建一个颜色选择窗口
            DialogResult result = cd.ShowDialog();  //让用户选择颜色
            color = cd.Color;
            if (result != DialogResult.OK)
                return false;
            return true;
        }

        private void txTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tyTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
