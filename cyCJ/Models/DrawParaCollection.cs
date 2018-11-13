using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public class DrawParaCollection:CollectionBase<DrawPara>
    {
        public override void ReadDB()
        {
            var conn = DBContext.DBConnection;
            var query = conn.Table<DrawPara>();
            _items.Clear();
            foreach (var item in query)
            {
                _items.Add(item);
            }
        }
    }
}
