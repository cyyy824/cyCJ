using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ
{
    public class CFont
    {
        public CFont(string family = "宋体", string color = "black", float size = 20)
        {
            this.family = family;
            this.colorStr = color;
            this.size = size;
        }
        public string family;
        public string colorStr;
        public float size;
    }
}
