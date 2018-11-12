using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using cyCJ.Models;
using cyCJ.Views;

namespace cyCJ.Forms
{
    public partial class PersonSetForm : Form
    {

        public PersonSetForm(PersonCollection persons)
        {
            InitializeComponent();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
        }

        private void importBt_Click(object sender, EventArgs e)
        {

        }

        private void clearBt_Click(object sender, EventArgs e)
        {
        }

        private void PersonSetForm_Load(object sender, EventArgs e)
        {
        }

        
        /*
        private void RefreshLv()
        {
            personsLv.Items.Clear();

            personsLv.BeginUpdate();
            for(int i=0;i<persons.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                var person = persons.GetPerson(i);
                item.Text = person.Name;
                item.SubItems.Add(person.Text);
                item.SubItems.Add(person.Picpath);
                personsLv.Items.Add(item);
            }
            personsLv.EndUpdate();

            personsLv.VirtualListSize = persons.Count;

        }
        */

        private void personsLv_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
        }
    }
}
