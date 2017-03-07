using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    class Histogram
    {
        private Bitmap image = null;
        private Panel e;
        private long[] histogramValues;
        private long maxValue;
        private float xUnit, yUnit;
        private int height, width, offset = 15;
        private int totalPixels, downPercentile, upPercentile;

        public Histogram(Panel e, int height, int width, Bitmap image)
        {
            this.e = e;
            this.height = height;
            this.width = width - offset * 2;
            this.image = image;
            this.totalPixels = image.Width * image.Height;
        }

        public void DrawHistogram()
        {
            histogramValues = findValues();
            setPercentiles();
            foreach (long l in histogramValues)
            {
                Console.Write(l + " ");
            }

            maxValue = histogramValues.Max();
            Console.WriteLine(maxValue);

            ComputeXYUnitValues();
            Draw();
        }

        public long[] findValues()
        {
            long[] myHistogram = new long[256];

            for (int i = 0; i < image.Size.Width; i++)
            {
                for (int j = 0; j < image.Size.Height; j++)
                {
                    System.Drawing.Color c = image.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    myHistogram[Temp]++;
                }
            }

            return myHistogram;
        }

        public double Average()
        {
            histogramValues = findValues();
            long sum = 0;

            for (long i = 0; i < histogramValues.Length; i++)
            {
                sum += histogramValues[i];
            }

            double avg = (double)sum / histogramValues.Length;
            return avg;
        }

        public double sd()
        {
            histogramValues = findValues();
            double average = this.Average();
            double sumOfSquaresOfDifferences = histogramValues.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / histogramValues.Length);
            return sd;
        }

        private void ComputeXYUnitValues()
        {
            yUnit = (float)(this.height - (2 * offset)) / maxValue;
            xUnit = (float)(this.width - (2 * offset)) / (histogramValues.Length - 1);
        }

        private void Draw()
        {
            Color myColor = Color.Black;
            Font myFont = new Font("Calibri", 10);

            Graphics g = e.CreateGraphics();
            Pen myPen = new Pen(new SolidBrush(myColor), xUnit);

            g.DrawString("0", myFont, new SolidBrush(myColor), new PointF(offset, this.height - myFont.Height - 2), System.Drawing.StringFormat.GenericDefault);
            g.DrawString((histogramValues.Length - 1).ToString(), myFont, new SolidBrush(myColor), new PointF(offset + ((histogramValues.Length - 1) * xUnit) - g.MeasureString((histogramValues.Length - 1).ToString(), myFont).Width, this.height - myFont.Height - 2), System.Drawing.StringFormat.GenericDefault);

            for (int i = 0; i < histogramValues.Length; i++)
            {
                g.DrawLine(myPen, new PointF(offset + (i * xUnit), this.height - offset), new PointF(offset + (i * xUnit), this.height - offset - histogramValues[i] * yUnit));
                if (histogramValues[i] == maxValue)
                {
                    SizeF mySize = g.MeasureString(i.ToString(), myFont);
                    g.DrawString(i.ToString(), myFont, new SolidBrush(Color.Red), new PointF(offset + (i * xUnit) - (mySize.Width), this.height - myFont.Height), System.Drawing.StringFormat.GenericDefault);
                }
            } 
            g.DrawRectangle(new System.Drawing.Pen(new SolidBrush(Color.Black), 1), offset, 0, (255 * xUnit), this.height - offset);

        }

        public void setPercentiles()
        {
            long temp = 0;
            float fivePercentile = (float)totalPixels * 5 / 100;
            float downBound = (float)((float)totalPixels * 4.9 / 100);
            for (int i = 0; i < histogramValues.Length; i++)
            {
                temp += histogramValues[i];
                if ((temp > downBound) && (temp < fivePercentile))
                {
                    downPercentile = i;
                    break;
                }
                if (temp > fivePercentile)
                {
                    downPercentile = i;
                    break;
                }
            }
            temp = 0;
            for (int i = histogramValues.Length - 1; i >= 0; i--)
            {
                temp += histogramValues[i];
                if ((temp > downBound) && (temp < fivePercentile))
                {
                    upPercentile = i;
                    break;
                }
                if (temp > fivePercentile)
                {
                    upPercentile = i;
                    break;
                }
            }
        }

        public int getDownPercentile()
        {
            return downPercentile;
        }

        public int getUpPercentile()
        {
            return upPercentile;
        }
    }
}
