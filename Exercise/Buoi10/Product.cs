using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Buoi10
{
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public Bitmap QRCode { get; set; }
    }

    public class ProductOrder
    {
        public int STT { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SL { get; set; }
        public decimal Gia { get; set; }
        public decimal TT { get; set; }
    }
}
