using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace cyCJ.Models
{
    public class ConfigSingleton
    {
        private static Config _config = null;
        private ConfigSingleton() { }
        public static Config Instance
        {
            get
            {
                if (_config == null)
                {
                    _config = new Config();
                    _config.Init();
                }
                return _config;
            }
        }
    }
    public class Config
    {
        public string DBPath;
        public Point StartPoint;
        public Size DlgSize;

        public Config()
        {
            DBPath = "";
            StartPoint.X = 200;
            StartPoint.Y = 100;

            DlgSize.Width = 600;
            DlgSize.Height = 400;
        }
        public void Init()
        {
            string cfpath = "config.json";
            if (!File.Exists(cfpath))
            {
                this.SaveJson(cfpath);
            }
            this.ReadJson(cfpath);
        }
        public bool ReadJson(string path)
        {
            StreamReader file = File.OpenText(path);
            JsonReader read = new JsonTextReader(file);
            JsonSerializer serializer = new JsonSerializer();
            object o = serializer.Deserialize(read,typeof(Config));
            Config c1 = o as Config;
            this.DBPath = c1.DBPath;
            this.StartPoint.X = c1.StartPoint.X;
            this.StartPoint.Y = c1.StartPoint.Y;
            this.DlgSize.Width = c1.DlgSize.Width;
            this.DlgSize.Height = c1.DlgSize.Height;

            return true;
        }
        public void SaveJson(string path)
        {
            string output = JsonConvert.SerializeObject(this);
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this);
            }

        }
    }
    
}
