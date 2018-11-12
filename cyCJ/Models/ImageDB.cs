using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyCJ.Models
{
    public class ImageDB
    {
        private Image showBg;
        private Image drawBg;
        private Image hidenameImage;

        private Size screenSize;

        public Image ShowBg { get => showBg; }
        public Image DrawBg { get => drawBg;}
        public Image HidenameImage { get => hidenameImage; set => hidenameImage = value; }
        public Size ScreenSize { get => screenSize; }

        public ImageDB()
        {
            showBg = null;
            drawBg = null;
            hidenameImage = null;

            screenSize.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            screenSize.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        }

        // 读取展示背景图片
        public bool ReadShowBG(string path)
        {
            showBg = ReadBG(path);
            if (showBg == null)
                return false;
            return true;
        }
        // 读取抽奖背景图片
        public bool ReadDrawBG(string path)
        {
            drawBg = ReadBG(path);
            if (drawBg == null)
                return false;
            return true;
        }
        // 读取抽奖名遮挡图片
        public bool ReadHideNameImage(string path)
        {
            Image im;
            try {
                im = Image.FromFile(path);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("{0}",e.Message);
                return false;
            }
            hidenameImage = zoompicture(im, 60, 60);
            if (hidenameImage == null)
                return false;

            return true;
        }
        private Image ReadBG(string path)
        {
            Image im;
            try {
                im = Image.FromFile(path);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("{0}",e.Message);
                return null;
            }
            return zoompicture(im, screenSize.Width, screenSize.Height);
        }

        private Image zoompicture(Image sourceImage, int targetWidth, int targetHeight)
        {
        //    int width;//图片最终的宽  
        //    int height;//图片最终的高  

            try
            {
                Bitmap targetPicture = new Bitmap(targetWidth, targetHeight);
                Graphics g = Graphics.FromImage(targetPicture);

                g.DrawImage(sourceImage, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), GraphicsUnit.Pixel);
                return targetPicture;
            }
            catch (Exception ex)
            {

                return null;
            }

            /*
            try
            {
                System.Drawing.Imaging.ImageFormat format = sourceImage.RawFormat;
                Bitmap targetPicture = new Bitmap(targetWidth, targetHeight);
                Graphics g = Graphics.FromImage(targetPicture);
                g.Clear(Color.White);

                //计算缩放图片的大小  
                if (sourceImage.Width > targetWidth && sourceImage.Height <= targetHeight)
                {
                    width = targetWidth;
                    height = (width * sourceImage.Height) / sourceImage.Width;
                }
                else if (sourceImage.Width <= targetWidth && sourceImage.Height > targetHeight)
                {
                    height = targetHeight;
                    width = (height * sourceImage.Width) / sourceImage.Height;
                }
                else if (sourceImage.Width <= targetWidth && sourceImage.Height <= targetHeight)
                {
                    width = sourceImage.Width;
                    height = sourceImage.Height;
                }
                else
                {
                    width = targetWidth;
                    height = (width * sourceImage.Height) / sourceImage.Width;
                    if (height > targetHeight)
                    {
                        height = targetHeight;
                        width = (height * sourceImage.Width) / sourceImage.Height;
                    }
                }
                g.DrawImage(sourceImage, (targetWidth - width) / 2, (targetHeight - height) / 2, width, height);
                sourceImage.Dispose();

                return targetPicture;
            }
            catch (Exception ex)
            {

            }
            */
        }
    }
}
