
namespace Practice.TH1.UserControlCustom
{
    partial class HouseworkButton
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
            this.pb_ImageButton = new System.Windows.Forms.PictureBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.lb_TextButton = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ImageButton
            // 
            this.pb_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_ImageButton.Location = new System.Drawing.Point(20, 10);
            this.pb_ImageButton.Name = "pb_ImageButton";
            this.pb_ImageButton.Size = new System.Drawing.Size(114, 136);
            this.pb_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImageButton.TabIndex = 6;
            this.pb_ImageButton.TabStop = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(186)))), ((int)(((byte)(29)))));
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(20, 146);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(114, 34);
            this.btn_select.TabIndex = 9;
            this.btn_select.Text = "Thêm";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lb_TextButton
            // 
            this.lb_TextButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_TextButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextButton.ForeColor = System.Drawing.Color.Black;
            this.lb_TextButton.Location = new System.Drawing.Point(20, 10);
            this.lb_TextButton.Name = "lb_TextButton";
            this.lb_TextButton.Size = new System.Drawing.Size(114, 24);
            this.lb_TextButton.TabIndex = 10;
            this.lb_TextButton.Text = "label1";
            this.lb_TextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_price
            // 
            this.lb_price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_price.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(173)))), ((int)(((byte)(20)))));
            this.lb_price.Location = new System.Drawing.Point(20, 122);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(114, 24);
            this.lb_price.TabIndex = 11;
            this.lb_price.Text = "label1";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HouseworkButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_TextButton);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.pb_ImageButton);
            this.Controls.Add(this.btn_select);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "HouseworkButton";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Size = new System.Drawing.Size(154, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ImageButton;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lb_TextButton;
        private System.Windows.Forms.Label lb_price;
    }
}
