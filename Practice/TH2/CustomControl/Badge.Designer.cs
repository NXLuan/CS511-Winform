
namespace Practice.TH2.CustomControl
{
    partial class Badge
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
            this.lb_TotalServiceOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TotalServiceOrder
            // 
            this.lb_TotalServiceOrder.AutoSize = true;
            this.lb_TotalServiceOrder.BackColor = System.Drawing.Color.Red;
            this.lb_TotalServiceOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TotalServiceOrder.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalServiceOrder.ForeColor = System.Drawing.Color.Transparent;
            this.lb_TotalServiceOrder.Location = new System.Drawing.Point(0, 0);
            this.lb_TotalServiceOrder.Margin = new System.Windows.Forms.Padding(0);
            this.lb_TotalServiceOrder.Name = "lb_TotalServiceOrder";
            this.lb_TotalServiceOrder.Size = new System.Drawing.Size(18, 19);
            this.lb_TotalServiceOrder.TabIndex = 5;
            this.lb_TotalServiceOrder.Text = "0";
            this.lb_TotalServiceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Badge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_TotalServiceOrder);
            this.Name = "Badge";
            this.Size = new System.Drawing.Size(18, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TotalServiceOrder;
    }
}
