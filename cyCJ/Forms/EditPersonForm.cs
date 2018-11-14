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
        private Person _person;

        public Person Person { get; }
        
        public EditPersonForm(string dlgname, Person person)
        {
            InitializeComponent();
            _person = person;
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            _person.Name = nameTb.Text;
            _person.Message = remarkTb.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
