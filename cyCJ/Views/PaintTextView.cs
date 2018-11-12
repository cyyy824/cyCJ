using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cyCJ.Models;
using cyCJ.Util;

namespace cyCJ.Views
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

            return twinpersons;
        }

        protected override void PaintMask(Graphics g)
        {
        }

        protected override void PaintShowBg(Graphics g)
        {
        }

        protected override void PaintTitle(Graphics g)
        {
        }
        public override bool Click(Point location,Graphics g)
        {
            
            return false;
        }
        public override void PaintResult(List<Person> persons, Graphics g)
        {
            base.PaintResult(persons, g);
            DrawSingleText(g);
        }
        private void DrawSingleText(Graphics g)
        {

        }

        protected override void PaintWinPrize(List<Person> persons, Graphics g)
        {
        }
        private List<Rectangle> nameRects;
        private List<Person> twinpersons;

        public override void SetPrize(Prize prize)
        {
        }
        private Point MakeRowColumnNum()
        {
            return new Point(0, 0);
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

        }
    }
}
