using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class Operation
    {
        public Bitmap flipVImage(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    temp.SetPixel(x, bitmap.Height - 1 - y, originalColor);
                }
            }
            return temp;
        }

        public Bitmap flipHImage(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    temp.SetPixel(bitmap.Width - 1 - x, y, originalColor);
                }
            }
            return temp;
        }

        public Bitmap RotateImage(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    temp.SetPixel(y, x, originalColor);
                }
            }
            temp = flipHImage(temp);
            return temp;
        }

        public Bitmap RotateAntiImage(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    temp.SetPixel(y, x, originalColor);
                }
            }
            temp = flipVImage(temp);
            return temp;
        }
        /*
        public Image Convert(Bitmap oldbmp)
        {
            using (var ms = new MemoryStream())
            {
                oldbmp.Save(ms, ImageFormat.Gif);
                ms.Position = 0;
                return Image.FromStream(ms);
            }
        }*/

        public Bitmap Biliner_down_sampling(Bitmap b,double factor)
        {
            Bitmap bTemp = (Bitmap)b.Clone();
            
            b = new Bitmap((int)((double)bTemp.Width* factor), (int)((double)bTemp.Height * factor), bTemp.PixelFormat);

            for (int x = 0; x < b.Width; ++x)
            {
                for (int y = 0; y < b.Height; ++y)
                {
                    b.SetPixel(x, y, bTemp.GetPixel((int)(Math.Floor(x / factor)),
                                (int)(Math.Floor(y / factor))));
                }

            }

            return b;
        }

        public Bitmap NearestNeighbour(Bitmap b, int value)
        {
            Bitmap bTemp = (Bitmap)b.Clone();

            b = new Bitmap(bTemp.Width * value,bTemp.Height * value, bTemp.PixelFormat);

            for (int x = 0; x < bTemp.Width; x++ )
            {
                for (int y = 0; y < bTemp.Height; y++)
                {
                    for (int i = 0; i < value; i++)
                    {
                        for(int j = 0; j < value; j++)
                        {
                            b.SetPixel(x * value + i, y * value +j, bTemp.GetPixel(x, y));
                        }
                    }
                }                
            }
            return b;
        }
    }
}
