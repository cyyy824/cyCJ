using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cyCJ.Models;
using cyCJ.Views;

namespace cyCJ.Forms
{
    public partial class WinPrizeShowForm : Form
    {
        private WinPrizeCollection winPrizes;
        public WinPrizeShowForm(DateTime openTime)
        {
            InitializeComponent();

            startTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            startTimeTP.Value = openTime;
            endTimeTP.Value = DateTime.Now;

            winPrizes = new WinPrizeCollection(connStr);
            winPrizes.ReadDB(startTimeTP.Value, endTimeTP.Value);
        }

        private void WinPrizeShowForm_Load(object sender, EventArgs e)
        {
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
        }

        private void RefreshPerson(int prizeIndex)
        {
        }
        private void RefreshPrize()
        {
        }

        private void prizeLv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void exportBt_Click(object sender, EventArgs e)
        {
        }
    }
}
