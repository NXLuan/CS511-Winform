
namespace Practice.TH2.CustomControl
{
    partial class ProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pbAvatarProduct = new System.Windows.Forms.PictureBox();
            this.pbAddToCart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            this.lbProductName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(10, 201);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lbProductName.Size = new System.Drawing.Size(240, 39);
            this.lbProductName.TabIndex = 4;
            this.lbProductName.Text = "Tên sản phẩm";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lbPrice.Location = new System.Drawing.Point(10, 240);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(240, 35);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "10.000 đ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAvatarProduct
            // 
            this.pbAvatarProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAvatarProduct.Location = new System.Drawing.Point(10, 10);
            this.pbAvatarProduct.Name = "pbAvatarProduct";
            this.pbAvatarProduct.Size = new System.Drawing.Size(240, 191);
            this.pbAvatarProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatarProduct.TabIndex = 5;
            this.pbAvatarProduct.TabStop = false;
            // 
            // pbAddToCart
            // 
            this.pbAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.pbAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("pbAddToCart.Image")));
            this.pbAddToCart.Location = new System.Drawing.Point(218, 252);
            this.pbAddToCart.Name = "pbAddToCart";
            this.pbAddToCart.Size = new System.Drawing.Size(40, 32);
            this.pbAddToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAddToCart.TabIndex = 6;
            this.pbAddToCart.TabStop = false;
            this.pbAddToCart.Click += new System.EventHandler(this.pbAddToCart_Click);
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbAddToCart);
            this.Controls.Add(this.pbAvatarProduct);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbPrice);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(260, 285);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddToCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pbAvatarProduct;
        private System.Windows.Forms.PictureBox pbAddToCart;
    }
}
