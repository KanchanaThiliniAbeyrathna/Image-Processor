namespace ImageProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveACopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinearInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.upSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestNeibourMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.maskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runLengthCodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entropyCodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrayScalebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlurVal = new System.Windows.Forms.Label();
            this.EmbossButton = new System.Windows.Forms.Button();
            this.ContrastVal = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.InvertButton = new System.Windows.Forms.Button();
            this.BrightnessVal = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.BlurTrackBar = new System.Windows.Forms.TrackBar();
            this.Blurbutton = new System.Windows.Forms.Button();
            this.Undobutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CropCancelButton = new System.Windows.Forms.Button();
            this.CropSaveButton = new System.Windows.Forms.Button();
            this.cropStartButton = new System.Windows.Forms.Button();
            this.RotateClockwisebutton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.rotateAntiClockwiseButton = new System.Windows.Forms.Button();
            this.FlipVerticalButton = new System.Windows.Forms.Button();
            this.histogramPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelPlaneNo = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSd = new System.Windows.Forms.Label();
            this.labelMean = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_bitplane_de = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.compressionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveACopyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveACopyToolStripMenuItem
            // 
            this.saveACopyToolStripMenuItem.Name = "saveACopyToolStripMenuItem";
            this.saveACopyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveACopyToolStripMenuItem.Text = "Save a Copy";
            this.saveACopyToolStripMenuItem.Click += new System.EventHandler(this.saveACopyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reSampleToolStripMenuItem,
            this.upSampleToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.editToolStripMenuItem.Text = "Re-Sample";
            // 
            // reSampleToolStripMenuItem
            // 
            this.reSampleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilinearInterpolationToolStripMenuItem});
            this.reSampleToolStripMenuItem.Name = "reSampleToolStripMenuItem";
            this.reSampleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.reSampleToolStripMenuItem.Text = "Down-Sample";
            // 
            // bilinearInterpolationToolStripMenuItem
            // 
            this.bilinearInterpolationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.bilinearInterpolationToolStripMenuItem.Name = "bilinearInterpolationToolStripMenuItem";
            this.bilinearInterpolationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.bilinearInterpolationToolStripMenuItem.Text = "Bi-linear Interpolation";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "1/4 size";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "1/16 size";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // upSampleToolStripMenuItem
            // 
            this.upSampleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nearestNeibourMethodToolStripMenuItem});
            this.upSampleToolStripMenuItem.Name = "upSampleToolStripMenuItem";
            this.upSampleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.upSampleToolStripMenuItem.Text = "Up-Sample";
            // 
            // nearestNeibourMethodToolStripMenuItem
            // 
            this.nearestNeibourMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.nearestNeibourMethodToolStripMenuItem.Name = "nearestNeibourMethodToolStripMenuItem";
            this.nearestNeibourMethodToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.nearestNeibourMethodToolStripMenuItem.Text = "Nearest Neibour Method";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem5.Text = "*4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem6.Text = "*16";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanFilterToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // meanFilterToolStripMenuItem
            // 
            this.meanFilterToolStripMenuItem.Name = "meanFilterToolStripMenuItem";
            this.meanFilterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.meanFilterToolStripMenuItem.Text = "Median Filter";
            this.meanFilterToolStripMenuItem.Click += new System.EventHandler(this.meanFilterToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.maskToolStripMenuItem,
            this.maskToolStripMenuItem1});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem4.Text = "3*3 mask";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // maskToolStripMenuItem
            // 
            this.maskToolStripMenuItem.Name = "maskToolStripMenuItem";
            this.maskToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.maskToolStripMenuItem.Text = "5*5 mask";
            this.maskToolStripMenuItem.Click += new System.EventHandler(this.maskToolStripMenuItem_Click);
            // 
            // maskToolStripMenuItem1
            // 
            this.maskToolStripMenuItem1.Name = "maskToolStripMenuItem1";
            this.maskToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.maskToolStripMenuItem1.Text = "7*7 mask";
            this.maskToolStripMenuItem1.Click += new System.EventHandler(this.maskToolStripMenuItem1_Click);
            // 
            // compressionToolStripMenuItem
            // 
            this.compressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runLengthCodingToolStripMenuItem,
            this.entropyCodingToolStripMenuItem});
            this.compressionToolStripMenuItem.Name = "compressionToolStripMenuItem";
            this.compressionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.compressionToolStripMenuItem.Text = "Compression";
            // 
            // runLengthCodingToolStripMenuItem
            // 
            this.runLengthCodingToolStripMenuItem.Name = "runLengthCodingToolStripMenuItem";
            this.runLengthCodingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.runLengthCodingToolStripMenuItem.Text = "Run Length Coding";
            this.runLengthCodingToolStripMenuItem.Click += new System.EventHandler(this.runLengthCodingToolStripMenuItem_Click);
            // 
            // entropyCodingToolStripMenuItem
            // 
            this.entropyCodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodingToolStripMenuItem});
            this.entropyCodingToolStripMenuItem.Name = "entropyCodingToolStripMenuItem";
            this.entropyCodingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.entropyCodingToolStripMenuItem.Text = "Entropy Coding";
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encodingToolStripMenuItem.Text = "Encoding";
            this.encodingToolStripMenuItem.Click += new System.EventHandler(this.encodingToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pictureBox1_LoadProgressChanged);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(142, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 2;
            // 
            // GrayScalebutton
            // 
            this.GrayScalebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrayScalebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrayScalebutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayScalebutton.Location = new System.Drawing.Point(9, 99);
            this.GrayScalebutton.Name = "GrayScalebutton";
            this.GrayScalebutton.Size = new System.Drawing.Size(68, 46);
            this.GrayScalebutton.TabIndex = 4;
            this.GrayScalebutton.Text = "Gray Scale";
            this.GrayScalebutton.UseVisualStyleBackColor = false;
            this.GrayScalebutton.Click += new System.EventHandler(this.GrayScalebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueButton);
            this.groupBox1.Controls.Add(this.RedButton);
            this.groupBox1.Controls.Add(this.GreenButton);
            this.groupBox1.Controls.Add(this.BlurVal);
            this.groupBox1.Controls.Add(this.EmbossButton);
            this.groupBox1.Controls.Add(this.ContrastVal);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.InvertButton);
            this.groupBox1.Controls.Add(this.BrightnessVal);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BlurTrackBar);
            this.groupBox1.Controls.Add(this.Blurbutton);
            this.groupBox1.Controls.Add(this.Undobutton);
            this.groupBox1.Controls.Add(this.Resetbutton);
            this.groupBox1.Controls.Add(this.GrayScalebutton);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(610, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 450);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Operations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.Location = new System.Drawing.Point(189, 34);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(68, 46);
            this.blueButton.TabIndex = 21;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.Location = new System.Drawing.Point(9, 34);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(68, 46);
            this.RedButton.TabIndex = 20;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GreenButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.Location = new System.Drawing.Point(99, 34);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(68, 46);
            this.GreenButton.TabIndex = 19;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // BlurVal
            // 
            this.BlurVal.AutoSize = true;
            this.BlurVal.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlurVal.Location = new System.Drawing.Point(238, 264);
            this.BlurVal.Name = "BlurVal";
            this.BlurVal.Size = new System.Drawing.Size(19, 21);
            this.BlurVal.TabIndex = 18;
            this.BlurVal.Text = "0";
            // 
            // EmbossButton
            // 
            this.EmbossButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmbossButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbossButton.Location = new System.Drawing.Point(189, 100);
            this.EmbossButton.Name = "EmbossButton";
            this.EmbossButton.Size = new System.Drawing.Size(68, 46);
            this.EmbossButton.TabIndex = 16;
            this.EmbossButton.Text = "Emboss";
            this.EmbossButton.UseVisualStyleBackColor = false;
            this.EmbossButton.Click += new System.EventHandler(this.EmbossButton_Click);
            // 
            // ContrastVal
            // 
            this.ContrastVal.AutoSize = true;
            this.ContrastVal.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrastVal.Location = new System.Drawing.Point(238, 317);
            this.ContrastVal.Name = "ContrastVal";
            this.ContrastVal.Size = new System.Drawing.Size(19, 21);
            this.ContrastVal.TabIndex = 15;
            this.ContrastVal.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Location = new System.Drawing.Point(90, 317);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(159, 45);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 14;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contrast";
            // 
            // InvertButton
            // 
            this.InvertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InvertButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertButton.Location = new System.Drawing.Point(99, 100);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(68, 46);
            this.InvertButton.TabIndex = 12;
            this.InvertButton.Text = "Invert";
            this.InvertButton.UseVisualStyleBackColor = false;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // BrightnessVal
            // 
            this.BrightnessVal.AutoSize = true;
            this.BrightnessVal.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightnessVal.Location = new System.Drawing.Point(238, 365);
            this.BrightnessVal.Name = "BrightnessVal";
            this.BrightnessVal.Size = new System.Drawing.Size(19, 21);
            this.BrightnessVal.TabIndex = 11;
            this.BrightnessVal.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(90, 365);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(159, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brightness";
            // 
            // BlurTrackBar
            // 
            this.BlurTrackBar.Location = new System.Drawing.Point(90, 266);
            this.BlurTrackBar.Name = "BlurTrackBar";
            this.BlurTrackBar.Size = new System.Drawing.Size(159, 45);
            this.BlurTrackBar.TabIndex = 8;
            this.BlurTrackBar.Scroll += new System.EventHandler(this.UpdateBlurTrack);
            // 
            // Blurbutton
            // 
            this.Blurbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Blurbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blurbutton.Location = new System.Drawing.Point(6, 253);
            this.Blurbutton.Name = "Blurbutton";
            this.Blurbutton.Size = new System.Drawing.Size(68, 46);
            this.Blurbutton.TabIndex = 7;
            this.Blurbutton.Text = "Blur";
            this.Blurbutton.UseVisualStyleBackColor = false;
            this.Blurbutton.Click += new System.EventHandler(this.Blurbutton_Click);
            // 
            // Undobutton
            // 
            this.Undobutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undobutton.Location = new System.Drawing.Point(6, 416);
            this.Undobutton.Name = "Undobutton";
            this.Undobutton.Size = new System.Drawing.Size(114, 28);
            this.Undobutton.TabIndex = 6;
            this.Undobutton.Text = "Undo";
            this.Undobutton.UseVisualStyleBackColor = true;
            this.Undobutton.Click += new System.EventHandler(this.Undobutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.MediumBlue;
            this.Resetbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resetbutton.Location = new System.Drawing.Point(126, 416);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(123, 28);
            this.Resetbutton.TabIndex = 5;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CropCancelButton);
            this.groupBox2.Controls.Add(this.CropSaveButton);
            this.groupBox2.Controls.Add(this.cropStartButton);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crop";
            // 
            // CropCancelButton
            // 
            this.CropCancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropCancelButton.Location = new System.Drawing.Point(27, 65);
            this.CropCancelButton.Name = "CropCancelButton";
            this.CropCancelButton.Size = new System.Drawing.Size(65, 32);
            this.CropCancelButton.TabIndex = 2;
            this.CropCancelButton.Text = "Cancel";
            this.CropCancelButton.UseVisualStyleBackColor = true;
            this.CropCancelButton.Visible = false;
            this.CropCancelButton.Click += new System.EventHandler(this.CropCancelButton_Click);
            // 
            // CropSaveButton
            // 
            this.CropSaveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropSaveButton.ForeColor = System.Drawing.Color.Black;
            this.CropSaveButton.Location = new System.Drawing.Point(27, 26);
            this.CropSaveButton.Name = "CropSaveButton";
            this.CropSaveButton.Size = new System.Drawing.Size(65, 32);
            this.CropSaveButton.TabIndex = 1;
            this.CropSaveButton.Text = "Save";
            this.CropSaveButton.UseVisualStyleBackColor = true;
            this.CropSaveButton.Visible = false;
            this.CropSaveButton.Click += new System.EventHandler(this.CropSaveButton_Click);
            // 
            // cropStartButton
            // 
            this.cropStartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropStartButton.Location = new System.Drawing.Point(27, 27);
            this.cropStartButton.Name = "cropStartButton";
            this.cropStartButton.Size = new System.Drawing.Size(65, 32);
            this.cropStartButton.TabIndex = 0;
            this.cropStartButton.Text = "Start";
            this.cropStartButton.UseVisualStyleBackColor = true;
            this.cropStartButton.Click += new System.EventHandler(this.cropStartButton_Click);
            // 
            // RotateClockwisebutton
            // 
            this.RotateClockwisebutton.Image = ((System.Drawing.Image)(resources.GetObject("RotateClockwisebutton.Image")));
            this.RotateClockwisebutton.Location = new System.Drawing.Point(330, 500);
            this.RotateClockwisebutton.Name = "RotateClockwisebutton";
            this.RotateClockwisebutton.Size = new System.Drawing.Size(35, 35);
            this.RotateClockwisebutton.TabIndex = 6;
            this.RotateClockwisebutton.UseVisualStyleBackColor = true;
            this.RotateClockwisebutton.Click += new System.EventHandler(this.RotateClockwisebutton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Image = ((System.Drawing.Image)(resources.GetObject("FlipButton.Image")));
            this.FlipButton.Location = new System.Drawing.Point(380, 500);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(35, 35);
            this.FlipButton.TabIndex = 7;
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // rotateAntiClockwiseButton
            // 
            this.rotateAntiClockwiseButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateAntiClockwiseButton.Image")));
            this.rotateAntiClockwiseButton.Location = new System.Drawing.Point(280, 500);
            this.rotateAntiClockwiseButton.Name = "rotateAntiClockwiseButton";
            this.rotateAntiClockwiseButton.Size = new System.Drawing.Size(35, 35);
            this.rotateAntiClockwiseButton.TabIndex = 8;
            this.rotateAntiClockwiseButton.UseVisualStyleBackColor = false;
            this.rotateAntiClockwiseButton.Click += new System.EventHandler(this.rotateAntiClockwiseButton_Click);
            // 
            // FlipVerticalButton
            // 
            this.FlipVerticalButton.AutoSize = true;
            this.FlipVerticalButton.BackColor = System.Drawing.SystemColors.Control;
            this.FlipVerticalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FlipVerticalButton.Image = ((System.Drawing.Image)(resources.GetObject("FlipVerticalButton.Image")));
            this.FlipVerticalButton.Location = new System.Drawing.Point(430, 500);
            this.FlipVerticalButton.Name = "FlipVerticalButton";
            this.FlipVerticalButton.Size = new System.Drawing.Size(35, 35);
            this.FlipVerticalButton.TabIndex = 9;
            this.FlipVerticalButton.UseVisualStyleBackColor = false;
            this.FlipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButton_Click);
            // 
            // histogramPanel
            // 
            this.histogramPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramPanel.Location = new System.Drawing.Point(11, 34);
            this.histogramPanel.Name = "histogramPanel";
            this.histogramPanel.Size = new System.Drawing.Size(376, 195);
            this.histogramPanel.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Font = new System.Drawing.Font("Miramonte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(274, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Show Histogram";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_bitplane_de);
            this.groupBox3.Controls.Add(this.labelPlaneNo);
            this.groupBox3.Controls.Add(this.Right);
            this.groupBox3.Controls.Add(this.Left);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 128);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Switch Planes";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelPlaneNo
            // 
            this.labelPlaneNo.AutoSize = true;
            this.labelPlaneNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaneNo.Location = new System.Drawing.Point(42, 49);
            this.labelPlaneNo.Name = "labelPlaneNo";
            this.labelPlaneNo.Size = new System.Drawing.Size(17, 19);
            this.labelPlaneNo.TabIndex = 2;
            this.labelPlaneNo.Text = "0";
            this.labelPlaneNo.Click += new System.EventHandler(this.label3_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Blue;
            this.Right.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Right.Location = new System.Drawing.Point(80, 38);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(30, 30);
            this.Right.TabIndex = 1;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Blue;
            this.Left.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Left.Location = new System.Drawing.Point(6, 38);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(30, 30);
            this.Left.TabIndex = 0;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.labelSd);
            this.groupBox4.Controls.Add(this.labelMean);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(898, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 160);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Font = new System.Drawing.Font("Miramonte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Show Statistics";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSd
            // 
            this.labelSd.AutoSize = true;
            this.labelSd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSd.Location = new System.Drawing.Point(178, 104);
            this.labelSd.Name = "labelSd";
            this.labelSd.Size = new System.Drawing.Size(0, 19);
            this.labelSd.TabIndex = 17;
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMean.Location = new System.Drawing.Point(178, 61);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(0, 19);
            this.labelMean.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Standard diviation  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mean                      :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.histogramPanel);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(898, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 235);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histogram";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 541);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1283, 121);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Encoded Results :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1260, 87);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_bitplane_de
            // 
            this.button_bitplane_de.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bitplane_de.ForeColor = System.Drawing.Color.Black;
            this.button_bitplane_de.Location = new System.Drawing.Point(6, 90);
            this.button_bitplane_de.Name = "button_bitplane_de";
            this.button_bitplane_de.Size = new System.Drawing.Size(104, 32);
            this.button_bitplane_de.TabIndex = 3;
            this.button_bitplane_de.Text = "de-compress";
            this.button_bitplane_de.UseVisualStyleBackColor = true;
            this.button_bitplane_de.Click += new System.EventHandler(this.button_bitplane_de_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 674);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FlipVerticalButton);
            this.Controls.Add(this.rotateAntiClockwiseButton);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.RotateClockwisebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoMT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveACopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GrayScalebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Blurbutton;
        private System.Windows.Forms.Button Undobutton;
        private System.Windows.Forms.TrackBar BlurTrackBar;
        private System.Windows.Forms.Label BrightnessVal;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Label ContrastVal;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmbossButton;
        private System.Windows.Forms.Button RotateClockwisebutton;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Button rotateAntiClockwiseButton;
        private System.Windows.Forms.Button FlipVerticalButton;
        private System.Windows.Forms.Label BlurVal;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CropSaveButton;
        private System.Windows.Forms.Button cropStartButton;
        private System.Windows.Forms.Button CropCancelButton;
        private System.Windows.Forms.Panel histogramPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem reSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilinearInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem upSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearestNeibourMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem maskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runLengthCodingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Label labelPlaneNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelSd;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem entropyCodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_bitplane_de;
    }
}

