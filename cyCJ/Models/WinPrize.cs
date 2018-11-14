using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using SQLite;

namespace cyCJ.Models
{
    public class WinPrize:ICloneable
    {
        /*
         * 表现在数据库里的一条记录就是
         * id,drawTime,prizeName,prizePic,personName,personText,personPic
         * 
         */
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PrizeName { get; set; }
        public string PersonName { get; set; }
        public string PersonMessage { get; set; }
        private DateTime DrawTime { get; set; }

        public WinPrize()
        {
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
