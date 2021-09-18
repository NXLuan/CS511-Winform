
namespace Practice.TH1.UserControlCustom
{
    partial class InputCustom
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Content = new System.Windows.Forms.TextBox();
            this.pn_Underline = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.White;
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Gray;
            this.lb_Title.Location = new System.Drawing.Point(0, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lb_Title.Size = new System.Drawing.Size(34, 27);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Content);
            this.panel1.Controls.Add(this.pn_Underline);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(303, 29);
            this.panel1.TabIndex = 1;
            // 
            // tb_Content
            // 
            this.tb_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Content.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Content.Location = new System.Drawing.Point(4, 0);
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.Size = new System.Drawing.Size(299, 20);
            this.tb_Content.TabIndex = 1;
            this.tb_Content.TextChanged += new System.EventHandler(this.tb_Content_TextChanged);
            this.tb_Content.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Content_KeyPress);
            // 
            // pn_Underline
            // 
            this.pn_Underline.BackColor = System.Drawing.Color.Silver;
            this.pn_Underline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Underline.Location = new System.Drawing.Point(4, 26);
            this.pn_Underline.Name = "pn_Underline";
            this.pn_Underline.Size = new System.Drawing.Size(299, 3);
            this.pn_Underline.TabIndex = 0;
            // 
            // InputCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Title);
            this.Name = "InputCustom";
            this.Size = new System.Drawing.Size(303, 56);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Content;
        private System.Windows.Forms.Panel pn_Underline;
    }
}
