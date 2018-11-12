using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public class PrizeCollection
    {
        private List<Prize> prizes;

        public PrizeCollection()
        {
            prizes = new List<Prize>();
        }
        public void ReadDB()
        {
            var conn = DBContext.DBConnection;
            var query = conn.Table<Prize>();
            prizes.Clear();
            foreach(var prize in query)
            {
                prizes.Add(prize);
            }
        }
        public int Add(Prize prize)
        {
            if( prizes.Contains(prize))
            {
                return -1;
            }
            var conn = DBContext.DBConnection;
            var id = conn.Insert(prize);
            if (id < 0)
                return -1;
            prizes.Add(prize);
            return id;
        }
        public void Update(int index,Prize prize)
        {
            prizes[index].Name = prize.Name;
            prizes[index].Num = prize.Num;
            var conn = DBContext.DBConnection;
            conn.Update(prizes[index]);
        }
        public void Delete(int index)
        {
            Prize prize = prizes[index];

            var conn = DBContext.DBConnection;
            conn.Delete(prize);
            prizes.RemoveAt(index);
        }
        public void Clear()
        {
            var conn = DBContext.DBConnection;
            conn.DeleteAll<Prize>();
            prizes.Clear();
        }

    }
}
