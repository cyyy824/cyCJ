using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace cyCJ.Models
{
    public class WinPrizeCollection
    {
        private List<WinPrize> winprizes;
        private string connStr;
        public WinPrizeCollection(string connStr)
        {
            this.connStr = connStr;
            winprizes = new List<WinPrize>();
        }

        public void Clear()
        {
            winprizes.Clear();
        }
        public void Add(WinPrize prize)
        {
            winprizes.Add(prize);
        }

        public int Count
        {
            get { return winprizes.Count; }
        }
        public WinPrize GetWinPrize(int index)
        {
            if (index >= Count)
                return null;
            return winprizes[index];
        }

        public void test()
        {
            DateTime tt = DateTime.Now;

            for(int i=0;i<3;i++)
            {
                Prize pr = new Prize(i.ToString(), 0, "");
                WinPrize wp = new WinPrize(pr);
                wp.DrawTime = tt;
                
                for(int j=0;j<10;j++)
                {
                    Person per = new Person(j.ToString());
                    wp.Persons.Add(per);
                }
                winprizes.Add(wp);
            }

        }

        private WinPrize GetWinPrizeFromPrize(Prize prize)
        {
            WinPrize winprize=null;
            foreach(var wit in winprizes)
            {
                if (wit.Prize.Name == prize.Name)
                {
                    winprize = wit;
                    break;
                }
            }
            if(winprize==null)
            {
                winprize = new WinPrize(prize);
                winprizes.Add(winprize);
            }
            return winprize;
        }
        public void ReadDB(DateTime filterTime)
        {
            winprizes.Clear();
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            
            cmd.CommandText = "select * from winprize where drawTime>=\""+filterTime.ToString("yyyy-MM-dd HH:mm:ss:ffff")+"\"";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                Prize prize = new Prize(sr.GetString(1), 0, sr.GetString(2));
                WinPrize wp = GetWinPrizeFromPrize(prize);
                Person item = new Person(sr.GetString(3), sr.GetString(4), sr.GetString(5));
                wp.Persons.Add(item);
            }
            sr.Close();
            cn.Close();
        }
        public void ReadDB(DateTime startTime,DateTime endTime)
        {
            winprizes.Clear();
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;

            cmd.CommandText = string.Format("select * from winprize where drawTime>=\"{0}\" and drawTime<=\"{1}\"",
                startTime.ToString("yyyy-MM-dd HH:mm:ss:ffff"),
                endTime.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                Prize prize = new Prize(sr.GetString(1), 0, sr.GetString(2));
                WinPrize wp = GetWinPrizeFromPrize(prize);
                string tk = sr.GetString(0);
                wp.DrawTime = DateTime.ParseExact(tk, "yyyy-MM-dd HH:mm:ss:ffff", null);
                Person item = new Person(sr.GetString(3), sr.GetString(4), sr.GetString(5));
                wp.Persons.Add(item);
            }
            sr.Close();
            cn.Close();
        }

        public void SaveDB()
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + connStr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            System.Data.Common.DbTransaction trans = cn.BeginTransaction();
            foreach (var wp in winprizes)
            {
                foreach(var pr in wp.Persons)
                {
                    cmd.CommandText = string.Format("insert into winprize values(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\")",
                        wp.DrawTime.ToString("yyyy-MM-dd HH:mm:ss:ffff"),
                        wp.Prize.Name,
                        wp.Prize.Picpath,
                        pr.Name,
                        pr.Text,
                        pr.Picpath);
                    cmd.ExecuteNonQuery();
                }
            }
            trans.Commit();
            cn.Close();
        }


    }
    public class WinPrize
    {
        /*
         * 表现在数据库里的一条记录就是
         * id,drawTime,prizeName,prizePic,personName,personText,personPic
         * 
         */
        private List<Person> persons;
        private Prize prize;
        private DateTime drawTime;

        public WinPrize(Prize prize)
        {
            this.prize = new Prize(prize.Name, prize.Num, prize.Picpath);
            this.persons = new List<Person>();
        }

        public List<Person> Persons { get => persons; set => persons = value; }
        public Prize Prize { get => prize; set => prize = value; }
        public DateTime DrawTime { get => drawTime; set => drawTime = value; }

        public string MakeInsertSql()
        {
            return "";

        }
        public void ReadDB(DateTime filterTime)
        {

        }
        public void SaveDB()
        {

        }

    }
}
