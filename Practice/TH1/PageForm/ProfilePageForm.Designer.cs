
namespace Practice.TH1.PageForm
{
    partial class ProfilePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.input_HoTen = new Practice.TH1.UserControlCustom.InputCustom();
            this.input_SDT = new Practice.TH1.UserControlCustom.InputCustom();
            this.input_DiaChi = new Practice.TH1.UserControlCustom.InputCustom();
            this.pb_ChangeImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChangeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 557);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(133)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pb_ChangeImage);
            this.panel2.Controls.Add(this.pb_Avatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 248);
            this.panel2.TabIndex = 1;
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_Avatar.BackColor = System.Drawing.Color.Black;
            this.pb_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Avatar.Image")));
            this.pb_Avatar.Location = new System.Drawing.Point(125, 47);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(145, 154);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 0;
            this.pb_Avatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.input_DiaChi);
            this.panel3.Controls.Add(this.input_SDT);
            this.panel3.Controls.Add(this.input_HoTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.panel3.Size = new System.Drawing.Size(397, 309);
            this.panel3.TabIndex = 2;
            // 
            // input_HoTen
            // 
            this.input_HoTen.BackColor = System.Drawing.Color.White;
            this.input_HoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_HoTen.Location = new System.Drawing.Point(50, 30);
            this.input_HoTen.Name = "input_HoTen";
            this.input_HoTen.Size = new System.Drawing.Size(297, 56);
            this.input_HoTen.TabIndex = 0;
            this.input_HoTen.Title = "Họ và tên ";
            // 
            // input_SDT
            // 
            this.input_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_SDT.BackColor = System.Drawing.Color.White;
            this.input_SDT.Location = new System.Drawing.Point(50, 115);
            this.input_SDT.Name = "input_SDT";
            this.input_SDT.Size = new System.Drawing.Size(303, 56);
            this.input_SDT.TabIndex = 1;
            this.input_SDT.Title = "Số điện thoại";
            // 
            // input_DiaChi
            // 
            this.input_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_DiaChi.BackColor = System.Drawing.Color.White;
            this.input_DiaChi.Location = new System.Drawing.Point(50, 199);
            this.input_DiaChi.Name = "input_DiaChi";
            this.input_DiaChi.Size = new System.Drawing.Size(303, 56);
            this.input_DiaChi.TabIndex = 2;
            this.input_DiaChi.Title = "Địa chỉ";
            // 
            // pb_ChangeImage
            // 
            this.pb_ChangeImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_ChangeImage.BackColor = System.Drawing.Color.Black;
            this.pb_ChangeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_ChangeImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_ChangeImage.Image")));
            this.pb_ChangeImage.Location = new System.Drawing.Point(231, 171);
            this.pb_ChangeImage.Name = "pb_ChangeImage";
            this.pb_ChangeImage.Size = new System.Drawing.Size(39, 30);
            this.pb_ChangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ChangeImage.TabIndex = 1;
            this.pb_ChangeImage.TabStop = false;
            this.pb_ChangeImage.Click += new System.EventHandler(this.pb_ChangeImage_Click);
            // 
            // ProfilePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(437, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePageForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ProfilePageForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChangeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private UserControlCustom.InputCustom input_HoTen;
        private UserControlCustom.InputCustom input_SDT;
        private UserControlCustom.InputCustom input_DiaChi;
        private System.Windows.Forms.PictureBox pb_ChangeImage;
    }
}