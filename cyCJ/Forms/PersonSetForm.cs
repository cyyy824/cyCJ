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
        public PersonCollection persons;

        public PersonSetForm(PersonCollection persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            var epdlg = new EditPersonForm("添加", new Person());
            epdlg.StartPosition = FormStartPosition.CenterParent;
            if (epdlg.ShowDialog() == DialogResult.OK)
            {
                persons.Add(epdlg.Person);
                this.personsLv.VirtualListSize = persons.Count;
                personsLv.Invalidate();
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = personsLv.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            string name = persons.Get(index).Name;
            Person tperson = (Person)persons.Get(index).Clone();

            var epdlg = new EditPersonForm("修改", tperson);
            epdlg.StartPosition = FormStartPosition.CenterParent;
            if (epdlg.ShowDialog() == DialogResult.OK)
            {
                persons.Update(index, tperson);
                personsLv.Invalidate();
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = personsLv.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            persons.Delete(index);
            this.personsLv.VirtualListSize = persons.Count;
            personsLv.Invalidate();
        }

        private void importBt_Click(object sender, EventArgs e)
        {

        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            persons.Clear();
            this.personsLv.VirtualListSize = persons.Count;
            personsLv.Invalidate();
        }

        private void PersonSetForm_Load(object sender, EventArgs e)
        {
            personsLv.Columns.Add("姓名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            personsLv.Columns.Add("备注", 300, System.Windows.Forms.HorizontalAlignment.Left);
            personsLv.VirtualListSize = persons.Count;
        }

        private void personsLv_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (this.persons == null || this.persons.Count == 0)
            {
                return;
            }
            ListViewItem item = new ListViewItem();
            var person = persons.Get(e.ItemIndex);
            item.Text = person.Name;
            item.SubItems.Add(person.Message);
            e.Item = item;
        }
    }
}
