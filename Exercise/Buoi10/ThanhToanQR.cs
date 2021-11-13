using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Exercise.Buoi10
{
    public partial class ThanhToanQR : Form
    {
        private Capture cap;
        private ProductPortfolio ListProductForm;
        private List<ProductOrder> productOrders;

        public ThanhToanQR()
        {
            InitializeComponent();
            ListProductForm = new ProductPortfolio();
            productOrders = new List<ProductOrder>();
        }

        private void ThanhToanQR_Load(object sender, EventArgs e)
        {
            cap = new Capture(0);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image<Bgr, byte> nextFrame = cap.QueryFrame();
            var bitmap = nextFrame.ToBitmap();
            pictureBox1.Image = bitmap;
            DecryptionQR(bitmap);
            //Image<Gray, byte> grayFrame = nextFrame.Convert<Gray, byte>();
            //pictureBox2.Image = grayFrame.ToBitmap();
        }

        private void pbWarehouse_Click(object sender, EventArgs e)
        {
            ListProductForm.Show();
        }

        public void DecryptionQR(Bitmap image)
        {
            Bitmap imageQR = image;
            if (imageQR != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(imageQR);
                    if (result != null)
                    {
                        string code = result.ToString().Trim();
                        foreach (var product in ListProductForm.ListProduct)
                        {
                            if (code.Equals(product.MaSP))
                            {
                                var findOrder = productOrders.Find(p => p.MaSP.Equals(product.MaSP));
                                if (findOrder == null)
                                {
                                    productOrders.Add(new ProductOrder()
                                    {
                                        STT = productOrders.Count + 1,
                                        MaSP = product.MaSP,
                                        TenSP = product.TenSP,
                                        Gia = product.Gia,
                                        SL = 1,
                                        TT = product.Gia,
                                    });
                                    dataGridSP.DataSource = productOrders.ToDataTable<ProductOrder>();
                                    RecalculateMoney();
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void dataGridSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                var row = dataGridSP.Rows[e.RowIndex];
                decimal ttRow = decimal.Parse(row.Cells["Gia"].Value.ToString()) * int.Parse(row.Cells["SL"].Value.ToString());
                row.Cells["TT"].Value = ttRow.ToString();
                RecalculateMoney();
            }
        }

        public void RecalculateMoney()
        {
            decimal TongTien = 0;
            decimal KhuyenMai = 0;
            for(int i =0; i< dataGridSP.RowCount; i++)
            {
                TongTien += decimal.Parse(dataGridSP.Rows[i].Cells["TT"].Value.ToString());
            }
            tbTongTien.Text = TongTien.ToString();
            tbThanhToan.Text = (TongTien + KhuyenMai).ToString();
        }
    }
}
