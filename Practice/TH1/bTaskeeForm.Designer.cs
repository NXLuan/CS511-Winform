
namespace Practice.TH1
{
    partial class bTaskeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bTaskeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.badge = new Practice.TH1.UserControlCustom.TotalServiceBadge();
            this.btn_Profile = new Practice.TH1.UserControlCustom.BottomImageButton();
            this.btn_Activity = new Practice.TH1.UserControlCustom.BottomImageButton();
            this.btn_Home = new Practice.TH1.UserControlCustom.BottomImageButton();
            this.pn_page = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.badge);
            this.panel1.Controls.Add(this.btn_Profile);
            this.panel1.Controls.Add(this.btn_Activity);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 54);
            this.panel1.TabIndex = 0;
            // 
            // badge
            // 
            this.badge.Location = new System.Drawing.Point(231, 0);
            this.badge.Name = "badge";
            this.badge.Size = new System.Drawing.Size(24, 19);
            this.badge.TabIndex = 4;
            this.badge.TotalServiceOrder = 0;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.White;
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Profile.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.IconButton = ((System.Drawing.Image)(resources.GetObject("btn_Profile.IconButton")));
            this.btn_Profile.IsSelected = false;
            this.btn_Profile.Location = new System.Drawing.Point(289, 0);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_Profile.Size = new System.Drawing.Size(148, 54);
            this.btn_Profile.TabIndex = 3;
            this.btn_Profile.TextButton = "Tài khoản";
            this.btn_Profile.Selected += new System.EventHandler(this.btn_Profile_Selected);
            // 
            // btn_Activity
            // 
            this.btn_Activity.BackColor = System.Drawing.Color.White;
            this.btn_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Activity.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Activity.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activity.IconButton = ((System.Drawing.Image)(resources.GetObject("btn_Activity.IconButton")));
            this.btn_Activity.IsSelected = false;
            this.btn_Activity.Location = new System.Drawing.Point(141, 0);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_Activity.Size = new System.Drawing.Size(148, 54);
            this.btn_Activity.TabIndex = 1;
            this.btn_Activity.TextButton = "Giỏ hàng";
            this.btn_Activity.Selected += new System.EventHandler(this.btn_Activity_Selected);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Home.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.IconButton = ((System.Drawing.Image)(resources.GetObject("btn_Home.IconButton")));
            this.btn_Home.IsSelected = false;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(141, 54);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TextButton = "Trang chủ";
            this.btn_Home.Selected += new System.EventHandler(this.btn_Home_Selected);
            // 
            // pn_page
            // 
            this.pn_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pn_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_page.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_page.Location = new System.Drawing.Point(0, 0);
            this.pn_page.Name = "pn_page";
            this.pn_page.Size = new System.Drawing.Size(437, 597);
            this.pn_page.TabIndex = 1;
            // 
            // bTaskeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 651);
            this.Controls.Add(this.pn_page);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bTaskeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bTaskee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bTaskeeForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControlCustom.BottomImageButton btn_Home;
        private UserControlCustom.BottomImageButton btn_Profile;
        private UserControlCustom.BottomImageButton btn_Activity;
        private System.Windows.Forms.Panel pn_page;
        private UserControlCustom.TotalServiceBadge badge;
    }
}