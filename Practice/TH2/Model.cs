using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.TH2
{
    public enum Page { HOME = 1, CART = 2, HISTORY = 3 };
    public enum Category { ALL, APPLE, OPPO, XIAOMI, SAMSUNG };
    public enum OrderStatus { DELIVERED, DELIVERING, CANCEL }

    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string imgUrl { get; set; }
        public decimal price { get; set; }
        public int brandID { get; set; }
        public int quantity { get; set; }
    }

    public class Delivery
    {
        public string province { get; set; }
        public List<District> districts { get; set; }
        public class District
        {
            public string district { get; set; }
            public decimal transportFee { get; set; }
            public List<string> wards { get; set; }
        }
    }

    public class Order
    {
        public string id { get; set; }
        public List<Product> products { get; set; }
        public decimal transportFee { get; set; }
        public decimal totalMoney { get; set; }
        public int status { get; set; }
        public DateTime dateOrder { get; set; }
        public string dateDelivery { get; set; }
        public string address { get; set; }
    }
}
