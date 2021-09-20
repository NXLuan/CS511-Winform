
namespace Practice.TH1.PageForm
{
    partial class CartPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPageForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_Cart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_Detail = new System.Windows.Forms.Panel();
            this.lb_TotalPrice = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pn_Cart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.pn_Cart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(437, 597);
            this.panel2.TabIndex = 1;
            // 
            // pn_Cart
            // 
            this.pn_Cart.BackColor = System.Drawing.Color.White;
            this.pn_Cart.Controls.Add(this.pn_Detail);
            this.pn_Cart.Controls.Add(this.panel1);
            this.pn_Cart.Controls.Add(this.label1);
            this.pn_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Cart.Location = new System.Drawing.Point(20, 20);
            this.pn_Cart.Name = "pn_Cart";
            this.pn_Cart.Size = new System.Drawing.Size(397, 557);
            this.pn_Cart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(133)))), ((int)(((byte)(51)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(397, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết giỏ hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_TotalPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 59);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(110, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pn_Detail
            // 
            this.pn_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Detail.Location = new System.Drawing.Point(0, 36);
            this.pn_Detail.Name = "pn_Detail";
            this.pn_Detail.Size = new System.Drawing.Size(397, 462);
            this.pn_Detail.TabIndex = 3;
            // 
            // lb_TotalPrice
            // 
            this.lb_TotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TotalPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lb_TotalPrice.Location = new System.Drawing.Point(110, 0);
            this.lb_TotalPrice.Name = "lb_TotalPrice";
            this.lb_TotalPrice.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lb_TotalPrice.Size = new System.Drawing.Size(287, 59);
            this.lb_TotalPrice.TabIndex = 1;
            this.lb_TotalPrice.Text = "1,500đ";
            this.lb_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 597);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartPageForm";
            this.Text = "CartPageForm";
            this.panel2.ResumeLayout(false);
            this.pn_Cart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_Cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_Detail;
        private System.Windows.Forms.Label lb_TotalPrice;
    }
}