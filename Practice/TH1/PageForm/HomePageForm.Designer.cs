
namespace Practice.TH1.PageForm
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.btn_VeSinhMayLanh = new Practice.TH1.UserControlCustom.HouseworkButton();
            this.btnNau_An = new Practice.TH1.UserControlCustom.HouseworkButton();
            this.btn_DonNha = new Practice.TH1.UserControlCustom.HouseworkButton();
            this.btn_GiatUi = new Practice.TH1.UserControlCustom.HouseworkButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.btn_VeSinhMayLanh, 1, 1);
            this.table.Controls.Add(this.btnNau_An, 0, 1);
            this.table.Controls.Add(this.btn_DonNha, 0, 0);
            this.table.Controls.Add(this.btn_GiatUi, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 56);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(437, 541);
            this.table.TabIndex = 1;
            // 
            // btn_VeSinhMayLanh
            // 
            this.btn_VeSinhMayLanh.BackColor = System.Drawing.Color.White;
            this.btn_VeSinhMayLanh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_VeSinhMayLanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VeSinhMayLanh.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_VeSinhMayLanh.ImageButton")));
            this.btn_VeSinhMayLanh.IsSelected = false;
            this.btn_VeSinhMayLanh.Location = new System.Drawing.Point(228, 270);
            this.btn_VeSinhMayLanh.Margin = new System.Windows.Forms.Padding(10, 0, 20, 20);
            this.btn_VeSinhMayLanh.Name = "btn_VeSinhMayLanh";
            this.btn_VeSinhMayLanh.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btn_VeSinhMayLanh.Price = new decimal(new int[] {
            180000,
            0,
            0,
            0});
            this.btn_VeSinhMayLanh.Size = new System.Drawing.Size(189, 251);
            this.btn_VeSinhMayLanh.TabIndex = 3;
            this.btn_VeSinhMayLanh.TextButton = "Vệ sinh máy lạnh";
            // 
            // btnNau_An
            // 
            this.btnNau_An.BackColor = System.Drawing.Color.White;
            this.btnNau_An.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNau_An.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNau_An.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnNau_An.ImageButton")));
            this.btnNau_An.IsSelected = false;
            this.btnNau_An.Location = new System.Drawing.Point(20, 270);
            this.btnNau_An.Margin = new System.Windows.Forms.Padding(20, 0, 10, 20);
            this.btnNau_An.Name = "btnNau_An";
            this.btnNau_An.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnNau_An.Price = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.btnNau_An.Size = new System.Drawing.Size(188, 251);
            this.btnNau_An.TabIndex = 2;
            this.btnNau_An.TextButton = "Nấu ăn";
            // 
            // btn_DonNha
            // 
            this.btn_DonNha.BackColor = System.Drawing.Color.White;
            this.btn_DonNha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_DonNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DonNha.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_DonNha.ImageButton")));
            this.btn_DonNha.IsSelected = false;
            this.btn_DonNha.Location = new System.Drawing.Point(20, 10);
            this.btn_DonNha.Margin = new System.Windows.Forms.Padding(20, 10, 10, 20);
            this.btn_DonNha.Name = "btn_DonNha";
            this.btn_DonNha.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btn_DonNha.Price = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.btn_DonNha.Size = new System.Drawing.Size(188, 240);
            this.btn_DonNha.TabIndex = 0;
            this.btn_DonNha.TextButton = "Dọn nhà";
            // 
            // btn_GiatUi
            // 
            this.btn_GiatUi.BackColor = System.Drawing.Color.White;
            this.btn_GiatUi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_GiatUi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GiatUi.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_GiatUi.ImageButton")));
            this.btn_GiatUi.IsSelected = false;
            this.btn_GiatUi.Location = new System.Drawing.Point(228, 10);
            this.btn_GiatUi.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
            this.btn_GiatUi.Name = "btn_GiatUi";
            this.btn_GiatUi.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btn_GiatUi.Price = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.btn_GiatUi.Size = new System.Drawing.Size(189, 240);
            this.btn_GiatUi.TabIndex = 1;
            this.btn_GiatUi.TextButton = "Giặt ủi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 10);
            this.panel1.Size = new System.Drawing.Size(437, 56);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 45);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(133)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(437, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 597);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.table.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel table;
        private Practice.TH1.UserControlCustom.HouseworkButton btn_DonNha;
        private Practice.TH1.UserControlCustom.HouseworkButton btn_GiatUi;
        private Practice.TH1.UserControlCustom.HouseworkButton btnNau_An;
        private Practice.TH1.UserControlCustom.HouseworkButton btn_VeSinhMayLanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}