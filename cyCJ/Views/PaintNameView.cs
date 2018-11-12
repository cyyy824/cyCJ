using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using cyCJ.Models;

namespace cyCJ.Views
{
    public class PaintNameView : PaintViewBase
    {
        public PaintNameView(Rectangle scrRect, Rectangle maskRect, Config config,ImageDB img,PersonDrawCollection persons) 
            :base(scrRect,maskRect,config,img,persons)
        {
            nameRects = new List<Rectangle>();
            interval = 1;
            curInterval = 1;
            curShowItem = -1;
        }

        private int curShowItem;

        private List<Rectangle> nameRects;
        
        private List<Person> twinpersons;
        public override void SetPrize(Prize prize)
        {
            this.prize = prize;
            MakePoints();
        }

        private Point MakeRowColumnNum()//Graphics g)
        {

            int wmaxn = 1;
            int hmaxn = 1;
            int num = prize.Num;

            if (num <= 5)
                return new Point(1, num);
            //int n = (int)(imgdb.ScreenSize.Width / (tsize.Width*10)+0.5);

            int i1, j1;
            for (i1 = 1, j1 = 1; i1 < num; i1++)
            {
                if (i1 * j1 >= num)
                {
                    wmaxn = i1;
                    hmaxn = j1;
                    break;
                }
                j1 = i1 + 1;
                if (i1 * j1 >= num)
                {
                    wmaxn = i1;
                    hmaxn = j1;
                    break;
                }
            }
            return new Point(wmaxn, hmaxn);
        }

        public override bool Click(Point location, Graphics g)
        {
            if (!maskRect.Contains(location))
                return false;
            for (int i = 0; i < nameRects.Count; i++)
            {
                if (nameRects[i].Contains(location))
                {

                    curShowItem = i;
                    DrawSingleText(g);
                    return true;
                }
            }

            return false;
        }
        private void DrawSingleText(Graphics g)
        {
            if (curShowItem < 0)
                return;
            if (curShowItem >= twinpersons.Count)
                return;


        }
        public override void PaintResult(List<Person> persons, Graphics g)
        {
            base.PaintResult(persons, g);
            DrawSingleText(g);
        }

        private void MakePoints()
        {
            nameRects.Clear();

            Point wh = MakeRowColumnNum();

            int wm = maskRect.Width / 16;
            int hm = maskRect.Height / 20;

            int wn = (maskRect.Width-wm*2) / wh.X-wm;
            int hn = (maskRect.Height-hm*2) / wh.Y-hm;


            for(int i=0;i<wh.Y;i++)
            {
                for(int j=0;j<wh.X;j++)
                {
                    Rectangle rect = new Rectangle(maskRect.X+wm+(wn+wm)*j,maskRect.Y+hm+(hn+hm)*i,wn,hn);
                    nameRects.Add(rect);
                }

            }
            
            
        }
        protected override void PaintMask(Graphics g)
        {
        }
        
        protected override void PaintTitle(Graphics g)
        {
        }

        protected override void PaintWinPrize(List<Person> persons,Graphics g)
        {
            
        }

        protected override void PaintDrawBg(Graphics g)
        {
        }

        protected override List<Person> PaintDrawText(Graphics g)
        {
            return twinpersons;
        }

        protected override void PaintShowBg(Graphics g)
        {
        }

    }
}
