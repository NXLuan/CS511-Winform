
namespace bTaskeeSimulation.CustomControl
{
    partial class CustomImageButton
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
            this.lb_text = new System.Windows.Forms.Label();
            this.pt_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.BackColor = System.Drawing.Color.Transparent;
            this.lb_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_text.Location = new System.Drawing.Point(63, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(119, 49);
            this.lb_text.TabIndex = 3;
            this.lb_text.Text = "text";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pt_icon
            // 
            this.pt_icon.BackColor = System.Drawing.Color.White;
            this.pt_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pt_icon.Location = new System.Drawing.Point(0, 0);
            this.pt_icon.Name = "pt_icon";
            this.pt_icon.Size = new System.Drawing.Size(63, 49);
            this.pt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_icon.TabIndex = 2;
            this.pt_icon.TabStop = false;
            // 
            // CustomImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.pt_icon);
            this.Name = "CustomImageButton";
            this.Size = new System.Drawing.Size(182, 49);
            ((System.ComponentModel.ISupportInitialize)(this.pt_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.PictureBox pt_icon;
    }
}
