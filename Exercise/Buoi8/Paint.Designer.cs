namespace Exercise.Buoi8
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.lbY = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.TextBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioFillEllipse = new System.Windows.Forms.RadioButton();
            this.radioFillRec = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioRec = new System.Windows.Forms.RadioButton();
            this.radioString = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.pnPage = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.group2);
            this.groupBox1.Controls.Add(this.group1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(657, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(282, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(10, 323);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(262, 55);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.CadetBlue;
            this.group2.Controls.Add(this.lbY);
            this.group2.Controls.Add(this.lbX);
            this.group2.Controls.Add(this.btnLoadImage);
            this.group2.Controls.Add(this.label2);
            this.group2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.group2.Location = new System.Drawing.Point(10, 495);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(262, 123);
            this.group2.TabIndex = 1;
            this.group2.TabStop = false;
            this.group2.Text = "Image";
            // 
            // lbY
            // 
            this.lbY.Location = new System.Drawing.Point(183, 35);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(53, 22);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "100";
            // 
            // lbX
            // 
            this.lbX.Location = new System.Drawing.Point(102, 35);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(53, 22);
            this.lbX.TabIndex = 5;
            this.lbX.Text = "100";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.Green;
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(6, 68);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(246, 49);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Point X,Y:";
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.CadetBlue;
            this.group1.Controls.Add(this.numeric);
            this.group1.Controls.Add(this.label1);
            this.group1.Controls.Add(this.radioFillEllipse);
            this.group1.Controls.Add(this.radioFillRec);
            this.group1.Controls.Add(this.radioEllipse);
            this.group1.Controls.Add(this.radioRec);
            this.group1.Controls.Add(this.radioString);
            this.group1.Controls.Add(this.radioLine);
            this.group1.Controls.Add(this.btnPenColor);
            this.group1.Dock = System.Windows.Forms.DockStyle.Top;
            this.group1.Location = new System.Drawing.Point(10, 25);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(262, 287);
            this.group1.TabIndex = 0;
            this.group1.TabStop = false;
            this.group1.Text = "Draw";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(103, 246);
            this.numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(149, 22);
            this.numeric.TabIndex = 11;
            this.numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pen Width:";
            // 
            // radioFillEllipse
            // 
            this.radioFillEllipse.AutoSize = true;
            this.radioFillEllipse.Location = new System.Drawing.Point(149, 134);
            this.radioFillEllipse.Name = "radioFillEllipse";
            this.radioFillEllipse.Size = new System.Drawing.Size(91, 21);
            this.radioFillEllipse.TabIndex = 9;
            this.radioFillEllipse.Text = "Fill Ellipse";
            this.radioFillEllipse.UseVisualStyleBackColor = true;
            // 
            // radioFillRec
            // 
            this.radioFillRec.AutoSize = true;
            this.radioFillRec.Location = new System.Drawing.Point(21, 134);
            this.radioFillRec.Name = "radioFillRec";
            this.radioFillRec.Size = new System.Drawing.Size(114, 21);
            this.radioFillRec.TabIndex = 8;
            this.radioFillRec.Text = "Fill Rectangle";
            this.radioFillRec.UseVisualStyleBackColor = true;
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Location = new System.Drawing.Point(149, 82);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(70, 21);
            this.radioEllipse.TabIndex = 7;
            this.radioEllipse.Text = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // radioRec
            // 
            this.radioRec.AutoSize = true;
            this.radioRec.Location = new System.Drawing.Point(21, 82);
            this.radioRec.Name = "radioRec";
            this.radioRec.Size = new System.Drawing.Size(93, 21);
            this.radioRec.TabIndex = 6;
            this.radioRec.Text = "Rectangle";
            this.radioRec.UseVisualStyleBackColor = true;
            // 
            // radioString
            // 
            this.radioString.AutoSize = true;
            this.radioString.Location = new System.Drawing.Point(149, 34);
            this.radioString.Name = "radioString";
            this.radioString.Size = new System.Drawing.Size(66, 21);
            this.radioString.TabIndex = 5;
            this.radioString.Text = "String";
            this.radioString.UseVisualStyleBackColor = true;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Checked = true;
            this.radioLine.Location = new System.Drawing.Point(21, 34);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(56, 21);
            this.radioLine.TabIndex = 4;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.Black;
            this.btnPenColor.FlatAppearance.BorderSize = 0;
            this.btnPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenColor.ForeColor = System.Drawing.Color.Transparent;
            this.btnPenColor.Location = new System.Drawing.Point(20, 182);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(232, 42);
            this.btnPenColor.TabIndex = 3;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPencolor_Click);
            // 
            // pnPage
            // 
            this.pnPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(0, 0);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(657, 628);
            this.pnPage.TabIndex = 1;
            this.pnPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnPage_MouseDown);
            this.pnPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnPage_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 628);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.groupBox1.ResumeLayout(false);
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.TextBox lbY;
        private System.Windows.Forms.TextBox lbX;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioFillEllipse;
        private System.Windows.Forms.RadioButton radioFillRec;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.RadioButton radioRec;
        private System.Windows.Forms.RadioButton radioString;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Panel pnPage;
    }
}