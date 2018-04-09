using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ
{
    public class PaintTextView : PaintViewBase
    {
        public PaintTextView(Rectangle scrRect, Rectangle maskRect, Config config, ImageDB img, PersonDrawCollection persons) 
            : base(scrRect, maskRect, config, img, persons)
        {
            nameRects = new List<Rectangle>();
            interval = 1;
            curInterval = 1;
            twinpersons = null;
            curShowItem = -1;
        }

        private int curShowItem;


        protected override void PaintDrawBg(Graphics g)
        {
            Image img = imgdb.DrawBg;
            g.DrawImage(img,
                new Rectangle(0, 0, this.screenRect.Width, this.screenRect.Height),
                new Rectangle(0, 0, img.Width, img.Height),
                GraphicsUnit.Pixel);
        }

        protected override List<Person> PaintDrawText(Graphics g)
        {
            curShowItem = -1;

            if (!IsInterval())
            {
                twinpersons = persons.GetRandomList(prize.Num);
            }

            Color fcolor = System.Drawing.ColorTranslator.FromHtml(config.mFont.colorStr);
            Font mFont = new Font(config.mFont.family, config.mFont.size);
            SolidBrush bru3 = new SolidBrush(Color.FromArgb(fcolor.R, fcolor.G, fcolor.B));
            int i = 0;
            foreach (var person in twinpersons)
            {
                Rectangle rect = nameRects[i];
                string text = "";
                if (config.isShowName == 1)
                    text += person.Name + "，";
                text += person.Text;
                g.DrawString(text, mFont, bru3, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
                i++;
            }
            return twinpersons;
        }

        protected override void PaintMask(Graphics g)
        {
            Color mcolor = ColorTranslator.FromHtml(config.colorStr);
            SolidBrush bru2 = new SolidBrush(Color.FromArgb(200, mcolor.R, mcolor.G, mcolor.B));
            g.FillRectangle(bru2, maskRect);
        }

        protected override void PaintShowBg(Graphics g)
        {
            Image img = imgdb.ShowBg;
            g.DrawImage(img,
                new Rectangle(0, 0, this.screenRect.Width, this.screenRect.Height),
                new Rectangle(0, 0, img.Width, img.Height),
                GraphicsUnit.Pixel);
        }

        protected override void PaintTitle(Graphics g)
        {
            Color tcolor = ColorTranslator.FromHtml(config.tFont.colorStr);
            Font tFont = new Font(config.tFont.family, config.tFont.size);
            SolidBrush bru1 = new SolidBrush(Color.FromArgb(tcolor.R, tcolor.G, tcolor.B));
            // SizeF tsize = g.MeasureString(prize.Name, tFont);
            g.DrawString(prize.Name, tFont, bru1, config.tX,config.tY);
        }
        public override bool Click(Point location,Graphics g)
        {
            if (!maskRect.Contains(location))
                return false;
            for(int i=0;i<nameRects.Count;i++)
            {
                if(nameRects[i].Contains(location))
                {

                    curShowItem = i;
                    DrawSingleText(g);
                    return true;
                }
            }
            
            return false;
        }
        public override void PaintResult(List<Person> persons, Graphics g)
        {
            base.PaintResult(persons, g);
            DrawSingleText(g);
        }
        private void DrawSingleText(Graphics g)
        {
            if (curShowItem < 0)
                return;
            if (curShowItem >= twinpersons.Count)
                return;

            Person person = twinpersons[curShowItem];

            // 画背景框
            Rectangle rect = new Rectangle();
            rect.X= nameRects[nameRects.Count - 1].X + nameRects[nameRects.Count - 1].Width / 2;
            rect.Y = 0;//maskRect.Y - 50;
            rect.Width = this.screenRect.Width - rect.X;
            rect.Height = this.screenRect.Height;//maskRect.Height + 100;

            Color mcolor = ColorTranslator.FromHtml(config.colorStr);
            SolidBrush bru2 = new SolidBrush(Color.FromArgb(mcolor.R, mcolor.G, mcolor.B));
            g.FillRectangle(bru2, rect);

            // 画姓名
            Color fcolor = System.Drawing.ColorTranslator.FromHtml(config.mFont.colorStr);
            Font mFont = new Font(config.mFont.family, config.mFont.size);
            SolidBrush bru3 = new SolidBrush(Color.FromArgb(fcolor.R, fcolor.G, fcolor.B));

            int fh = (int)(g.MeasureString("一", mFont).Height + 0.5);

            g.DrawString(person.Name, mFont, bru3, new RectangleF(rect.X+10, maskRect.Y - 50, rect.Width-10, fh));
            // 画文字
            g.DrawString(person.Text, mFont, bru3, new RectangleF(rect.X + 10, maskRect.Y - 50 + fh * 2, rect.Width - 10, rect.Height - 20));

        }

        protected override void PaintWinPrize(List<Person> persons, Graphics g)
        {
            if (persons.Count > nameRects.Count)
                return;
            Color fcolor = System.Drawing.ColorTranslator.FromHtml(config.mFont.colorStr);
            Font mFont = new Font(config.mFont.family, config.mFont.size);
            SolidBrush bru3 = new SolidBrush(Color.FromArgb(fcolor.R, fcolor.G, fcolor.B));
            int i = 0;
            foreach (var person in persons)
            {
                Rectangle rect = nameRects[i];
                string text = "";
                text += person.Name + "，";
                text += person.Text;
                g.DrawString(text, mFont, bru3, new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
                i++;
            }
        }
        private List<Rectangle> nameRects;
        private List<Person> twinpersons;

        public override void SetPrize(Prize prize)
        {
            this.prize = prize;
            MakePoints();
        }
        private Point MakeRowColumnNum()
        {
            int MAX = 2;
            int wmaxn = 1;
            int hmaxn = 1;
            int num = prize.Num;

            int n = num / MAX;
            if (num <= 5)
                return new Point(1, num);
            int b = num % MAX > 0 ? 1 : 0;
            return new Point(MAX, num / MAX + b);
           //int n = (int)(imgdb.ScreenSize.Width / (tsize.Width*10)+0.5);

            /*
            int wmaxn = 1;
            int hmaxn = 1;
            int num = prize.Num;
            Font tFont = new Font(config.mFont.family, config.mFont.size);
            SizeF tsize = g.MeasureString("张三——一二三四五六七八九十一二三四五六", tFont);
            int n = (int)(maskRect.Width / tsize.Width);
            if (n <= 0)
                n = 1;

            if (num <= 5)
                return new Point(1, num);
            //int n = (int)(imgdb.ScreenSize.Width / (tsize.Width*10)+0.5);
            int b = num % n > 0 ? 1 : 0;
            return new Point(n, num / n + b);
            */

        }

        private void MakePoints()
        {
            nameRects.Clear();
            Point wh = MakeRowColumnNum();

            int wm = maskRect.Width / 24;
            int hm = maskRect.Height / 30;

            int wn = (maskRect.Width - wm * 2) / wh.X - wm;
            int hn = (maskRect.Height - hm * 2) / wh.Y - hm;

            for (int i = 0; i < wh.Y; i++)
            {
                for (int j = 0; j < wh.X; j++)
                {
                    Rectangle rect = new Rectangle(maskRect.X + wm + (wn + wm) * j, maskRect.Y + hm + (hn + hm) * i, wn, hn);
                    nameRects.Add(rect);
                }
            }
            /*
            //最大字数5个字
            int count = prize.Num;
            Font tFont = new Font(config.mFont.family, config.mFont.size);
            SizeF tsize = g.MeasureString("张三——一二三四五六七八九十一二三四", tFont);

            // 取几行几列的排列
            Point rcn = MakeRowColumnNum(g);
            int wmaxn = rcn.X;
            int hmaxn = rcn.Y;
            int num = prize.Num;
            int wspace = (int)(tsize.Width*1.1);
            int hspace = (int)(tsize.Height * 2.5);

            Rectangle textRect = new Rectangle(0, 0, (wmaxn - 1) * wspace + (int)tsize.Width, (hmaxn - 1) * hspace + (int)tsize.Height);
            Point sp = new Point((maskRect.Width - textRect.Width) / 2 + maskRect.X,
                (maskRect.Height - textRect.Height) / 2 + maskRect.Y);


            for (int j1 = 0; j1 < hmaxn; j1++)
            {
                for (int i1 = 0; i1 < wmaxn; i1++)
                {
                    Rectangle rect = new Rectangle(sp.X + i1 * wspace, sp.Y + j1 * hspace, (int)tsize.Width, (int)(tsize.Height*2.5));
                    nameRects.Add(rect);
                }
            }
            */

        }
    }
}
