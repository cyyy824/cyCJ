using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using cyCJ.Util;

namespace cyCJ.Models
{
    public class DrawPara
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ShowPicPath { get; set; }

        public string DrawPicPath { get; set; }

        public string Color { get; set; }

        public string TitleFamily { get; set; }
        public string TitleColor { get; set; }
        public float TitleSize { get; set; }
        
        public string TextFamily { get; set; }
        public string TextColor { get; set; }
        public float TextSize { get; set; }

        public int IsDrawMask { get; set; }

        public int MaskX { get; set; }

        public int MaskY { get; set; }

        public int MaskW { get; set; }

        public int MaskH { get; set; }

        public DrawPara()
        {
            CFont cf = new CFont();
            ShowPicPath = "";
            DrawPicPath = "";
            Color = "black";
            TitleFamily = cf.family;
            TitleColor = cf.colorStr;
            TitleSize = cf.size;
            TextFamily = cf.family;
            TextColor = cf.colorStr;
            TextSize = cf.size;

            IsDrawMask = 1;
            MaskX = 200;
            MaskY = 200;
            MaskW = 500;
            MaskH = 400;
        }

    }
}
