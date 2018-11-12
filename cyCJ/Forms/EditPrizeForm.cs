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

namespace cyCJ.Forms
{
    public partial class EditPrizeForm : Form
    {

        private Prize prize;
        private string imgpath;

        public Prize Prize { get => prize; }

        public EditPrizeForm(string dlgname, Prize prize)
        {
            InitializeComponent();
            this.Text = dlgname;
            this.prize = prize;
            this.nameTb.Text = prize.Name;
            this.numTb.Text = prize.Num.ToString();
            this.imgpath = prize.Picpath;
        }

        private void numTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addimageBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "*.BMP,*.JPG;*.GIF;*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fdlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Image im = Image.FromFile(fdlg.FileName);
            if (im == null)
            {
                MessageBox.Show("图片读取错误");
                return;
            }
            im.Dispose();
            HaveImage(fdlg.FileName);
        }

        private void clearImageBt_Click(object sender, EventArgs e)
        {
            NoneImage();
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            this.prize.Name = nameTb.Text;
            this.prize.Num = int.Parse(numTb.Text);
            this.prize.Picpath = imgpath;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void HaveImage(string path)
        {
            imgpath = path;
            imgPB.Image = Resource.pictype;
        }

        private void NoneImage()
        {
            imgpath = "";
            imgPB.Image = Resource.nopictype;
        }

        private void imgPB_DoubleClick(object sender, EventArgs e)
        {
            if (imgpath != "")
                System.Diagnostics.Process.Start(imgpath);
        }
        private bool validate()
        {
            if (nameTb.Text == "")
                return false;
            if (numTb.Text == "")
                return false;
            int num;
            try
            {
                num = int.Parse(numTb.Text);
                if (num <= 0)
                    return false;
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
