using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi10
{
    public partial class ProductPortfolio : Form
    {
        public List<Product> ListProduct { get; set; }
        public ProductPortfolio()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            ListProduct = new List<Product>()
            {
                new Product() { MaSP = "001", TenSP = "Dầu gội", Gia = 99000 },
                new Product() { MaSP = "002", TenSP = "Sữa tắm", Gia = 135000 },
                new Product() { MaSP = "003", TenSP = "Nước rữa chén", Gia = 99000 },
                new Product() { MaSP = "004", TenSP = "Gạo ST25", Gia = 150000 },
                new Product() { MaSP = "005", TenSP = "Nước suối lavie chai 1 lít", Gia = 21000 },
                new Product() { MaSP = "006", TenSP = "Nước tăng lực Sting", Gia = 9000 },
                new Product() { MaSP = "007", TenSP = "Dầu ăn Simply chai 5 lít", Gia = 209000 },
                new Product() { MaSP = "008", TenSP = "Kem Wali", Gia = 11000 },
                new Product() { MaSP = "009", TenSP = "Bán gạo One One", Gia = 18000 },
                new Product() { MaSP = "010", TenSP = "Kẹo bạc hà", Gia = 10000 },
            };

            foreach (var product in ListProduct)
            {
                product.QRCode = Extension.GenerateQR(product.MaSP);
            }
            dataGridProduct.DataSource = ListProduct.ToDataTable<Product>();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            ListProduct.Clear();
            for (int i = 0; i < dataGridProduct.RowCount - 1; i++)
            {
                var row = dataGridProduct.Rows[i];
                var product = new Product()
                {
                    MaSP = row.Cells["MaSP"].Value.ToString(),
                    TenSP = row.Cells["TenSP"].Value.ToString(),
                    Gia = decimal.Parse(row.Cells["Gia"].Value.ToString()),
                };
                product.QRCode = Extension.GenerateQR(product.MaSP);
                ListProduct.Add(product);
            }
            dataGridProduct.DataSource = ListProduct.ToDataTable<Product>();
        }
    }
}
