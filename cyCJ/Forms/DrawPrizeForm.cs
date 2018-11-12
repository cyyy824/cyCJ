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
        private Config config;
        private PersonCollection persons;
        private PrizeCollection prizes;

        private PersonDrawCollection noprizePersons;
        private ImageDB imdb;

        private List<Person> winList;
        private WinPrizeCollection wps;
        private DateTime openTime;

        private DrawStatus status;

        private PaintViewBase paintview;
        private int drawType;

        private const int INTERVAL=1;
        

        private enum DrawStatus
        {
            Show,
            Drawing,
            DrawResult,
            DrawCancel,
        };

        public DrawPrizeForm(PersonCollection persons,Config config,PrizeCollection prizes,ImageDB imgdb,DateTime filterTime,int drawType)
        {
            InitializeComponent();
            this.config = config;
            this.persons = persons;
            this.prizes = prizes;
            this.imdb = imgdb;
            this.drawType = drawType;

            openTime = filterTime;
            wps = new WinPrizeCollection(config.Connstr);
            wps.ReadDB(openTime);
            noprizePersons = new PersonDrawCollection();
            RefreshDrawPerson();
            
        }


        private void DrawPrizeForm_Resize(object sender, EventArgs e)
        {
            showPic.Left = 0;
            showPic.Top = 0;
            showPic.Width = this.Size.Width;
            showPic.Height = this.Size.Height;
        }

        private void DrawPrizeForm_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private List<Person> GetWinPerson()
        {
            List<Person> pers = new List<Person>();
            for(int i=0;i<wps.Count;i++)
            {
                WinPrize wp = wps.GetWinPrize(i);
                foreach(var per in wp.Persons)
                {
                    pers.Add(per);
                }
            }
            return pers;
        }
        // 获取未获奖人员
        private void RefreshDrawPerson()
        {
            noprizePersons.Clear();
            var wpl = GetWinPerson();
            bool isWin;
            for(int i=0;i<persons.Count;i++)
            {
                isWin = false;
                Person per = persons.GetPerson(i);
                foreach(var wp in wpl)
                {
                    if (per.Equals(wp))
                    {
                        // 此乃人生赢家
                        isWin = true;
                        break;
                    }
                }
                if(!isWin)
                {
                    noprizePersons.Add(per);
                }
            }
        }
        private void showPic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch(status)
            {
                case DrawStatus.Show:
                    paintview.PaintShow(g);
                    break;
                case DrawStatus.Drawing:
                    winList = paintview.PaintDrawing(g);
                    break;
                case DrawStatus.DrawResult:
                    paintview.PaintResult(winList,g);
                    break;
                case DrawStatus.DrawCancel:
                    paintview.PaintCancel(g);
                    break;
            }
        }
        private void SetShowStatus()
        {
            prizeCB.Enabled = true;
            timer1.Enabled = false;
            status = DrawStatus.Show;
            cancelBt.Enabled = false;
            stopBt.Enabled = false;

            showPic.Invalidate();
        }

        private void SetDrawingStatus()
        {
            if (status == DrawStatus.Drawing)
                return;
            if (prizeCB.SelectedIndex<0)
            {
                MessageBox.Show("没有选择奖项");
                return;
            }
            prizeCB.Enabled = false;
            timer1.Enabled = true;
            cancelBt.Enabled = true;
            stopBt.Enabled = true;
            startBt.Enabled = false;
            status = DrawStatus.Drawing;
            paintview.SetInterval(INTERVAL);
            paintview.SetPersons(noprizePersons);
            paintview.SetPrize(prizes.GetPrize(prizeCB.SelectedIndex));
            
        }
        private void SetDrawResultStatus()
        {
            if (status==DrawStatus.Drawing)
            {
                cancelBt.Enabled = true;
                stopBt.Enabled = false;
                prizeCB.Enabled = true;
                startBt.Enabled = true;
                status = DrawStatus.DrawResult;
                SaveWinDB();
                showPic.Invalidate();
            }
        }
        private void SetDrawCancelStatus()
        {
                cancelBt.Enabled = false;
                stopBt.Enabled = false;
                prizeCB.Enabled = true;
                startBt.Enabled = true;
                status = DrawStatus.DrawCancel;
                showPic.Invalidate();

        }
        private void SaveWinDB()
        {
            WinPrizeCollection twps = new WinPrizeCollection(config.Connstr);
            WinPrize pr = new WinPrize(prizes.GetPrize(prizeCB.SelectedIndex));
            pr.DrawTime = DateTime.Now;
            foreach(var item in winList)
            {
                pr.Persons.Add(item);
            }
            twps.Add(pr);
            twps.SaveDB();
            wps.ReadDB(openTime);
            RefreshDrawPerson();
        }
        private void exitBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showPic.Invalidate();
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            SetDrawingStatus();
        }

        private void DrawPrizeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetShowStatus();
        }

        private void DrawPrizeForm_Load(object sender, EventArgs e)
        {
            for(int i=0; i<prizes.Count;i++)
            {
                prizeCB.Items.Add(prizes.GetPrize(i).Name);
            }

            this.startBt.Location = new Point(startBt.Location.X, showPic.Height - startBt.Height);
            this.stopBt.Location = new Point(stopBt.Location.X, showPic.Height - stopBt.Height);
            this.exitBt.Location = new Point(exitBt.Location.X, showPic.Height - exitBt.Height);
            this.cancelBt.Location = new Point(cancelBt.Location.X, showPic.Height - cancelBt.Height);
            this.prizeCB.Location = new Point(prizeCB.Location.X, showPic.Height - cancelBt.Height);

            Rectangle maskrect = new Rectangle(config.maskX,config.maskY,config.maskW,config.maskH );
            if (drawType == 0)
            {
                paintview = new PaintNameView(new Rectangle(0, 0, showPic.Width, showPic.Height),
                    maskrect,
                    config,
                    imdb,
                    noprizePersons);
            }
            else
            {
                paintview = new PaintTextView(new Rectangle(0, 0, showPic.Width, showPic.Height),
                    maskrect,
                    config,
                    imdb,
                    noprizePersons);
            }

            SetShowStatus();
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            SetDrawResultStatus();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            SetDrawCancelStatus();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            if (status != DrawStatus.DrawResult)
                return;
            MouseEventArgs me = (MouseEventArgs)e;
            Graphics g = showPic.CreateGraphics();
            if (paintview.Click(me.Location, g))
                showPic.Invalidate();
        }
    }
}
