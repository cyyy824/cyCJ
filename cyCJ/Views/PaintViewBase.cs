using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using cyCJ.Models;

namespace cyCJ.Views
{
    public abstract class PaintViewBase
    {
        protected Prize prize;
        protected Rectangle screenRect;
        protected Rectangle maskRect;
        protected Config config;
        protected ImageDB imgdb;
        protected PersonDrawCollection persons;
        protected int interval;
        protected int curInterval;

        public virtual bool Click(Point location,Graphics g)
        {
            return false;

        }

        public PaintViewBase(Rectangle scrRect,Rectangle maskRect,Config config,ImageDB img,PersonDrawCollection persons)
        {
            this.persons = persons;
            this.screenRect = new Rectangle(scrRect.X, scrRect.Y, scrRect.Width, scrRect.Height);
            this.maskRect = new Rectangle(maskRect.X, maskRect.Y, maskRect.Width, maskRect.Height);
            this.config = config;
            this.imgdb = img;

            interval = 1;
            curInterval = 1;
        }
        protected bool IsInterval()
        {
            if (curInterval >= interval)
            {
                curInterval = 0;
                return false;
            }
            curInterval++;
            return true;
        }
        public virtual void SetInterval(int inter)
        {
            interval = inter;
            curInterval = interval;
        }
        public virtual void SetScreenRect(Rectangle rect)
        {
            screenRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public virtual void SetMaskRect(Rectangle rect)
        {
            maskRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
        }
        public virtual void SetPersons(PersonDrawCollection persons)
        {
            this.persons = persons;
        }
        public virtual void SetPrize(Prize prize)
        {
            this.prize = prize;
        }
        protected abstract void PaintShowBg(Graphics g);
        protected abstract void PaintDrawBg(Graphics g);
        protected abstract void PaintTitle(Graphics g);
        protected abstract void PaintMask(Graphics g);
        protected abstract List<Person> PaintDrawText(Graphics g);
        protected abstract void PaintWinPrize(List<Person> persons,Graphics g);

        public virtual void PaintShow(Graphics g)
        {
            PaintShowBg(g);
        }
        public virtual void PaintResult(List<Person> persons,Graphics g)
        {
            PaintDrawBg(g);
        }
        public virtual void PaintCancel(Graphics g)
        {
            PaintShowBg(g);
            /*
            PaintDrawBg(g);
            PaintMask(g);
            PaintTitle(g);
            */
        }
        public virtual List<Person> PaintDrawing(Graphics g)
        {
            return null;

        }


    }
}
