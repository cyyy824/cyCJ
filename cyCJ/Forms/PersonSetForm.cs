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
        private PersonCollection persons;

        public PersonSetForm(PersonCollection persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            var epdlg = new EditPersonForm("添加",new Person(""));
            epdlg.StartPosition = FormStartPosition.CenterParent;
            if( epdlg.ShowDialog()== DialogResult.OK)
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
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            string name = persons.GetPerson(index).Name;
            Person tperson = new Person(persons.GetPerson(index).Name, persons.GetPerson(index).Text, persons.GetPerson(index).Picpath);
            var epdlg = new EditPersonForm("修改",tperson);
            epdlg.StartPosition = FormStartPosition.CenterParent;
            if (epdlg.ShowDialog() == DialogResult.OK)
            {
                persons.UpdatePerson(index, tperson);
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
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("{0}", ex.Message);
                return;
            }
            persons.DeletePerson(index);
            this.personsLv.VirtualListSize = persons.Count;
            personsLv.Invalidate();
        }

        private void importBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "*.XLS,*.XLSX|*.XLS;*.XLSX";
            if (fdlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            FileStream fs = File.OpenRead(fdlg.FileName);
            string ext = Path.GetExtension(fdlg.FileName);
            IWorkbook wk=null;
            if(ext.ToLower().Equals(".xls"))
            { 
                wk = new HSSFWorkbook(fs);
            }
            else
            {
                wk = new XSSFWorkbook(fs);
            }
            fs.Close();

            persons.Clear();

            ISheet sheet = wk.GetSheetAt(0);
            System.Data.SQLite.SQLiteConnection cn = persons.OpenTran();
            System.Data.Common.DbTransaction trans = cn.BeginTransaction();
            for (int i=1;i<=sheet.LastRowNum;i++)
            {
                IRow row = sheet.GetRow(i);
                if (row.GetCell(0) == null)
                    break;
                string name = row.GetCell(0).ToString();
                string text = "";
                if (row.GetCell(1)!=null)
                {
                    text = row.GetCell(1).ToString();
                }
                persons.Add(new Person(name,text),cn);
            }
            trans.Commit();
            persons.CloseTran(cn);

            MessageBox.Show("导入完毕");

            this.personsLv.VirtualListSize = persons.Count;
            personsLv.Invalidate();

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
            personsLv.Columns.Add("图片", 100, System.Windows.Forms.HorizontalAlignment.Left);

            personsLv.VirtualListSize = persons.Count;
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
            if( this.persons==null || this.persons.Count == 0)
            {
                return;
            }
            ListViewItem item = new ListViewItem();
            var person = persons.GetPerson(e.ItemIndex);
            item.Text = person.Name;
            item.SubItems.Add(person.Text);
            item.SubItems.Add(person.Picpath);
            e.Item = item;
        }
    }
}
