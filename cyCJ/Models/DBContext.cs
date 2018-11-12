using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace cyCJ.Models
{
    public class DBContext
    {
        public static void InitDB()
        {
            if ( !File.Exists(ConfigSingleton.Instance.DBPath))
            {
                var db = DBContext.DBConnection;
                
                db.CreateTable<Person>();
                db.CreateTable<Prize>();
                db.CreateTable<WinPrize>();
                db.CreateTable<DrawPara>();
                db.Insert(new DrawPara());
     
            }
        }
        public static SQLiteConnection DBConnection
        {
            get
            {
                var databasePath = ConfigSingleton.Instance.DBPath;
                var db = new SQLiteConnection(databasePath);
                return db;
            }
        }
    }
}
