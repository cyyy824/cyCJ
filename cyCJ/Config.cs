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

namespace cyCJ
{
    public class Config
    {
        public string picdpath;
        public string picspath;
        public string colorStr;
        public CFont tFont;
        public CFont mFont;
        public int isShowName;
        public int drawType;
        public int isDrawMask;
        public int isAutoMaskLocation;
        public int maskX;
        public int maskY;
        public int maskW;
        public int maskH;
        public int tX;
        public int tY;

        private string connstr;

        public string Connstr { get => connstr; set => connstr = value; }

        public Config(string dbpath)
        {
            /*
            dict = new Dictionary<string, string>();
            dict["showImgPath"] = "picspath";
            dict["drawImgPath"] = "picdpath";
            dict["colorMask"] = "colorStr";
            dict["isShowName"] = "isShowName";
            dict["fColor"] = "mFont.color";
            dict["fFamily"] = "mFont.family";
            dict["fSize"] = "mFont.size";
            dict["tColor"] = "tFont.color";
            dict["tFamily"] = "tFont.family";
            dict["tSize"] = "tFont.size";
            */

            connstr = dbpath;
            picdpath = "";
            picspath = "";
            colorStr = "Snow";
            tFont = new CFont();
            mFont = new CFont();
            isShowName = 1;
            drawType = 1;
            isDrawMask=1;
            isAutoMaskLocation=1;
            maskX=0;
            maskY=0;
            maskW=0;
            maskH=0;
            tX = 0;
            tY = 0;

        }
        public void ReadDB()
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + connstr);
            cn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from config";
            SQLiteDataReader sr = cmd.ExecuteReader();
            while(sr.Read())
            {
                switch(sr.GetString(1))
                {
                    case "showImgPath":
                        picspath = sr.GetString(2);
                        break;
                    case "drawImgPath":
                        picdpath = sr.GetString(2);
                        break;
                    case "colorMask":
                        if(sr.GetString(2)!="")
                            colorStr = sr.GetString(2);
                        break;
                    case "isShowName":
                        if (sr.GetString(2) != "")
                            isShowName =int.Parse(sr.GetString(2));
                        break;
                    case "drawType":
                        if (sr.GetString(2) != "")
                            drawType = int.Parse(sr.GetString(2));
                        break;
                    case "fColor":
                        if(sr.GetString(2)!="")
                           this.mFont.colorStr = sr.GetString(2);
                        break;
                    case "fFamily":
                        if(sr.GetString(2) !="")
                           this.mFont.family = sr.GetString(2);
                        break;
                    case "fSize":
                        if(sr.GetString(2)!="")
                            this.mFont.size = float.Parse(sr.GetString(2));
                        break;
                    case "tfColor":
                        if(sr.GetString(2)!="")
                            this.tFont.colorStr = sr.GetString(2);
                        break;
                    case "tfFamily":
                        if(sr.GetString(2)!="")
                            this.tFont.family = sr.GetString(2);
                        break;
                    case "tfSize":
                        if(sr.GetString(2)!="")
                            this.tFont.size = float.Parse(sr.GetString(2));
                        break;
                    case "isDrawMask":
                        if (sr.GetString(2) != "")
                            this.isDrawMask = int.Parse(sr.GetString(2));
                        break;
                    case "isAutoMaskLocation":
                        this.isAutoMaskLocation= int.Parse(sr.GetString(2));
                        break;
                    case "maskX":
                        this.maskX = int.Parse(sr.GetString(2));
                        break;
                    case "maskY":
                        this.maskY = int.Parse(sr.GetString(2));
                        break;
                    case "maskW":
                        this.maskW = int.Parse(sr.GetString(2));
                        break;
                    case "maskH":
                        this.maskH = int.Parse(sr.GetString(2));
                        break;
                    case "tX":
                        this.tX = int.Parse(sr.GetString(2));
                        break;
                    case "tY":
                        this.tY = int.Parse(sr.GetString(2));
                        break;

                }
            }

            sr.Close();
            cn.Close();
        }
        public bool SaveDB()
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + connstr);
            cn.Open();
            System.Data.Common.DbTransaction trans = cn.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = cn;
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='showImgPath'";
            cmd.Parameters.Add("fieldvalue", DbType.String).Value = this.picspath;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='drawImgPath'";
            cmd.Parameters["fieldvalue"].Value = picdpath;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='colorMask'";
            cmd.Parameters["fieldvalue"].Value = colorStr;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='isShowName'";
            cmd.Parameters["fieldvalue"].Value = isShowName.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='drawType'";
            cmd.Parameters["fieldvalue"].Value = drawType.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='fColor'";
            cmd.Parameters["fieldvalue"].Value = mFont.colorStr;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='fFamily'";
            cmd.Parameters["fieldvalue"].Value = mFont.family;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='fSize'";
            cmd.Parameters["fieldvalue"].Value = mFont.size.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='tfColor'";
            cmd.Parameters["fieldvalue"].Value = tFont.colorStr;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='tfFamily'";
            cmd.Parameters["fieldvalue"].Value = tFont.family;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='tfSize'";
            cmd.Parameters["fieldvalue"].Value = tFont.size.ToString();
            cmd.ExecuteNonQuery();

            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='isDrawMask'";
            cmd.Parameters["fieldvalue"].Value = isDrawMask.ToString();//tFont.size.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='isAutoMaskLocation'";
            cmd.Parameters["fieldvalue"].Value = isAutoMaskLocation.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='maskX'";
            cmd.Parameters["fieldvalue"].Value = maskX.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='maskY'";
            cmd.Parameters["fieldvalue"].Value = maskY.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='maskW'";
            cmd.Parameters["fieldvalue"].Value = maskW.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='maskH'";
            cmd.Parameters["fieldvalue"].Value = maskH.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='tX'";
            cmd.Parameters["fieldvalue"].Value = tX.ToString();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update config set fieldvalue=@fieldvalue where fieldkey='tY'";
            cmd.Parameters["fieldvalue"].Value = tY.ToString();
            cmd.ExecuteNonQuery();


            trans.Commit();
            cn.Close();

            return true;
        }
    }
}
