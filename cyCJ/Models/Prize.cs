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
    public class PrizeCollection
    {
        private List<Prize> prizes;
        private string connStr;

        public PrizeCollection(string connStr)
        {
            prizes = new List<Prize>();
            this.connStr = connStr;
            ReadDB();
        }

        public int Count
        {
            get { return prizes.Count; }
        }

        public Prize GetPrize(int index)
        {
            return prizes[index];
        }

        public void UpdatePrize(int index, Prize prize)
        {
            if (index >= Count)
                return;
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "update prize set name=@name,num=@num,imgpath=@imgpath where name=\""+prizes[index].Name+"\"";
            cmd.Parameters.Add("name", DbType.String).Value = prize.Name;
            cmd.Parameters.Add("num", DbType.Int32).Value = prize.Num;
            cmd.Parameters.Add("imgpath", DbType.String).Value = prize.Picpath;
            cmd.ExecuteNonQuery();
            cn.Close();
            prizes[index] = prize;
        }
        public void DeletePrize(int index)
        {
            if (index >= Count)
                return;

            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from prize where name=@name";
            cmd.Parameters.Add("name", DbType.String).Value = prizes[index].Name;
            cmd.ExecuteNonQuery();
            cn.Close();
            prizes.RemoveAt(index);
        }

        public bool Add(Prize prize)
        {
            if (prizes.Contains(prize))
                return false;

            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into prize(name,num,imgpath) values(@name,@num,@imgpath)";
            cmd.Parameters.Add("name", DbType.String).Value = prize.Name;
            cmd.Parameters.Add("num", DbType.Int32).Value = prize.Num;
            cmd.Parameters.Add("imgpath", DbType.String).Value = prize.Picpath;
            cmd.ExecuteNonQuery();
            cn.Close();
            prizes.Add(prize);
            return true;
        }

        public void ReadDB()
        {
            prizes.Clear();
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from prize";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                Prize item = new Prize(sr.GetString(1), sr.GetInt32(2), sr.GetString(3));
                prizes.Add(item);
            }
            sr.Close();
            cn.Close();
        }

    }
    public class Prize
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }



        private string picpath;

        public Prize(string _name,int _num,string _picpath)
        {
            name = _name;
            num = _num;
            picpath = _picpath;
        }

        public string Name { get => name; set => name = value; }
        public int Num { get => num; set => num = value; }
        public string Picpath { get => picpath; set => picpath = value; }

        public override bool Equals(object obj)
        {
            Prize p = obj as Prize;
            if (p.Name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
