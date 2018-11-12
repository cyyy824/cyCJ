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
    public partial class EditPersonForm : Form
    {
        private Person person;
        private string imgpath;

        public Person Person { get => person; }

        public EditPersonForm(string dlgname, Person person)
        {
            InitializeComponent();
            this.Text = dlgname;
            this.person = person;
            this.nameTb.Text = person.Name;
            this.remarkTb.Text = person.Message;
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

        private void okBt_Click(object sender, EventArgs e)
        {
            person.Name = this.nameTb.Text;
            person.Text = this.remarkTb.Text;
            person.Picpath = imgpath;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void clearImageBt_Click(object sender, EventArgs e)
        {
            NoneImage();
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
    }
}
