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
    public partial class DrawPrizeForm : Form
    {

        private enum DrawStatus
        {
            Show,
            Drawing,
            DrawResult,
            DrawCancel,
        };

        public DrawPrizeForm(DateTime filterTime)
        {
            InitializeComponent();
            
        }


        private void DrawPrizeForm_Resize(object sender, EventArgs e)
        {
        }

        private void DrawPrizeForm_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private List<Person> GetWinPerson()
        {
            return null;
        }
        // 获取未获奖人员
        private void RefreshDrawPerson()
        {
        }
        private void showPic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }
        private void SetShowStatus()
        {
        }

        private void SetDrawingStatus()
        {
            
        }
        private void SetDrawResultStatus()
        {
        }
        private void SetDrawCancelStatus()
        {

        }
        private void SaveWinDB()
        {
        }
        private void exitBt_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void startBt_Click(object sender, EventArgs e)
        {
        }

        private void DrawPrizeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void DrawPrizeForm_Load(object sender, EventArgs e)
        {
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            SetDrawCancelStatus();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
        }
    }
}
