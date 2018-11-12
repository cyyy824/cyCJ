using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cyCJ.Models;
using cyCJ.Views;

namespace cyCJ.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            openTime = DateTime.Now;
            config = new Config();//cyCJ.Models.ConfigSingleton.Instance;
            config.CreateDB();
            config.ReadDB();
            persons = new PersonCollection(DB_PATH);
            persons.ReadDB();
            prizes = new PrizeCollection(DB_PATH);
  //          winprizes = new WinPrizeCollection(DB_PATH);
 //           winprizes.ReadDB(openTime);
            imdb = new ImageDB();
        }
        private const string DB_PATH = "prize.db";
        private Config config;
        private PersonCollection persons;
        private PrizeCollection prizes;
        private ImageDB imdb;
//        private WinPrizeCollection winprizes;
        private DateTime openTime;

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            //config.load(CONFIG_PATH);
            // 配置控件
            InitImDB();
            PaintDrawPage();
            PaintShowPage();
            showNameCB.Checked = config.isShowName == 0 ? false:true ;
            drawTypeCB.SelectedIndex = config.drawType;
            startTimeTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            startTimeTP.Value = openTime;

            if( config.isAutoMaskLocation!=0)
            {
                config.maskX = imdb.ScreenSize.Width / 5 / 2;
                config.maskY = imdb.ScreenSize.Height / 4 - imdb.ScreenSize.Height / 8;
                config.maskW = imdb.ScreenSize.Width - imdb.ScreenSize.Width / 5;
                config.maskH = imdb.ScreenSize.Height - imdb.ScreenSize.Height / 4;
                config.tX = imdb.ScreenSize.Width / 2-imdb.ScreenSize.Width/8;
                config.tY = imdb.ScreenSize.Height / 20;


            }
        }

        // 打开抽奖人群设置对话框
        private void setPersonBt_Click(object sender, EventArgs e)
        {
            var pform = new PersonSetForm(persons);
            pform.StartPosition = FormStartPosition.CenterParent;
            pform.ShowDialog();
        }

        // 打开抽奖奖项设置对话框
        private void setPrizeBt_Click(object sender, EventArgs e)
        {
            var pform = new PrizeSetForm(prizes);
            pform.StartPosition = FormStartPosition.CenterParent;
            pform.ShowDialog();
        }

        // 打开抽奖页面
        private void drawBt_Click(object sender, EventArgs e)
        {
            var dform = new DrawPrizeForm(persons, config, prizes, imdb,openTime,drawTypeCB.SelectedIndex);
            dform.ShowDialog();
 //           winprizes.SaveDB();
        }

        // 设置抽奖页面静态背景
        private void updateshowBg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "*.BMP,*.JPG;*.GIF;*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fdlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if(!imdb.ReadShowBG(fdlg.FileName))
            {
                MessageBox.Show("图片读取错误");
                return;
            }
            config.picspath = fdlg.FileName;
            PaintShowPage();
        }

        // 设置抽奖页面播放抽奖动画时的背景
        private void updateBg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "*.BMP,*.JPG;*.GIF;*.PNG|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fdlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if(!imdb.ReadDrawBG(fdlg.FileName))
            {
                MessageBox.Show("图片读取错误");
                return;
            }
            config.picdpath = fdlg.FileName;
            PaintDrawPage();
        }

        // 设置抽奖底色
        private void setMBt_Click(object sender, EventArgs e)
        {
            /*
            Color mcolor;
            if (!GetColorFromDlg(out mcolor))
                return;
            config.colorStr = System.Drawing.ColorTranslator.ToHtml(mcolor);
            PaintDrawPage();
            */
            LocationSetForm dlg = new LocationSetForm(config, imdb);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if( dlg.ShowDialog()==DialogResult.OK)
            {
                PaintDrawPage();
            }

        }

        // 设置抽奖页面内容字体
        private void setFontCBt_Click(object sender, EventArgs e)
        {
            if (!GetFontFromDlg(ref config.mFont))
                return;
            PaintDrawPage();
        }

        // 设置抽奖页面标题字体
        private void settfBt_Click(object sender, EventArgs e)
        {
            if (!GetFontFromDlg(ref config.tFont))
                return;
            PaintDrawPage();
        }

        // 修改抽取时是否显示名字选项
        private void showNameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showNameCB.Checked)
            {
                config.isShowName = 1;
            }
            else
            {
                config.isShowName = 0;
            }
        }

        private void InitImDB()
        {
            imdb.ReadShowBG(config.picspath);
            imdb.ReadDrawBG(config.picdpath);
            imdb.ReadHideNameImage("");
        }

        // 重画展示页面缩略图
        private void PaintShowPage()
        {
            Image im = imdb.ShowBg;
            if( im == null)
            {
                MessageBox.Show("没有设置展示背景图");
                return;
            }
            /*
            Bitmap bit = new Bitmap(showPage.Width, showPage.Height);
            Graphics g = Graphics.FromImage(bit);
            g.DrawImage(im, new Rectangle(0, 0, bit.Width, bit.Height), new Rectangle(0, 0, im.Width, im.Height), GraphicsUnit.Pixel);
            */
            showPage.Image = im;
        }

        // 重画抽奖页面缩略图
        private void PaintDrawPage()
        {
            Image im = imdb.DrawBg;
            if( im == null)
            {
                MessageBox.Show("没有设置抽奖背景图");
                return;
            }
            Bitmap bit = new Bitmap(imdb.ScreenSize.Width, imdb.ScreenSize.Height);
            Graphics g = Graphics.FromImage(bit);
            PaintNameView vi = new PaintNameView(new Rectangle(0, 0, imdb.ScreenSize.Width, imdb.ScreenSize.Height),
                new Rectangle(config.maskX,config.maskY,config.maskW,config.maskH),
                config,
                imdb,
                null);
            if(prizes.Count<=0)
            {
                vi.SetPrize(new Prize("一等奖",5,""));
            }
            else
            {
                vi.SetPrize(prizes.GetPrize(0));
            }
            List<Person> ps = new List<Person>();
            ps.Add(new Person("张三"));
            ps.Add(new Person("李四"));
            vi.PaintResult(ps,g);
        //    vi.PaintCancel(g);
            
            drawPage.Image = bit;
        }

        // 从字体对话框中取得字体
        private bool GetFontFromDlg(ref CFont font)
        {
            FontDialog fDlg = new FontDialog();
            fDlg.Font = new Font(font.family, font.size);
            fDlg.Color = System.Drawing.ColorTranslator.FromHtml(font.colorStr);
            fDlg.ShowColor = true;
            if (fDlg.ShowDialog() != DialogResult.OK)
                return false;
            font.family = fDlg.Font.FontFamily.Name;
            font.size = fDlg.Font.Size;
            font.colorStr = fDlg.Color.Name;
            return true;
        }

        // 从颜色对话框中取颜色
        private bool GetColorFromDlg(out Color color)
        {
            ColorDialog cd = new ColorDialog(); //新建一个颜色选择窗口
            DialogResult result = cd.ShowDialog();  //让用户选择颜色
            color = cd.Color;
            if(result != DialogResult.OK)
                return false;
            return true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //   config.save(CONFIG_PATH);
            config.SaveDB();
        }

        private void winprizeShowBt_Click(object sender, EventArgs e)
        {
            WinPrizeShowForm wpForm = new WinPrizeShowForm(openTime, DB_PATH);
            wpForm.StartPosition = FormStartPosition.CenterParent;
            wpForm.ShowDialog();
        }

        private void drawTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drawTypeCB.SelectedIndex < 0)
                drawTypeCB.SelectedIndex = 0;
            if( drawTypeCB.SelectedIndex==0)
            {
                showNameCB.Checked = true;
                showNameCB.Enabled = false;
            }
            else
            {
                showNameCB.Enabled = true;
            }
            config.drawType = drawTypeCB.SelectedIndex;
        }

        private void startTimeTP_ValueChanged(object sender, EventArgs e)
        {
            openTime = startTimeTP.Value;
        }
    }
}
