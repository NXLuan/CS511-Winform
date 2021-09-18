
namespace Practice.TH1.UserControlCustom
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_ItemPrice = new System.Windows.Forms.Label();
            this.pb_delete = new System.Windows.Forms.PictureBox();
            this.lb_ItemText = new System.Windows.Forms.Label();
            this.pb_ItemImage = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_ItemPrice);
            this.panel2.Controls.Add(this.pb_delete);
            this.panel2.Controls.Add(this.lb_ItemText);
            this.panel2.Controls.Add(this.pb_ItemImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(320, 62);
            this.panel2.TabIndex = 1;
            // 
            // lb_ItemPrice
            // 
            this.lb_ItemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ItemPrice.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(20)))));
            this.lb_ItemPrice.Location = new System.Drawing.Point(154, 10);
            this.lb_ItemPrice.Name = "lb_ItemPrice";
            this.lb_ItemPrice.Size = new System.Drawing.Size(132, 42);
            this.lb_ItemPrice.TabIndex = 2;
            this.lb_ItemPrice.Text = "label2";
            this.lb_ItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_delete
            // 
            this.pb_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_delete.Image = ((System.Drawing.Image)(resources.GetObject("pb_delete.Image")));
            this.pb_delete.Location = new System.Drawing.Point(286, 10);
            this.pb_delete.Name = "pb_delete";
            this.pb_delete.Size = new System.Drawing.Size(24, 42);
            this.pb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_delete.TabIndex = 3;
            this.pb_delete.TabStop = false;
            this.pb_delete.Click += new System.EventHandler(this.pb_delete_Click);
            // 
            // lb_ItemText
            // 
            this.lb_ItemText.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_ItemText.Location = new System.Drawing.Point(60, 10);
            this.lb_ItemText.Name = "lb_ItemText";
            this.lb_ItemText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lb_ItemText.Size = new System.Drawing.Size(94, 42);
            this.lb_ItemText.TabIndex = 1;
            this.lb_ItemText.Text = "label1";
            this.lb_ItemText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_ItemImage
            // 
            this.pb_ItemImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_ItemImage.Location = new System.Drawing.Point(10, 10);
            this.pb_ItemImage.Name = "pb_ItemImage";
            this.pb_ItemImage.Size = new System.Drawing.Size(50, 42);
            this.pb_ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ItemImage.TabIndex = 0;
            this.pb_ItemImage.TabStop = false;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(320, 63);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_ItemImage;
        private System.Windows.Forms.Label lb_ItemPrice;
        private System.Windows.Forms.Label lb_ItemText;
        private System.Windows.Forms.PictureBox pb_delete;
    }
}
