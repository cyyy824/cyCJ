using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public class PersonCollection:CollectionBase<Person>
    {
        public override void ReadDB()
        {
            var conn = DBContext.DBConnection;
            var query = conn.Table<Person>();
            _items.Clear();
            foreach (var item in query)
            {
                _items.Add(item);
            }
        }
    }
}
