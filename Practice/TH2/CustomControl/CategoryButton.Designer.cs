
namespace Practice.TH2.CustomControl
{
    partial class CategoryButton
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
            this.lbCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(0, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbCategory.Size = new System.Drawing.Size(216, 33);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCategory.Click += new System.EventHandler(this.lbCategory_Click);
            this.lbCategory.MouseEnter += new System.EventHandler(this.lbCategory_MouseEnter);
            this.lbCategory.MouseLeave += new System.EventHandler(this.lbCategory_MouseLeave);
            // 
            // CategoryButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCategory);
            this.Name = "CategoryButton";
            this.Size = new System.Drawing.Size(216, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCategory;
    }
}
