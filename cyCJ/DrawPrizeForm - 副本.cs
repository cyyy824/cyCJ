using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyCJ
{
    public partial class DrawPrizeForm : Form
    {
        private Config config;
        private PersonCollection persons;
        private PrizeCollection prizes;
        private PersonCollection noprizePersons;
        private ImageDB imdb;

        private List<Person> winList;
        private WinPrizeCollection wps;
        private DateTime openTime;

        private DrawStatus status;

        private enum DrawStatus
        {
            Show,
            Drawing,
            DrawResult,
            DrawCancel,
        };

        public DrawPrizeForm(PersonCollection persons,Config config,PrizeCollection prizes,ImageDB imgdb,DateTime filterTime)
        {
            InitializeComponent();
            this.config = config;
            this.persons = persons;
            this.prizes = prizes;
            this.imdb = imgdb;

            openTime = filterTime;
            wps = new WinPrizeCollection(config.Connstr);
            wps.ReadDB(openTime);
            noprizePersons = new PersonCollection("");
            RefreshDrawPerson();
            SetShowStatus();
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

        private void DrawShowStatus(Graphics g)
        {
            Image img = imdb.ShowBg;
            g.DrawImage(img, new Rectangle(0, 0, showPic.Width, showPic.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
            return;

        }
        private void DrawDrawingStatus(Graphics g)
        {
            Image img = imdb.DrawBg;
            // 画背景
            g.DrawImage(img, new Rectangle(0, 0, showPic.Width, showPic.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
            // 画标题
            Color tcolor = ColorTranslator.FromHtml(config.tFont.colorStr);

            Font tFont = new Font(config.tFont.family, config.tFont.size);
            SolidBrush bru1 = new SolidBrush(Color.FromArgb(tcolor.R, tcolor.G, tcolor.B));

            SizeF tsize = g.MeasureString(prizes.GetPrize(prizeCB.SelectedIndex).Name, tFont);
            g.DrawString(prizes.GetPrize(prizeCB.SelectedIndex).Name, tFont, bru1, showPic.Width / 2 -(tsize.Width/2), showPic.Height / 20);


            // 画文字遮挡
            Color mcolor = System.Drawing.ColorTranslator.FromHtml(config.colorStr);
            SolidBrush bru2 = new SolidBrush(Color.FromArgb(200, mcolor.R, mcolor.G, mcolor.B));
            RectangleF mrect = new RectangleF(showPic.Width / 5 / 2, showPic.Height / 4 - showPic.Height / 8, showPic.Width - showPic.Width / 5, showPic.Height - showPic.Height / 4);
            g.FillRectangle(bru2, mrect);
            // 画文字
            Color fcolor = System.Drawing.ColorTranslator.FromHtml(config.mFont.colorStr);
            Font mFont = new Font(config.mFont.family, config.mFont.size);
            SolidBrush bru3 = new SolidBrush(Color.FromArgb(fcolor.R, fcolor.G, fcolor.B));
            winList = noprizePersons.GetRandomList(prizes.GetPrize(prizeCB.SelectedIndex).Num);
            int ia = 1;
            SizeF fsize = g.MeasureString("一二三四五", mFont);
            float interval = fsize.Height * 2;
            foreach(var a1 in winList)
            {
                RectangleF textrect = new RectangleF(showPic.Width / 5 / 2 + fsize.Width, 
                    showPic.Height / 4 - showPic.Height / 8 + ia * interval,
                    mrect.Right-(showPic.Width / 5 / 2 + fsize.Width),
                    interval*2);
                if(config.isShowName>0)
                    g.DrawString(a1.Name, mFont, bru3, showPic.Width / 5 / 2, showPic.Height / 4 - showPic.Height / 8 + ia*interval);
                if(config.isShowText>0)
                    g.DrawString(a1.Text, mFont, bru3, textrect);


                ia++;
            }
        }

        private void DrawDrawResultStatus(Graphics g)
        {
            Image img = imdb.DrawBg;
            // 画背景
            g.DrawImage(img, new Rectangle(0, 0, showPic.Width, showPic.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
            // 画标题
            Color tcolor = ColorTranslator.FromHtml(config.tFont.colorStr);

            Font tFont = new Font(config.tFont.family, config.tFont.size);
            SolidBrush bru1 = new SolidBrush(Color.FromArgb(tcolor.R, tcolor.G, tcolor.B));

            SizeF tsize = g.MeasureString(prizes.GetPrize(prizeCB.SelectedIndex).Name, tFont);
            g.DrawString(prizes.GetPrize(prizeCB.SelectedIndex).Name, tFont, bru1, showPic.Width / 2 - (tsize.Width / 2), showPic.Height / 20);


            // 画文字遮挡
            Color mcolor = System.Drawing.ColorTranslator.FromHtml(config.colorStr);
            SolidBrush bru2 = new SolidBrush(Color.FromArgb(200, mcolor.R, mcolor.G, mcolor.B));
            RectangleF mrect = new RectangleF(showPic.Width / 5 / 2, showPic.Height / 4 - showPic.Height / 8, showPic.Width - showPic.Width / 5, showPic.Height - showPic.Height / 4);
            g.FillRectangle(bru2, mrect);
            // 画文字
            Color fcolor = System.Drawing.ColorTranslator.FromHtml(config.mFont.colorStr);
            Font mFont = new Font(config.mFont.family, config.mFont.size);
            SolidBrush bru3 = new SolidBrush(Color.FromArgb(fcolor.R, fcolor.G, fcolor.B));
            int ia = 1;
            SizeF fsize = g.MeasureString("一二三四五", mFont);
            float interval = fsize.Height * 2;
            foreach (var a1 in winList)
            {
                RectangleF textrect = new RectangleF(showPic.Width / 5 / 2 + fsize.Width,
                    showPic.Height / 4 - showPic.Height / 8 + ia * interval,
                    mrect.Right - (showPic.Width / 5 / 2 + fsize.Width),
                    interval * 2);
                if (config.isShowName > 0)
                    g.DrawString(a1.Name, mFont, bru3, showPic.Width / 5 / 2, showPic.Height / 4 - showPic.Height / 8 + ia * interval);
                if (config.isShowText > 0)
                    g.DrawString(a1.Text, mFont, bru3, textrect);


                ia++;
            }

        }
        private void DrawDrawCancelStatus(Graphics g)
        {
            Image img = imdb.DrawBg;
            // 画背景
            g.DrawImage(img, new Rectangle(0, 0, showPic.Width, showPic.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
            // 画标题


            // 画文字遮挡
            Color mcolor = System.Drawing.ColorTranslator.FromHtml(config.colorStr);
            SolidBrush bru2 = new SolidBrush(Color.FromArgb(200, mcolor.R, mcolor.G, mcolor.B));
            g.FillRectangle(bru2, new RectangleF(showPic.Width/5/2,showPic.Height/4- showPic.Height/8, showPic.Width-showPic.Width/5,showPic.Height-showPic.Height/4));
        }
        private void showPic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch(status)
            {
                case DrawStatus.Show:
                    DrawShowStatus(g);
                    break;
                case DrawStatus.Drawing:
                    DrawDrawingStatus(g);
                    break;
                case DrawStatus.DrawResult:
                    DrawDrawResultStatus(g);
                    break;
                case DrawStatus.DrawCancel:
                    DrawDrawCancelStatus(g);
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
            noprizePersons.InitRandom();
            prizeCB.Enabled = false;
            timer1.Enabled = true;
            cancelBt.Enabled = true;
            stopBt.Enabled = true;
            startBt.Enabled = false;
            status = DrawStatus.Drawing;
        }
        private void SetDrawResultStatus()
        {
            if (status==DrawStatus.Drawing)
            {
                cancelBt.Enabled = false;
                stopBt.Enabled = false;
                prizeCB.Enabled = true;
                startBt.Enabled = true;
                status = DrawStatus.DrawResult;
                SaveWinDB();
            }
        }
        private void SetDrawCancelStatus()
        {
            if (status==DrawStatus.Drawing)
            {
                cancelBt.Enabled = false;
                stopBt.Enabled = false;
                prizeCB.Enabled = true;
                startBt.Enabled = true;
                status = DrawStatus.DrawCancel;
            }

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
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            SetDrawResultStatus();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            SetDrawCancelStatus();
        }
    }
}
