
namespace Exercise.Buoi2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_TextButton = new System.Windows.Forms.Label();
            this.pb_ImageButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pb_ImageButton);
            this.panel1.Controls.Add(this.lb_TextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(151, 132);
            this.panel1.TabIndex = 3;
            // 
            // lb_TextButton
            // 
            this.lb_TextButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_TextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(22)))), ((int)(((byte)(0)))));
            this.lb_TextButton.Location = new System.Drawing.Point(0, 104);
            this.lb_TextButton.Name = "lb_TextButton";
            this.lb_TextButton.Size = new System.Drawing.Size(151, 28);
            this.lb_TextButton.TabIndex = 5;
            this.lb_TextButton.Text = "label1";
            this.lb_TextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_ImageButton
            // 
            this.pb_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_ImageButton.Location = new System.Drawing.Point(0, 10);
            this.pb_ImageButton.Name = "pb_ImageButton";
            this.pb_ImageButton.Size = new System.Drawing.Size(151, 94);
            this.pb_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImageButton.TabIndex = 4;
            this.pb_ImageButton.TabStop = false;
            // 
            // HouseworkButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "HouseworkButton";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(157, 138);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TextButton;
        private System.Windows.Forms.PictureBox pb_ImageButton;
    }
}
