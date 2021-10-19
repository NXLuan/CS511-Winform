
namespace Practice.TH2
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flListProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSamSung = new Practice.TH2.CustomControl.CategoryButton();
            this.btnXiaomi = new Practice.TH2.CustomControl.CategoryButton();
            this.btnOppo = new Practice.TH2.CustomControl.CategoryButton();
            this.btnApple = new Practice.TH2.CustomControl.CategoryButton();
            this.btnAll = new Practice.TH2.CustomControl.CategoryButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSamSung);
            this.panel1.Controls.Add(this.btnXiaomi);
            this.panel1.Controls.Add(this.btnOppo);
            this.panel1.Controls.Add(this.btnApple);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 581);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flListProduct
            // 
            this.flListProduct.AutoScroll = true;
            this.flListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flListProduct.Location = new System.Drawing.Point(176, 0);
            this.flListProduct.Name = "flListProduct";
            this.flListProduct.Padding = new System.Windows.Forms.Padding(5);
            this.flListProduct.Size = new System.Drawing.Size(723, 581);
            this.flListProduct.TabIndex = 1;
            // 
            // btnSamSung
            // 
            this.btnSamSung.Category = "Samsung";
            this.btnSamSung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSamSung.Location = new System.Drawing.Point(0, 178);
            this.btnSamSung.Name = "btnSamSung";
            this.btnSamSung.Size = new System.Drawing.Size(176, 33);
            this.btnSamSung.TabIndex = 5;
            // 
            // btnXiaomi
            // 
            this.btnXiaomi.Category = "Xiaomi";
            this.btnXiaomi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXiaomi.Location = new System.Drawing.Point(0, 145);
            this.btnXiaomi.Name = "btnXiaomi";
            this.btnXiaomi.Size = new System.Drawing.Size(176, 33);
            this.btnXiaomi.TabIndex = 4;
            // 
            // btnOppo
            // 
            this.btnOppo.Category = "Oppo";
            this.btnOppo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOppo.Location = new System.Drawing.Point(0, 112);
            this.btnOppo.Name = "btnOppo";
            this.btnOppo.Size = new System.Drawing.Size(176, 33);
            this.btnOppo.TabIndex = 3;
            // 
            // btnApple
            // 
            this.btnApple.Category = "Apple";
            this.btnApple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApple.Location = new System.Drawing.Point(0, 79);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(176, 33);
            this.btnApple.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.Category = "Tất cả";
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.Location = new System.Drawing.Point(0, 46);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(176, 33);
            this.btnAll.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 581);
            this.Controls.Add(this.flListProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControl.CategoryButton btnSamSung;
        private CustomControl.CategoryButton btnXiaomi;
        private CustomControl.CategoryButton btnOppo;
        private CustomControl.CategoryButton btnApple;
        private CustomControl.CategoryButton btnAll;
        private System.Windows.Forms.FlowLayoutPanel flListProduct;
    }
}