using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class Filter
    {
        public Bitmap grayScale(Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    int grayscale = (int)((originalColor.R * .3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                    Color newColor = Color.FromArgb(grayscale, grayscale, grayscale);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }

        //get the average value of nearby pixels and rplace
        public Bitmap blur(Bitmap bitmap, int blurAmount)
        {
            for (int x = 0; x < bitmap.Width ; x++)
            {
                for (int y = 0; y < bitmap.Height ; y++)
                {

                    Color preX,preY,nextX, nextY;

                    if (x - blurAmount > 0)
                    {
                        preX = bitmap.GetPixel(x - blurAmount, y);
                    }
                    else
                    {
                        preX = bitmap.GetPixel(x, y);
                    }

                    if (y  - blurAmount > 0)
                    {
                        preY = bitmap.GetPixel(x, y - blurAmount);
                    }
                    else
                    {
                        preY = bitmap.GetPixel(x, y);
                    }

                    if ( x+blurAmount < bitmap.Width)
                    {
                         nextX = bitmap.GetPixel(x + blurAmount, y);
                    }
                    else
                    {
                         nextX = bitmap.GetPixel(x , y);
                    }

                    if (y + blurAmount < bitmap.Height)
                    {
                         nextY = bitmap.GetPixel(x, y + blurAmount);
                    }
                    else
                    {
                         nextY = bitmap.GetPixel(x, y);
                    }

                    

                    int avgR = (int)((preX.R + preY.R + nextX.R + nextY.R) / 4);
                    int avgG = (int)((preX.G + preY.G + nextX.G + nextY.G) / 4);
                    int avgB = (int)((preX.B + preY.B + nextX.B + nextY.B) / 4);

                    Color newColor = Color.FromArgb(avgR, avgG, avgB);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }

        public Bitmap AdjustBrightness(Bitmap bitmap, int Value)
        {
            Bitmap TempBitmap = bitmap;
            float FinalValue = (float)Value / 255.0f;
            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float[][] FloatColorMatrix ={
                      new float[] {1, 0, 0, 0, 0},
                      new float[] {0, 1, 0, 0, 0},
                      new float[] {0, 0, 1, 0, 0},
                      new float[] {0, 0, 0, 1, 0},
                      new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();

            return NewBitmap;
        }

        //replace bitmap bitmap by 255-color value of each pixel
        public Bitmap Invert(Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);

                    int Red = pixel.R;
                    int Green = pixel.G;
                    int Blue = pixel.B;

                    bitmap.SetPixel(x, y, Color.FromArgb(255 - Red, 255 - Green, 255 - Blue));
                }
            }
            return bitmap;
        }

        public Bitmap AdjustContrast(Bitmap Image, int Value)
        {
            float contrast = 0.04f * Value;
            Bitmap NewBitmap = new Bitmap(Image.Width, Image.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);
            ImageAttributes Attributes = new ImageAttributes();

            float[][] FloatColorMatrix ={
                      new float[] { contrast, 0f, 0f, 0f, 0f},
                      new float[] {0f, contrast, 0f, 0f, 0f},
                      new float[] {0f, 0f, contrast, 0f, 0f},
                      new float[] {0f, 0f, 0f, 1f, 0f},
                      new float[] { 0.001f, 0.001f, 0.001f, 0f , 1f}
                 };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(Image, new Rectangle(0, 0, Image.Width, Image.Height), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();

            return NewBitmap;
        }

        //replace bitmap bitmap by red color value of each pixel
        public Bitmap Red(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    temp.SetPixel(x, y, Color.FromArgb(255, bitmap.GetPixel(x, y).R, 0, 0));
                }
            }
            return temp;
        }

        //replace bitmap bitmap by green color value of each pixel
        public Bitmap Green(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    temp.SetPixel(x, y, Color.FromArgb(255, 0, bitmap.GetPixel(x, y).G, 0));
                }
            }
            return temp;
        }

        //replace bitmap bitmap by blue color value of each pixel
        public Bitmap Blue(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    temp.SetPixel(x, y, Color.FromArgb(255, 0, 0 , bitmap.GetPixel(x, y).B));
                }
            }
            return temp;
        }

        //
        public Bitmap medianFilter(Bitmap bitmap,int matrixSize,int bias = 0,bool grayscale = false)
        {
            BitmapData data =bitmap.LockBits(new Rectangle(0, 0,bitmap.Width, bitmap.Height),ImageLockMode.ReadOnly,PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[data.Stride *  data.Height];

            byte[] newBuffer = new byte[data.Stride *data.Height];

            Marshal.Copy(data.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bitmap.UnlockBits(data);

            if (grayscale == true)              
            {
                float rgb = 0;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;
            int byteOffset = 0;
            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;

            for (int offsetY = filterOffset; offsetY <bitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <bitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *data.Stride +offsetX * 4;

                    neighbourPixels.Clear();

                    for (int filterY = -filterOffset;filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * data.Stride);
                            neighbourPixels.Add(BitConverter.ToInt32(pixelBuffer, calcOffset));
                        }
                    }
                    neighbourPixels.Sort();
                    middlePixel = BitConverter.GetBytes(neighbourPixels[filterOffset]);

                    newBuffer[byteOffset] = middlePixel[0];
                    newBuffer[byteOffset + 1] = middlePixel[1];
                    newBuffer[byteOffset + 2] = middlePixel[2];
                    newBuffer[byteOffset + 3] = middlePixel[3];
                }
            }

            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            BitmapData newData =newBitmap.LockBits(new Rectangle(0, 0,newBitmap.Width, newBitmap.Height),ImageLockMode.WriteOnly,PixelFormat.Format32bppArgb);

            Marshal.Copy(newBuffer, 0, newData.Scan0,newBuffer.Length);
            newBitmap.UnlockBits(newData);
            return newBitmap;
        }

        //
        public Bitmap EdgeDetection(Bitmap bitmap,double[,] filterMatrix)
        {
            double factor = 1;
            int bias = 0;
            bool grayscale = false;
            BitmapData data =bitmap.LockBits(new Rectangle(0, 0,bitmap.Width, bitmap.Height),ImageLockMode.ReadOnly,PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[data.Stride * data.Height];

            byte[] newBuffer = new byte[data.Stride *data.Height];

            Marshal.Copy(data.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bitmap.UnlockBits(data);

            if (grayscale == true)          
            {
                float rgb = 0;
                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }
            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);
            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;
            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <bitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < bitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY * data.Stride + offsetX * 4;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * data.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            green += (double)(pixelBuffer[calcOffset + 1]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            red += (double)(pixelBuffer[calcOffset + 2]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    if (blue > 255) { blue = 255; }
                    else if (blue < 0) { blue = 0; }

                    if (green > 255) { green = 255; }
                    else if (green < 0) { green = 0; }

                    if (red > 255) { red = 255; }
                    else if (red < 0) { red = 0; }

                    newBuffer[byteOffset] = (byte)(blue);
                    newBuffer[byteOffset + 1] = (byte)(green);
                    newBuffer[byteOffset + 2] = (byte)(red);
                    newBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            BitmapData newData = newBitmap.LockBits(new Rectangle(0, 0,newBitmap.Width, newBitmap.Height),ImageLockMode.WriteOnly,PixelFormat.Format32bppArgb);

            Marshal.Copy(newBuffer, 0, newData.Scan0,newBuffer.Length);
            newBitmap.UnlockBits(newData);
            return newBitmap;
        }
    }
}
