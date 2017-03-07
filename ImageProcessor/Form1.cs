using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
        Operation operation;
        Filter filter;
        Image file;
        Bitmap pictureBoxBitmap;
        Bitmap originalBitmap;
        Bitmap previousBitmap;

        int blurAmount = 1;
        int lastColor = 0;

        Boolean bHaveMouse;
        Point ptOriginal = new Point();
        Point ptLast = new Point();
        Rectangle rectCropArea;

        private Histogram histogram = null;
        private int count = 0;

        Compressor compressor;
        private List<BitArray> array;
        private int planeNo=0;
        

        public Form1()
        {
            InitializeComponent();
            operation = new Operation();
            filter = new Filter();
            compressor = new Compressor();
            bHaveMouse = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                labelMean.Text = compressor.Average((Bitmap)pictureBox1.Image).ToString();
                labelSd.Text = compressor.sd((Bitmap)pictureBox1.Image).ToString();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                originalBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBoxBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = file;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(openFileDialog1.FileName);
                }
            }
            catch
            {/*
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Open an Image First...");
                }*/
            }
            
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveACopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    }
                }

            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void GrayScalebutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.grayScale((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                originalBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBoxBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = file;
                groupBox3.Visible = false;
                groupBox6.Text = "Encoding results :";
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void Undobutton_Click(object sender, EventArgs e)
        {
            if (pictureBoxBitmap != null)
            {
                
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void Blurbutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.blur((Bitmap)pictureBox1.Image, blurAmount);                
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }

        } 

        private void UpdateBlurTrack(object sender, EventArgs e)
        {
            blurAmount = int.Parse(BlurTrackBar.Value.ToString());
            BlurVal.Text = blurAmount.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BrightnessVal.Text = trackBar1.Value.ToString();
                pictureBox1.Image = filter.AdjustBrightness(pictureBoxBitmap, trackBar1.Value);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.Invert((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ContrastVal.Text = trackBar2.Value.ToString();
                pictureBox1.Image = filter.AdjustContrast(pictureBoxBitmap, trackBar2.Value);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void EmbossButton_Click(object sender, EventArgs e)
        {
            /*
            if (pictureBox1.Image != null)
            {
                Bitmap NewBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                for (int x = 1; x <= bitmap.Width - 1 ; x++)
                {
                    for (int y = 1; y <= bitmap.Height - 1; y++)
                    {
                        NewBitmap.SetPixel(x, y, Color.DarkGray);
                    }
                }

                for (int x = 1; x <= bitmap.Width - 1; x++)
                {
                    for (int y = 1; y <= bitmap.Height - 1; y++)
                    {
                        
                            Color pixel = bitmap.GetPixel(x, y);
                            int colorVal = (pixel.R + pixel.G + pixel.B);
                            if ( lastColor == 0 )
                            {
                                lastColor = (pixel.R + pixel.G + pixel.B);
                            }
                            int diff;
                            if (colorVal > lastColor)
                            {
                                diff = colorVal - lastColor;
                            }
                            else
                            {
                                diff = lastColor - colorVal;
                            }
                            if( diff > 100)
                            {
                                NewBitmap.SetPixel(x, y, Color.DarkGray);
                                lastColor = colorVal;
                            }
                     
                    }
                }

                for (int y = 1; y <= bitmap.Height - 1; y++)                    
                {
                    for (int x = 1; x <= bitmap.Width - 1; x++)
                    {
                        
                            Color pixel = bitmap.GetPixel(x, y);
                            int colorVal = (pixel.R + pixel.G + pixel.B);
                            if (lastColor == 0)
                            {
                                lastColor = (pixel.R + pixel.G + pixel.B);
                            }
                            int diff;
                            if (colorVal > lastColor)
                            {
                                diff = colorVal - lastColor;
                            }
                            else
                            {
                                diff = lastColor - colorVal;
                            }
                            if (diff > 100)
                            {
                                NewBitmap.SetPixel(x, y, Color.DarkGray);
                                lastColor = colorVal;
                            }
                        }
                   
                }

                pictureBox1.Image = NewBitmap;
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }*/
        }

        private void RotateClockwisebutton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.RotateImage((Bitmap)pictureBox1.Image);
                //pictureBoxBitmap = operation.RotateImage(pictureBoxBitmap);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.flipHImage((Bitmap)pictureBox1.Image);
                //pictureBoxBitmap = operation.flipHImage(pictureBoxBitmap);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void FlipVerticalButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.flipVImage((Bitmap)pictureBox1.Image);
                //pictureBoxBitmap = operation.flipVImage(pictureBoxBitmap);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void rotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.RotateAntiImage((Bitmap)pictureBox1.Image);
                //pictureBoxBitmap = operation.RotateAntiImage(pictureBoxBitmap);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.Red((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.Green((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.Blue((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        // crop start
        private void cropStartButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Cursor = Cursors.Cross;
                cropStartButton.Visible = false;
                CropSaveButton.Visible = true;
                CropCancelButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void CropSaveButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            //Prepare a new Bitmap on which the cropped image will be drawn
            Graphics g = pictureBox1.CreateGraphics();

            g.DrawImage(pictureBoxBitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),
                rectCropArea, GraphicsUnit.Pixel);
            pictureBoxBitmap.Dispose();
        }

        private void CropCancelButton_Click(object sender, EventArgs e)
        {
            pictureBoxBitmap = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = file;
            pictureBox1.Cursor = Cursors.Default;
            cropStartButton.Visible = true;
            CropSaveButton.Visible = false;
            CropCancelButton.Visible = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Black);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            if (bHaveMouse)
            {
                ptLast = ptCurrent;

                // Draw new lines.

                // e.X - rectCropArea.X;
                // normal
                if (e.X > ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;

                    // e.Y - rectCropArea.Height;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                }
                else if (e.X < ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = ptOriginal.X - e.X;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = ptOriginal.Y;
                }
                else if (e.X > ptOriginal.X && e.Y < ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;
                    rectCropArea.Height = ptOriginal.Y - e.Y;

                    rectCropArea.X = ptOriginal.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = ptOriginal.X - e.X;

                    // e.Y - rectCropArea.Height;
                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Set internal flag to know we no longer "have the mouse".
            bHaveMouse = false;

            // If we have drawn previously, draw again in that spot
            // to remove the lines.
            if (ptLast.X != -1)
            {
                Point ptCurrent = new Point(e.X, e.Y);

            }

            // Set flags to know that there is no "previous" line to reverse.
            ptLast.X = -1;
            ptLast.Y = -1;
            ptOriginal.X = -1;
            ptOriginal.Y = -1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bHaveMouse = true;

            // Store the "starting point" for this rubber-band rectangle.
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;

            ptLast.X = -1;
            ptLast.Y = -1;

            rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
        }
        // end

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                if (count != 0)
                {
                    histogramPanel.Refresh();
                }
                histogram = new Histogram(histogramPanel, histogramPanel.Height, histogramPanel.Width, (Bitmap)pictureBox1.Image);
                histogram.DrawHistogram();
                //labelMean.Text = histogram.Average().ToString();
                //labelSd.Text = histogram.sd().ToString();
                count++;
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Open an Image");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.Biliner_down_sampling((Bitmap)pictureBox1.Image, 0.5); 
                //pictureBoxBitmap = operation.Biliner_down_sampling(pictureBoxBitmap,0.5);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.Biliner_down_sampling((Bitmap)pictureBox1.Image, 0.25);
                //pictureBoxBitmap = operation.Biliner_down_sampling(pictureBoxBitmap, 0.25);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void meanFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = filter.medianFilter((Bitmap)pictureBox1.Image, 5);
                //pictureBoxBitmap = filter.medianFilter(pictureBoxBitmap, 5);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void maskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] filterMatrix = { { 0, 0, -1, 0, 0 },
                                     { 0, -1, -2, -1, 0 },
                                     { -1, -2, 16, -2, -1 },
                                     { 0, -1, -2, -1, 0 },
                                     { 0, 0, -1, 0, 0 } };

            Bitmap newBitmap = filter.EdgeDetection((Bitmap)pictureBox1.Image, filterMatrix);
            pictureBox1.Image = newBitmap;
        }

        private void maskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] filterMatrix = { { 0, 0, -1, -1, -1, 0, 0 },
                                     { 0, -1, -5, -6, -5, -1, 0 },
                                     { -1, -5, -3, 10, -3, -5, -1 },
                                     { -1, -6, 10, 49, 10, -6, -1 },
                                     { -1, -5, -3, 10, -3, -5, -1 },
                                     { 0, -1, -5, -6, -5, -1, 0 },
                                     { 0, 0, -1, -1, -1, 0, 0 }};

            Bitmap newBitmap = filter.EdgeDetection((Bitmap)pictureBox1.Image, filterMatrix);
            pictureBox1.Image = newBitmap;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double[,] filterMatrix = { { 0, 1, 0 },
                                     { 1,-4,1 },
                                     { 0, 1, 0 } };

            Bitmap newBitmap = filter.EdgeDetection((Bitmap)pictureBox1.Image, filterMatrix);
            pictureBox1.Image = newBitmap;
        }

        private void runLengthCodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array = compressor.getBitmapPlanes((Bitmap)pictureBox1.Image);
            pictureBox1.Image = createImagePlane(array.ElementAt(planeNo));
            groupBox6.Text = "Run length code of plane "+planeNo;
            richTextBox1.Text = compressor.runlengthCoding(array.ElementAt(planeNo), ((Bitmap)pictureBox1.Image).Width, ((Bitmap)pictureBox1.Image).Height);
            groupBox3.Visible = true;
        }

        

        private void Left_Click(object sender, EventArgs e)
        {
            planeNo--;
            if (planeNo >= 0)
            {
                pictureBox1.Image = createImagePlane(array.ElementAt(planeNo));
                groupBox6.Text = "Run length code of plane" + planeNo;
                richTextBox1.Text = compressor.runlengthCoding(array.ElementAt(planeNo), ((Bitmap)pictureBox1.Image).Width, ((Bitmap)pictureBox1.Image).Height);
                labelPlaneNo.Text = planeNo.ToString();
            }
            else
            {
                planeNo = 8;
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Right_Click(object sender, EventArgs e)
        {
            planeNo++;
            if (planeNo < 8)
            {
                groupBox6.Text = "Run length code of plane" + planeNo;
                richTextBox1.Text = compressor.runlengthCoding(array.ElementAt(planeNo), ((Bitmap)pictureBox1.Image).Width, ((Bitmap)pictureBox1.Image).Height);

                pictureBox1.Image = createImagePlane(array.ElementAt(planeNo));
                labelPlaneNo.Text = planeNo.ToString();
            }
            else
            {
                planeNo = -1;
            }
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {  
                labelMean.Text = compressor.Average((Bitmap)pictureBox1.Image).ToString();
                labelSd.Text = compressor.sd((Bitmap)pictureBox1.Image).ToString();
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.NearestNeighbour((Bitmap)pictureBox1.Image, 2);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = operation.NearestNeighbour((Bitmap)pictureBox1.Image, 4);
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
            
        }

        private void encodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                Huffman huffman = new Huffman();
                int[] input = huffman.convertToInt((Bitmap)pictureBox1.Image);
                int w = ((Bitmap)pictureBox1.Image).Width;
                int h = ((Bitmap)pictureBox1.Image).Height;

                huffman.Build(input);

                BitArray encoded = huffman.Encode(input);

                pictureBox1.Image = createImagePlane(encoded);
                
                /*
                groupBox6.Text = "Encoded huffman code";
                string code = "";
                foreach (bool bit in encoded)
                {
                    code += (bit ? 1 : 0) + "";                   
                }
                richTextBox1.AppendText(code);

                List<int> decoded = huffman.Decode(encoded);
                
                Console.WriteLine("Decoded: ");
                foreach (int symbol in decoded)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
                
                byte[] output = huffman.convertToByte(decoded);
                
                pictureBox1.Image = huffman.ToImage(decoded.ToArray(),w,h);*/

            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private void decodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = createImagePlane(compressor.EntropyDecoding((Bitmap)pictureBox1.Image, 100, 100));
            }
            else
            {
                MessageBox.Show("Open an Image First...");
            }
        }

        private Bitmap createImagePlane(BitArray bitArray)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            Bitmap imagePlane = new Bitmap(image.Width, image.Height);
            int width = image.Width;
            for (int pixel = 0; pixel < image.Width * image.Height; pixel++)
            {
                int h = pixel / width;
                if (bitArray[pixel])
                {
                    imagePlane.SetPixel(pixel % width, h, Color.White);
                }
                else
                {
                    imagePlane.SetPixel(pixel % width, h, Color.Black);
                }
            }
            return imagePlane;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button_bitplane_de_Click(object sender, EventArgs e)
        {
            List<Bitmap> bitplanes = new List<Bitmap>();
            for(int i=0; i < 8; i++)
            {
                bitplanes.Add(createImagePlane(array.ElementAt(i)));
            }
            pictureBox1.Image = compressor.deCompressBitPlanes(bitplanes);
        }
    }
}
