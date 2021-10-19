
namespace Practice.TH2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbApp = new System.Windows.Forms.Label();
            this.pbApp = new System.Windows.Forms.PictureBox();
            this.pbOrderHistory = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.totalOrderBadge = new Practice.TH2.CustomControl.Badge();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.totalOrderBadge);
            this.panel1.Controls.Add(this.lbApp);
            this.panel1.Controls.Add(this.pbApp);
            this.panel1.Controls.Add(this.pbOrderHistory);
            this.panel1.Controls.Add(this.pbCart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(1023, 54);
            this.panel1.TabIndex = 0;
            // 
            // lbApp
            // 
            this.lbApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApp.ForeColor = System.Drawing.Color.White;
            this.lbApp.Location = new System.Drawing.Point(75, 0);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(174, 54);
            this.lbApp.TabIndex = 5;
            this.lbApp.Text = "Mobile Shop";
            this.lbApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbApp.Click += new System.EventHandler(this.lbApp_Click);
            // 
            // pbApp
            // 
            this.pbApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbApp.Image = ((System.Drawing.Image)(resources.GetObject("pbApp.Image")));
            this.pbApp.Location = new System.Drawing.Point(20, 0);
            this.pbApp.Name = "pbApp";
            this.pbApp.Size = new System.Drawing.Size(55, 54);
            this.pbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbApp.TabIndex = 4;
            this.pbApp.TabStop = false;
            this.pbApp.Click += new System.EventHandler(this.pbApp_Click);
            // 
            // pbOrderHistory
            // 
            this.pbOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.pbOrderHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOrderHistory.Image = ((System.Drawing.Image)(resources.GetObject("pbOrderHistory.Image")));
            this.pbOrderHistory.Location = new System.Drawing.Point(877, 0);
            this.pbOrderHistory.Name = "pbOrderHistory";
            this.pbOrderHistory.Size = new System.Drawing.Size(60, 54);
            this.pbOrderHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOrderHistory.TabIndex = 3;
            this.pbOrderHistory.TabStop = false;
            this.pbOrderHistory.Click += new System.EventHandler(this.pbOrderHistory_Click);
            // 
            // pbCart
            // 
            this.pbCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(79)))));
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCart.Image = ((System.Drawing.Image)(resources.GetObject("pbCart.Image")));
            this.pbCart.Location = new System.Drawing.Point(943, 0);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(60, 54);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCart.TabIndex = 2;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnSearch);
            this.panel2.Controls.Add(this.btnSearchProduct);
            this.panel2.Location = new System.Drawing.Point(316, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 30);
            this.panel2.TabIndex = 1;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnSearch.Size = new System.Drawing.Size(331, 30);
            this.pnSearch.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(5, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(321, 20);
            this.tbSearch.TabIndex = 3;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSearchProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(339, 0);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(115, 30);
            this.btnSearchProduct.TabIndex = 3;
            this.btnSearchProduct.Text = "Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // pnForm
            // 
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 54);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1023, 676);
            this.pnForm.TabIndex = 1;
            // 
            // totalOrderBadge
            // 
            this.totalOrderBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalOrderBadge.Location = new System.Drawing.Point(978, 6);
            this.totalOrderBadge.Name = "totalOrderBadge";
            this.totalOrderBadge.Number = 0;
            this.totalOrderBadge.Size = new System.Drawing.Size(18, 19);
            this.totalOrderBadge.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 730);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pbOrderHistory;
        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.PictureBox pbApp;
        private CustomControl.Badge totalOrderBadge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearchProduct;
    }
}