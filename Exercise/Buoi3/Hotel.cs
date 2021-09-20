using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi3
{
    public partial class Hotel : Form
    {
        DataTable dt = new DataTable();
        private void InitDataTable()
        {
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Status", typeof(bool)); // 1: Available || 0: Occupied
            dt.Columns.Add("TotalDays", typeof(int));
        } 
        public Hotel()
        {
            InitializeComponent();
            InitDataTable();
            cbType.SelectedIndex = 0;
            listView1.LargeImageList = imageList1;
            //listView1.View = View.LargeIcon;     
            lstBoxDays.Items.AddRange(new string[] { "5", "4", "3", "2", "1", "0" });
            lstBoxDays.SelectedIndex = 5;
        }

        private string GenerateID(string type)
        {
            DataRow[] dr = dt.Select("Type='" + type + "'");
            for(int i = 0; i < dr.Length; i++)
            {
                if (dr[i]["ID"].ToString() != type + (i + 1))
                    return type + (i + 1);            
            }
            return type + (dr.Length + 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cbType.SelectedItem.ToString();
            string id = GenerateID(type);
            double price = Convert.ToDouble(txtPrice.Text);
            bool status = rbAvailable.Checked;
            int totalDays = Convert.ToInt32(lstBoxDays.SelectedItem);
            dt.Rows.Add(id, type, price, status, totalDays);
            listView1.Items.Add(id, 0);
        }
        private void LoadData(string id)
        {
            DataRow[] dr = dt.Select("ID='" + id + "'");
            txtID.Text = dr[0]["ID"].ToString();
            cbType.Text = dr[0]["Type"].ToString();
            txtPrice.Text = dr[0]["Price"].ToString();
            rbAvailable.Checked = Convert.ToBoolean(dr[0]["Status"]);
            rbOccupied.Checked = !rbAvailable.Checked;
            lstBoxDays.SelectedIndex = 5 - (int)dr[0]["TotalDays"];
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LoadData(e.Item.Text);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rbAvailable.Checked)
            {
                DataRow dr = dt.Select("ID='" + txtID.Text + "'").FirstOrDefault();
                if (dr != null)
                {
                    dr["Status"] = false;
                    dr["TotalDays"] = Convert.ToInt32(lstBoxDays.SelectedItem);
                }
                LoadData(txtID.Text);
            }
            else
            {
                MessageBox.Show("Phòng này đã có người đặt rồi!");
            }
        }
        private void SetEmptyRoom()
        {
            DataRow dr = dt.Select("ID='" + txtID.Text + "'").FirstOrDefault();
            if (dr != null)
            {
                dr["Status"] = true;
                dr["TotalDays"] = 0;
            }      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetEmptyRoom();
            LoadData(txtID.Text);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn cần thanh toán số tiền là " + txtPrice.Text + " đồng", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
                SetEmptyRoom();
            LoadData(txtID.Text);
        }
    }
}
