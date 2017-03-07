using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class Compressor
    {
        public List<BitArray> getBitmapPlanes(Bitmap image)
        {
            List<BitArray> planes = new List<BitArray>();
           
            BitmapData data = image.LockBits(new Rectangle(0, 0,image.Width, image.Height),ImageLockMode.ReadOnly,PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[data.Stride * data.Height];

            Marshal.Copy(data.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            image.UnlockBits(data);
            BitArray bitArray = new BitArray(pixelBuffer);
            
            BitArray[] newBitArray = new BitArray[32];
            for (int j = 0; j < 32; j++)
            {
                newBitArray[j] = new BitArray(image.Width * image.Height);
                planes.Add(newBitArray[j]);
            }
            for (int bit = 0; bit < bitArray.Length; bit++)
            {
                int planeNumber = bit % 32;
                int k = 0;
                k = bit / 32;
                newBitArray[planeNumber][k] = bitArray[bit];
            }
            return planes;
        }

        public String runlengthCoding(BitArray bitArray, int width, int height)
        {
            String runlengthCode = "";
            Boolean currentBit = bitArray[0];
            int count = 0;
            for (int i = 0; i < bitArray.Length; i++)
            {
                if (i % width == 0)
                {
                    if (i / width > 0)
                    {
                        runlengthCode += "\n";
                    }
                    count = 0;
                    currentBit = bitArray[i];
                    if (bitArray[i])
                    {
                        runlengthCode += 1;
                        count++;
                    }
                    else
                    {
                        runlengthCode += 0;
                        count++;
                    }
                }
                else if (currentBit == bitArray[i])
                {
                    count++;
                }
                else {
                    runlengthCode += ", " + count;
                    currentBit = bitArray[i];
                    count = 1;
                }
            }
            return runlengthCode;
        }

        public Bitmap deCompressBitPlanes(List<Bitmap> bitplanes)
        {
            Bitmap bitmap = new Bitmap(bitplanes.ElementAt(0).Width, bitplanes.ElementAt(0).Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    double i= 0;
                    int value = 0;
                    foreach(Bitmap bitplane in bitplanes)
                    {
                        int grayscale = (int)((bitplane.GetPixel(x, y).R * .3) + (bitplane.GetPixel(x, y).G * 0.59) + (bitplane.GetPixel(x, y).B * 0.11));
                        value += (bitplane.GetPixel(x, y).A)*((int)Math.Pow(2,i)) ;
                        i++;
                    }
                    Color color = Color.FromArgb(value);
                    bitmap.SetPixel(x, y, color);
                }
            }
            return bitmap;
        }
        /*
        public Bitmap deCompressBitPlanes2(Bitmap b,List<BitArray> bitArray)
        {
            Bitmap bitmap = (Bitmap)b.Clone();
            int width = bitmap.Width;
            for (int pixel = 0; pixel < bitmap.Width * bitmap.Height; pixel++)
            {
                int h = pixel / width;
                int value = 0,i=0;
                foreach (BitArray bit in bitArray)
                {
                    if (bit[pixel])
                    {
                        value += 1 * ((int)Math.Pow(2, i));
                    }
                    i++;                   
                }
                Color color = Color.FromArgb(value);
                bitmap.SetPixel(pixel % width, h, Color.White);
               
            }
            return bitmap;
        }*/

        public byte[] convert(Bitmap bitmap)
        {
            ImageConverter converter = new ImageConverter();
            byte[] newBA = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
            return newBA;
        }

        public double Average(Bitmap bitmap)
        {
            byte[] blist = this.convert(bitmap);
            int sum = 0;

            for (int i = 0; i < blist.Length; i++)
            {
                sum += blist[i];
            }

            double avg = (double)sum / blist.Length;
            return avg;
        }

        public double sd(Bitmap bitmap)
        {
            byte[] blist = this.convert(bitmap);
            double average = this.Average(bitmap);
            double sumOfSquaresOfDifferences = blist.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / blist.Length);
            return sd;
        }

        public BitArray EntropyEncoding(Bitmap bitmap, int width, int height)
        {
            byte[] buffer = this.convert(bitmap);

            var tempBuff = new byte[buffer.Length];

            for (int i = 0; i < buffer.Length; i++)
            {
                tempBuff[i] = buffer[i];
            }

            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    int offsetUp = ((i - 1) * width) + (j - 1);
                    int offset = (i * width) + (j - 1);

                    int a = tempBuff[offsetUp];
                    int b = tempBuff[offsetUp + 1];
                    int c = tempBuff[offsetUp + 2];
                    int d = tempBuff[offset];
                    int pixel = tempBuff[offset + 1];

                    var ave = (a + b + c + d) / 4;
                    var val = (byte)(ave - pixel);
                    buffer[offset + 1] = val;
                }
            }
            BitArray bitArray = new BitArray(buffer);
            return bitArray;
        }

        public BitArray EntropyDecoding(Bitmap bitmap, int width, int height)
        {
            byte[] buffer = this.convert(bitmap);
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    int offsetUp = ((i - 1) * width) + (j - 1);
                    int offset = (i * width) + (j - 1);

                    int a = buffer[offsetUp];
                    int b = buffer[offsetUp + 1];
                    int c = buffer[offsetUp + 2];
                    int d = buffer[offset];
                    int pixel = buffer[offset + 1];

                    var ave = (a + b + c + d) / 4;
                    var val = (byte)(ave - pixel);
                    buffer[offset + 1] = val;
                }
            }
            BitArray bitArray = new BitArray(buffer);
            return bitArray;
        }
    }
}
