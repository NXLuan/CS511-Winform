using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.TH2.CustomControl
{
    public partial class ProductItem : UserControl
    {
        private Product _product;
        public Product product 
        {
            get => _product;
            set
            {
                _product = value;
                if (value != null)
                {
                    lbProductName.Text = value.name;
                    lbPrice.Text = FormatHelper.MoneyVN(value.price);
                    pbAvatarProduct.LoadAsync(value.imgUrl);
                }
            }
        }
        public ProductItem()
        {
            InitializeComponent();
        }

        private void pbAddToCart_Click(object sender, EventArgs e)
        {
            CartForm.Instance.AddToCart(product);
        }
    }
}
