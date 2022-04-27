namespace ImageProcessing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UploadBtn = new System.Windows.Forms.Button();
            this.PictureBoxX = new System.Windows.Forms.PictureBox();
            this.GamaBtn = new System.Windows.Forms.Button();
            this.NegBtn = new System.Windows.Forms.Button();
            this.bitPlain = new System.Windows.Forms.Button();
            this.histogBtn = new System.Windows.Forms.Button();
            this.Median = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thrBlueText = new System.Windows.Forms.TextBox();
            this.thrGreenText = new System.Windows.Forms.TextBox();
            this.thrRedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gamaYTextBox = new System.Windows.Forms.TextBox();
            this.gamaCTextBox = new System.Windows.Forms.TextBox();
            this.thrshBtn = new System.Windows.Forms.Button();
            this.xy1 = new System.Windows.Forms.TextBox();
            this.xy2 = new System.Windows.Forms.TextBox();
            this.xy3 = new System.Windows.Forms.TextBox();
            this.xy4 = new System.Windows.Forms.TextBox();
            this.xy5 = new System.Windows.Forms.TextBox();
            this.xy6 = new System.Windows.Forms.TextBox();
            this.xy7 = new System.Windows.Forms.TextBox();
            this.xy8 = new System.Windows.Forms.TextBox();
            this.xy9 = new System.Windows.Forms.TextBox();
            this.AverageBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LaplasianBtn = new System.Windows.Forms.Button();
            this.xyl9 = new System.Windows.Forms.TextBox();
            this.xyl8 = new System.Windows.Forms.TextBox();
            this.xyl7 = new System.Windows.Forms.TextBox();
            this.xyl6 = new System.Windows.Forms.TextBox();
            this.xyl5 = new System.Windows.Forms.TextBox();
            this.xyl4 = new System.Windows.Forms.TextBox();
            this.xyl3 = new System.Windows.Forms.TextBox();
            this.xyl2 = new System.Windows.Forms.TextBox();
            this.xyl1 = new System.Windows.Forms.TextBox();
            this.avg5Btn = new System.Windows.Forms.Button();
            this.avg7Btn = new System.Windows.Forms.Button();
            this.avg19Btn = new System.Windows.Forms.Button();
            this.Laplasian19xBtn = new System.Windows.Forms.Button();
            this.Laplasian7xBtn = new System.Windows.Forms.Button();
            this.Laplasian5xBtn = new System.Windows.Forms.Button();
            this.zapasPicBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gsThrBit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gsYText = new System.Windows.Forms.TextBox();
            this.gsCText = new System.Windows.Forms.TextBox();
            this.gsThreBtn = new System.Windows.Forms.Button();
            this.gsGamaBtn = new System.Windows.Forms.Button();
            this.gsNegBtn = new System.Windows.Forms.Button();
            this.gsZapaspicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zapasPicBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsZapaspicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UploadBtn.Location = new System.Drawing.Point(189, 418);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(104, 35);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload!";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // PictureBoxX
            // 
            this.PictureBoxX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxX.BackgroundImage")));
            this.PictureBoxX.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxX.Image")));
            this.PictureBoxX.Location = new System.Drawing.Point(21, 34);
            this.PictureBoxX.Name = "PictureBoxX";
            this.PictureBoxX.Size = new System.Drawing.Size(439, 399);
            this.PictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxX.TabIndex = 1;
            this.PictureBoxX.TabStop = false;
            // 
            // GamaBtn
            // 
            this.GamaBtn.Location = new System.Drawing.Point(15, 24);
            this.GamaBtn.Name = "GamaBtn";
            this.GamaBtn.Size = new System.Drawing.Size(98, 47);
            this.GamaBtn.TabIndex = 2;
            this.GamaBtn.Text = "Gama";
            this.GamaBtn.UseVisualStyleBackColor = true;
            this.GamaBtn.Click += new System.EventHandler(this.GamaBtn_Click);
            // 
            // NegBtn
            // 
            this.NegBtn.Location = new System.Drawing.Point(15, 77);
            this.NegBtn.Name = "NegBtn";
            this.NegBtn.Size = new System.Drawing.Size(98, 47);
            this.NegBtn.TabIndex = 3;
            this.NegBtn.Text = "Negative";
            this.NegBtn.UseVisualStyleBackColor = true;
            this.NegBtn.Click += new System.EventHandler(this.NegBtn_Click);
            // 
            // bitPlain
            // 
            this.bitPlain.Location = new System.Drawing.Point(922, 376);
            this.bitPlain.Name = "bitPlain";
            this.bitPlain.Size = new System.Drawing.Size(149, 30);
            this.bitPlain.TabIndex = 5;
            this.bitPlain.Text = "Bit Plain";
            this.bitPlain.UseVisualStyleBackColor = true;
            this.bitPlain.Click += new System.EventHandler(this.bitPlain_Click);
            // 
            // histogBtn
            // 
            this.histogBtn.Location = new System.Drawing.Point(754, 376);
            this.histogBtn.Name = "histogBtn";
            this.histogBtn.Size = new System.Drawing.Size(78, 30);
            this.histogBtn.TabIndex = 6;
            this.histogBtn.Text = "Histogram";
            this.histogBtn.UseVisualStyleBackColor = true;
            this.histogBtn.Click += new System.EventHandler(this.histogBtn_Click);
            // 
            // Median
            // 
            this.Median.Location = new System.Drawing.Point(838, 376);
            this.Median.Name = "Median";
            this.Median.Size = new System.Drawing.Size(65, 30);
            this.Median.TabIndex = 8;
            this.Median.Text = "Median";
            this.Median.UseVisualStyleBackColor = true;
            this.Median.Click += new System.EventHandler(this.Median_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.thrBlueText);
            this.groupBox1.Controls.Add(this.thrGreenText);
            this.groupBox1.Controls.Add(this.thrRedText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gamaYTextBox);
            this.groupBox1.Controls.Add(this.gamaCTextBox);
            this.groupBox1.Controls.Add(this.thrshBtn);
            this.groupBox1.Controls.Add(this.GamaBtn);
            this.groupBox1.Controls.Add(this.NegBtn);
            this.groupBox1.Location = new System.Drawing.Point(479, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "R";
            // 
            // thrBlueText
            // 
            this.thrBlueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrBlueText.Location = new System.Drawing.Point(209, 130);
            this.thrBlueText.Name = "thrBlueText";
            this.thrBlueText.Size = new System.Drawing.Size(39, 26);
            this.thrBlueText.TabIndex = 43;
            this.thrBlueText.Text = "127";
            // 
            // thrGreenText
            // 
            this.thrGreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrGreenText.Location = new System.Drawing.Point(164, 130);
            this.thrGreenText.Name = "thrGreenText";
            this.thrGreenText.Size = new System.Drawing.Size(39, 26);
            this.thrGreenText.TabIndex = 42;
            this.thrGreenText.Text = "127";
            // 
            // thrRedText
            // 
            this.thrRedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrRedText.Location = new System.Drawing.Point(119, 130);
            this.thrRedText.Name = "thrRedText";
            this.thrRedText.Size = new System.Drawing.Size(39, 26);
            this.thrRedText.TabIndex = 41;
            this.thrRedText.Text = "127";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "γ";
            // 
            // gamaYTextBox
            // 
            this.gamaYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamaYTextBox.Location = new System.Drawing.Point(119, 24);
            this.gamaYTextBox.Name = "gamaYTextBox";
            this.gamaYTextBox.Size = new System.Drawing.Size(52, 26);
            this.gamaYTextBox.TabIndex = 37;
            this.gamaYTextBox.Text = "0.7";
            // 
            // gamaCTextBox
            // 
            this.gamaCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamaCTextBox.Location = new System.Drawing.Point(177, 24);
            this.gamaCTextBox.Name = "gamaCTextBox";
            this.gamaCTextBox.Size = new System.Drawing.Size(48, 26);
            this.gamaCTextBox.TabIndex = 38;
            this.gamaCTextBox.Text = "1";
            // 
            // thrshBtn
            // 
            this.thrshBtn.Location = new System.Drawing.Point(15, 130);
            this.thrshBtn.Name = "thrshBtn";
            this.thrshBtn.Size = new System.Drawing.Size(98, 47);
            this.thrshBtn.TabIndex = 9;
            this.thrshBtn.Text = "Threshold";
            this.thrshBtn.UseVisualStyleBackColor = true;
            this.thrshBtn.Click += new System.EventHandler(this.thrshBtn_Click);
            // 
            // xy1
            // 
            this.xy1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy1.Location = new System.Drawing.Point(8, 18);
            this.xy1.Multiline = true;
            this.xy1.Name = "xy1";
            this.xy1.Size = new System.Drawing.Size(40, 40);
            this.xy1.TabIndex = 10;
            this.xy1.Text = "0";
            this.xy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy2
            // 
            this.xy2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy2.Location = new System.Drawing.Point(54, 18);
            this.xy2.Multiline = true;
            this.xy2.Name = "xy2";
            this.xy2.Size = new System.Drawing.Size(40, 40);
            this.xy2.TabIndex = 11;
            this.xy2.Text = "1";
            this.xy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy3
            // 
            this.xy3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy3.Location = new System.Drawing.Point(100, 18);
            this.xy3.Multiline = true;
            this.xy3.Name = "xy3";
            this.xy3.Size = new System.Drawing.Size(40, 40);
            this.xy3.TabIndex = 12;
            this.xy3.Text = "0";
            this.xy3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy4
            // 
            this.xy4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy4.Location = new System.Drawing.Point(8, 64);
            this.xy4.Multiline = true;
            this.xy4.Name = "xy4";
            this.xy4.Size = new System.Drawing.Size(40, 40);
            this.xy4.TabIndex = 13;
            this.xy4.Text = "1";
            this.xy4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy5
            // 
            this.xy5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy5.Location = new System.Drawing.Point(54, 64);
            this.xy5.Multiline = true;
            this.xy5.Name = "xy5";
            this.xy5.Size = new System.Drawing.Size(40, 40);
            this.xy5.TabIndex = 14;
            this.xy5.Text = "1";
            this.xy5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy6
            // 
            this.xy6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy6.Location = new System.Drawing.Point(100, 64);
            this.xy6.Multiline = true;
            this.xy6.Name = "xy6";
            this.xy6.Size = new System.Drawing.Size(40, 40);
            this.xy6.TabIndex = 15;
            this.xy6.Text = "1";
            this.xy6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy7
            // 
            this.xy7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy7.Location = new System.Drawing.Point(8, 110);
            this.xy7.Multiline = true;
            this.xy7.Name = "xy7";
            this.xy7.Size = new System.Drawing.Size(40, 40);
            this.xy7.TabIndex = 16;
            this.xy7.Text = "0";
            this.xy7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy8
            // 
            this.xy8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy8.Location = new System.Drawing.Point(54, 110);
            this.xy8.Multiline = true;
            this.xy8.Name = "xy8";
            this.xy8.Size = new System.Drawing.Size(40, 40);
            this.xy8.TabIndex = 17;
            this.xy8.Text = "1";
            this.xy8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xy9
            // 
            this.xy9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xy9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xy9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xy9.Location = new System.Drawing.Point(100, 110);
            this.xy9.Multiline = true;
            this.xy9.Name = "xy9";
            this.xy9.Size = new System.Drawing.Size(40, 40);
            this.xy9.TabIndex = 18;
            this.xy9.Text = "0";
            this.xy9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageBtn
            // 
            this.AverageBtn.Location = new System.Drawing.Point(8, 156);
            this.AverageBtn.Name = "AverageBtn";
            this.AverageBtn.Size = new System.Drawing.Size(132, 37);
            this.AverageBtn.TabIndex = 19;
            this.AverageBtn.Text = "Average";
            this.AverageBtn.UseVisualStyleBackColor = true;
            this.AverageBtn.Click += new System.EventHandler(this.AverageBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AverageBtn);
            this.groupBox2.Controls.Add(this.xy9);
            this.groupBox2.Controls.Add(this.xy8);
            this.groupBox2.Controls.Add(this.xy7);
            this.groupBox2.Controls.Add(this.xy6);
            this.groupBox2.Controls.Add(this.xy5);
            this.groupBox2.Controls.Add(this.xy4);
            this.groupBox2.Controls.Add(this.xy3);
            this.groupBox2.Controls.Add(this.xy2);
            this.groupBox2.Controls.Add(this.xy1);
            this.groupBox2.Location = new System.Drawing.Point(754, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 205);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LaplasianBtn);
            this.groupBox3.Controls.Add(this.xyl9);
            this.groupBox3.Controls.Add(this.xyl8);
            this.groupBox3.Controls.Add(this.xyl7);
            this.groupBox3.Controls.Add(this.xyl6);
            this.groupBox3.Controls.Add(this.xyl5);
            this.groupBox3.Controls.Add(this.xyl4);
            this.groupBox3.Controls.Add(this.xyl3);
            this.groupBox3.Controls.Add(this.xyl2);
            this.groupBox3.Controls.Add(this.xyl1);
            this.groupBox3.Location = new System.Drawing.Point(922, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 205);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // LaplasianBtn
            // 
            this.LaplasianBtn.Location = new System.Drawing.Point(8, 156);
            this.LaplasianBtn.Name = "LaplasianBtn";
            this.LaplasianBtn.Size = new System.Drawing.Size(132, 37);
            this.LaplasianBtn.TabIndex = 19;
            this.LaplasianBtn.Text = "Laplasian";
            this.LaplasianBtn.UseVisualStyleBackColor = true;
            this.LaplasianBtn.Click += new System.EventHandler(this.LaplasianBtn_Click);
            // 
            // xyl9
            // 
            this.xyl9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl9.Location = new System.Drawing.Point(100, 110);
            this.xyl9.Multiline = true;
            this.xyl9.Name = "xyl9";
            this.xyl9.Size = new System.Drawing.Size(40, 40);
            this.xyl9.TabIndex = 18;
            this.xyl9.Text = "0";
            this.xyl9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl8
            // 
            this.xyl8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl8.Location = new System.Drawing.Point(54, 110);
            this.xyl8.Multiline = true;
            this.xyl8.Name = "xyl8";
            this.xyl8.Size = new System.Drawing.Size(40, 40);
            this.xyl8.TabIndex = 17;
            this.xyl8.Text = "1";
            this.xyl8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl7
            // 
            this.xyl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl7.Location = new System.Drawing.Point(8, 110);
            this.xyl7.Multiline = true;
            this.xyl7.Name = "xyl7";
            this.xyl7.Size = new System.Drawing.Size(40, 40);
            this.xyl7.TabIndex = 16;
            this.xyl7.Text = "0";
            this.xyl7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl6
            // 
            this.xyl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl6.Location = new System.Drawing.Point(100, 64);
            this.xyl6.Multiline = true;
            this.xyl6.Name = "xyl6";
            this.xyl6.Size = new System.Drawing.Size(40, 40);
            this.xyl6.TabIndex = 15;
            this.xyl6.Text = "1";
            this.xyl6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl5
            // 
            this.xyl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl5.Location = new System.Drawing.Point(54, 64);
            this.xyl5.Multiline = true;
            this.xyl5.Name = "xyl5";
            this.xyl5.Size = new System.Drawing.Size(40, 40);
            this.xyl5.TabIndex = 14;
            this.xyl5.Text = "-4";
            this.xyl5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl4
            // 
            this.xyl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl4.Location = new System.Drawing.Point(8, 64);
            this.xyl4.Multiline = true;
            this.xyl4.Name = "xyl4";
            this.xyl4.Size = new System.Drawing.Size(40, 40);
            this.xyl4.TabIndex = 13;
            this.xyl4.Text = "1";
            this.xyl4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl3
            // 
            this.xyl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl3.Location = new System.Drawing.Point(100, 18);
            this.xyl3.Multiline = true;
            this.xyl3.Name = "xyl3";
            this.xyl3.Size = new System.Drawing.Size(40, 40);
            this.xyl3.TabIndex = 12;
            this.xyl3.Text = "0";
            this.xyl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl2
            // 
            this.xyl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl2.Location = new System.Drawing.Point(54, 18);
            this.xyl2.Multiline = true;
            this.xyl2.Name = "xyl2";
            this.xyl2.Size = new System.Drawing.Size(40, 40);
            this.xyl2.TabIndex = 11;
            this.xyl2.Text = "1";
            this.xyl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xyl1
            // 
            this.xyl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xyl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xyl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyl1.Location = new System.Drawing.Point(8, 18);
            this.xyl1.Multiline = true;
            this.xyl1.Name = "xyl1";
            this.xyl1.Size = new System.Drawing.Size(40, 40);
            this.xyl1.TabIndex = 10;
            this.xyl1.Text = "0";
            this.xyl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avg5Btn
            // 
            this.avg5Btn.Location = new System.Drawing.Point(754, 245);
            this.avg5Btn.Name = "avg5Btn";
            this.avg5Btn.Size = new System.Drawing.Size(149, 37);
            this.avg5Btn.TabIndex = 31;
            this.avg5Btn.Text = "Average | 5X5";
            this.avg5Btn.UseVisualStyleBackColor = true;
            this.avg5Btn.Click += new System.EventHandler(this.avg5Btn_Click);
            // 
            // avg7Btn
            // 
            this.avg7Btn.Location = new System.Drawing.Point(754, 288);
            this.avg7Btn.Name = "avg7Btn";
            this.avg7Btn.Size = new System.Drawing.Size(149, 37);
            this.avg7Btn.TabIndex = 32;
            this.avg7Btn.Text = "Average | 7X7";
            this.avg7Btn.UseVisualStyleBackColor = true;
            this.avg7Btn.Click += new System.EventHandler(this.avg7Btn_Click);
            // 
            // avg19Btn
            // 
            this.avg19Btn.Location = new System.Drawing.Point(754, 333);
            this.avg19Btn.Name = "avg19Btn";
            this.avg19Btn.Size = new System.Drawing.Size(149, 37);
            this.avg19Btn.TabIndex = 33;
            this.avg19Btn.Text = "Average | 19X19";
            this.avg19Btn.UseVisualStyleBackColor = true;
            this.avg19Btn.Click += new System.EventHandler(this.avg19Btn_Click);
            // 
            // Laplasian19xBtn
            // 
            this.Laplasian19xBtn.Location = new System.Drawing.Point(922, 333);
            this.Laplasian19xBtn.Name = "Laplasian19xBtn";
            this.Laplasian19xBtn.Size = new System.Drawing.Size(149, 37);
            this.Laplasian19xBtn.TabIndex = 36;
            this.Laplasian19xBtn.Text = "Laplasian | 19X19";
            this.Laplasian19xBtn.UseVisualStyleBackColor = true;
            this.Laplasian19xBtn.Click += new System.EventHandler(this.Laplasian19xBtn_Click);
            // 
            // Laplasian7xBtn
            // 
            this.Laplasian7xBtn.Location = new System.Drawing.Point(922, 288);
            this.Laplasian7xBtn.Name = "Laplasian7xBtn";
            this.Laplasian7xBtn.Size = new System.Drawing.Size(149, 37);
            this.Laplasian7xBtn.TabIndex = 35;
            this.Laplasian7xBtn.Text = "Laplasian | 7X7";
            this.Laplasian7xBtn.UseVisualStyleBackColor = true;
            this.Laplasian7xBtn.Click += new System.EventHandler(this.Laplasian7xBtn_Click);
            // 
            // Laplasian5xBtn
            // 
            this.Laplasian5xBtn.Location = new System.Drawing.Point(922, 245);
            this.Laplasian5xBtn.Name = "Laplasian5xBtn";
            this.Laplasian5xBtn.Size = new System.Drawing.Size(149, 37);
            this.Laplasian5xBtn.TabIndex = 34;
            this.Laplasian5xBtn.Text = "Laplasian | 5X5";
            this.Laplasian5xBtn.UseVisualStyleBackColor = true;
            this.Laplasian5xBtn.Click += new System.EventHandler(this.Laplasian5xBtn_Click);
            // 
            // zapasPicBox
            // 
            this.zapasPicBox.Image = ((System.Drawing.Image)(resources.GetObject("zapasPicBox.Image")));
            this.zapasPicBox.Location = new System.Drawing.Point(41, 418);
            this.zapasPicBox.Name = "zapasPicBox";
            this.zapasPicBox.Size = new System.Drawing.Size(33, 34);
            this.zapasPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zapasPicBox.TabIndex = 37;
            this.zapasPicBox.TabStop = false;
            this.zapasPicBox.Click += new System.EventHandler(this.zapasPicBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.gsThrBit);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.gsYText);
            this.groupBox4.Controls.Add(this.gsCText);
            this.groupBox4.Controls.Add(this.gsThreBtn);
            this.groupBox4.Controls.Add(this.gsGamaBtn);
            this.groupBox4.Controls.Add(this.gsNegBtn);
            this.groupBox4.Location = new System.Drawing.Point(479, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 199);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GreyScale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Bit";
            // 
            // gsThrBit
            // 
            this.gsThrBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsThrBit.Location = new System.Drawing.Point(119, 130);
            this.gsThrBit.Name = "gsThrBit";
            this.gsThrBit.Size = new System.Drawing.Size(39, 26);
            this.gsThrBit.TabIndex = 41;
            this.gsThrBit.Text = "127";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "γ";
            // 
            // gsYText
            // 
            this.gsYText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsYText.Location = new System.Drawing.Point(119, 24);
            this.gsYText.Name = "gsYText";
            this.gsYText.Size = new System.Drawing.Size(52, 26);
            this.gsYText.TabIndex = 37;
            this.gsYText.Text = "0.7";
            // 
            // gsCText
            // 
            this.gsCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsCText.Location = new System.Drawing.Point(177, 24);
            this.gsCText.Name = "gsCText";
            this.gsCText.Size = new System.Drawing.Size(48, 26);
            this.gsCText.TabIndex = 38;
            this.gsCText.Text = "1";
            // 
            // gsThreBtn
            // 
            this.gsThreBtn.Location = new System.Drawing.Point(15, 130);
            this.gsThreBtn.Name = "gsThreBtn";
            this.gsThreBtn.Size = new System.Drawing.Size(98, 47);
            this.gsThreBtn.TabIndex = 9;
            this.gsThreBtn.Text = "Threshold";
            this.gsThreBtn.UseVisualStyleBackColor = true;
            this.gsThreBtn.Click += new System.EventHandler(this.gsThreBtn_Click);
            // 
            // gsGamaBtn
            // 
            this.gsGamaBtn.Location = new System.Drawing.Point(15, 24);
            this.gsGamaBtn.Name = "gsGamaBtn";
            this.gsGamaBtn.Size = new System.Drawing.Size(98, 47);
            this.gsGamaBtn.TabIndex = 2;
            this.gsGamaBtn.Text = "Gama";
            this.gsGamaBtn.UseVisualStyleBackColor = true;
            this.gsGamaBtn.Click += new System.EventHandler(this.gsGamaBtn_Click);
            // 
            // gsNegBtn
            // 
            this.gsNegBtn.Location = new System.Drawing.Point(15, 77);
            this.gsNegBtn.Name = "gsNegBtn";
            this.gsNegBtn.Size = new System.Drawing.Size(98, 47);
            this.gsNegBtn.TabIndex = 3;
            this.gsNegBtn.Text = "Negative";
            this.gsNegBtn.UseVisualStyleBackColor = true;
            this.gsNegBtn.Click += new System.EventHandler(this.gsNegBtn_Click);
            // 
            // gsZapaspicbox
            // 
            this.gsZapaspicbox.Image = ((System.Drawing.Image)(resources.GetObject("gsZapaspicbox.Image")));
            this.gsZapaspicbox.Location = new System.Drawing.Point(407, 418);
            this.gsZapaspicbox.Name = "gsZapaspicbox";
            this.gsZapaspicbox.Size = new System.Drawing.Size(33, 34);
            this.gsZapaspicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gsZapaspicbox.TabIndex = 39;
            this.gsZapaspicbox.TabStop = false;
            this.gsZapaspicbox.Click += new System.EventHandler(this.gsZapaspicbox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1103, 478);
            this.Controls.Add(this.gsZapaspicbox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.zapasPicBox);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.Laplasian19xBtn);
            this.Controls.Add(this.Laplasian7xBtn);
            this.Controls.Add(this.Laplasian5xBtn);
            this.Controls.Add(this.avg19Btn);
            this.Controls.Add(this.avg7Btn);
            this.Controls.Add(this.avg5Btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Median);
            this.Controls.Add(this.PictureBoxX);
            this.Controls.Add(this.bitPlain);
            this.Controls.Add(this.histogBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zapasPicBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsZapaspicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.PictureBox PictureBoxX;
        private System.Windows.Forms.Button GamaBtn;
        private System.Windows.Forms.Button NegBtn;
        private System.Windows.Forms.Button bitPlain;
        private System.Windows.Forms.Button histogBtn;
        private System.Windows.Forms.Button Median;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox xy1;
        private System.Windows.Forms.TextBox xy2;
        private System.Windows.Forms.TextBox xy3;
        private System.Windows.Forms.TextBox xy4;
        private System.Windows.Forms.TextBox xy5;
        private System.Windows.Forms.TextBox xy6;
        private System.Windows.Forms.TextBox xy7;
        private System.Windows.Forms.TextBox xy8;
        private System.Windows.Forms.TextBox xy9;
        private System.Windows.Forms.Button AverageBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LaplasianBtn;
        private System.Windows.Forms.TextBox xyl9;
        private System.Windows.Forms.TextBox xyl8;
        private System.Windows.Forms.TextBox xyl7;
        private System.Windows.Forms.TextBox xyl6;
        private System.Windows.Forms.TextBox xyl5;
        private System.Windows.Forms.TextBox xyl4;
        private System.Windows.Forms.TextBox xyl3;
        private System.Windows.Forms.TextBox xyl2;
        private System.Windows.Forms.TextBox xyl1;
        private System.Windows.Forms.Button avg5Btn;
        private System.Windows.Forms.Button avg7Btn;
        private System.Windows.Forms.Button avg19Btn;
        private System.Windows.Forms.Button Laplasian19xBtn;
        private System.Windows.Forms.Button Laplasian7xBtn;
        private System.Windows.Forms.Button Laplasian5xBtn;
        private System.Windows.Forms.Button thrshBtn;
        private System.Windows.Forms.TextBox gamaYTextBox;
        private System.Windows.Forms.TextBox gamaCTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thrBlueText;
        private System.Windows.Forms.TextBox thrGreenText;
        private System.Windows.Forms.TextBox thrRedText;
        private System.Windows.Forms.PictureBox zapasPicBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gsThrBit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gsYText;
        private System.Windows.Forms.TextBox gsCText;
        private System.Windows.Forms.Button gsThreBtn;
        private System.Windows.Forms.Button gsGamaBtn;
        private System.Windows.Forms.Button gsNegBtn;
        private System.Windows.Forms.PictureBox gsZapaspicbox;
    }
}

