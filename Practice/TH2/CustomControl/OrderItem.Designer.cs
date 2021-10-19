
namespace Practice.TH2.CustomControl
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
            this.pbAvatarProduct = new System.Windows.Forms.PictureBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.lbDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvatarProduct
            // 
            this.pbAvatarProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAvatarProduct.Location = new System.Drawing.Point(10, 10);
            this.pbAvatarProduct.Name = "pbAvatarProduct";
            this.pbAvatarProduct.Size = new System.Drawing.Size(68, 72);
            this.pbAvatarProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatarProduct.TabIndex = 0;
            this.pbAvatarProduct.TabStop = false;
            // 
            // lbProductName
            // 
            this.lbProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(78, 10);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbProductName.Size = new System.Drawing.Size(296, 17);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lbPrice.Location = new System.Drawing.Point(0, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.lbPrice.Size = new System.Drawing.Size(197, 33);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "10.000 đ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnAdd.Location = new System.Drawing.Point(263, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbQuantity.Location = new System.Drawing.Point(230, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(33, 33);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "0";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.btnDecrease);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(78, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 33);
            this.panel1.TabIndex = 6;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.White;
            this.btnDecrease.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDecrease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnDecrease.Location = new System.Drawing.Point(197, 0);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(33, 33);
            this.btnDecrease.TabIndex = 6;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDelete.Location = new System.Drawing.Point(78, 62);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lbDelete.Size = new System.Drawing.Size(44, 20);
            this.lbDelete.TabIndex = 7;
            this.lbDelete.Text = "Xoá";
            this.lbDelete.Click += new System.EventHandler(this.lbDelete_Click);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.pbAvatarProduct);
            this.Name = "OrderItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(384, 92);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatarProduct;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Label lbDelete;
    }
}
