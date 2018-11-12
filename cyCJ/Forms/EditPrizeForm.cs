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

        public EditPrizeForm(string dlgname, Prize prize)
        {
            InitializeComponent();
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
        }

        private void clearImageBt_Click(object sender, EventArgs e)
        {
        }

        private void okBt_Click(object sender, EventArgs e)
        {
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
        }

        private void HaveImage(string path)
        {
        }

        private void NoneImage()
        {
        }

        private void imgPB_DoubleClick(object sender, EventArgs e)
        {
        }
        private bool validate()
        {
            return false;
        }
    }
}
