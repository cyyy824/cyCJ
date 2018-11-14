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
        private Prize _prize;

        public Prize Prize { get =>_prize; }

        public EditPrizeForm(string dlgname, Prize prize)
        {
            InitializeComponent();
            _prize = prize;
        }

        private void numTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            _prize.Name = nameTb.Text;
            _prize.Num = int.Parse(numTb.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
