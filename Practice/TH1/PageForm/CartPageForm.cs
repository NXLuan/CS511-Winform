using Practice.TH1.UserControlCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.TH1.PageForm
{
    public partial class CartPageForm : Form
    {
        private static CartPageForm _instance;
        public static CartPageForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CartPageForm();
                }
                return _instance;
            }
        }

        private decimal _totalPrice;
        public decimal TotalPrice 
        {
            get => _totalPrice; 
            set
            {
                _totalPrice = value;
                lb_TotalPrice.Text = String.Format("{0:#,#}đ", value);
            }
        }

        public CartPageForm()
        {
            InitializeComponent();
        }

        public void Load()
        {
            pn_Detail.Controls.Clear();
            TotalPrice = 0;
            var data = HomePageForm.Instance.DataHousework;
            foreach (var housework in data)
            {
                if (housework.IsSelected)
                {
                    OrderItem item = new OrderItem()
                    {
                        Dock = DockStyle.Top,
                        PriceItem = housework.Price,
                        ImageItem = housework.ImageButton,
                        TextItem = housework.TextButton,
                        housework = housework,
                    };

                    item.Delete += (s, e) => 
                    { 
                        var orderItem = s as OrderItem;
                        orderItem.housework.IsSelected = false;
                        TotalPrice -= orderItem.housework.Price;

                        // delete data
                        var services = DataService.User.Cart.Services;
                        var find = services.Find(i => i.Name.Equals(orderItem.TextItem));
                        services.Remove(find);

                        pn_Detail.Controls.Remove(orderItem);

                        if (pn_Detail.Controls.Count == 0) pn_Cart.Visible = false;
                    };

                    pn_Detail.Controls.Add(item);

                    TotalPrice += housework.Price;
                }
            }

            pn_Cart.Visible = pn_Detail.Controls.Count != 0;
        }
    }
}
