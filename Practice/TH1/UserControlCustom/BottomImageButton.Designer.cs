
namespace Practice.TH1.UserControlCustom
{
    partial class BottomImageButton
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
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.lb_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icon
            // 
            this.pb_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Icon.Location = new System.Drawing.Point(0, 5);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(49, 19);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Icon.TabIndex = 1;
            this.pb_Icon.TabStop = false;
            // 
            // lb_text
            // 
            this.lb_text.BackColor = System.Drawing.Color.Transparent;
            this.lb_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_text.ForeColor = System.Drawing.Color.Black;
            this.lb_text.Location = new System.Drawing.Point(0, 24);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(49, 23);
            this.lb_text.TabIndex = 2;
            this.lb_text.Text = "text";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_Icon);
            this.Controls.Add(this.lb_text);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BottomImageButton";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Size = new System.Drawing.Size(49, 47);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label lb_text;
    }
}
