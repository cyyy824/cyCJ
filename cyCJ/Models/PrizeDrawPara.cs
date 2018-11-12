using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace cyCJ.Models
{
    public class DrawPara
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int PrizeId { get; set; }

        public string Picdpath { get; set; }

        public string Picspath { get; set; }

        public string ColorStr { get; set; }

        public CFont tFont { get; set; }

        public CFont mFont { get; set; }

        public int isShowName { get; set; }

        public int isDrawMask { get; set; }

        public int isAutoMaskLocation { get; set; }

        public int maskX { get; set; }

        public int maskY { get; set; }

        public int maskW { get; set; }

        public int maskH { get; set; }

    }
}
