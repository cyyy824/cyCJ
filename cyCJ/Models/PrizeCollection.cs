﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public class PrizeCollection : CollectionBase<Prize>
    {
        public PrizeCollection()
        {
        }
        public override void ReadDB()
        {
            var conn = DBContext.DBConnection;
            var query = conn.Table<Prize>();
            _items.Clear();
            foreach(var prize in query)
            {
                _items.Add(prize);
            }
        }

    }
}
