using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using cyCJ.SQLiteHelper;
using cyCJ.Models;

namespace cyCJ.DB
{
    public class PublicDB
    {
        public static void CreateDB()
        {

        }

        private static void CreateConfigTable()
        {
            var config = ConfigSingleton.Instance;
            var connstr = config.DBPath;
        }
    }
}
