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
    public partial class OrderItem : UserControl
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
                    lbQuantity.Text = value.quantity.ToString();
                    pbAvatarProduct.LoadAsync(value.imgUrl);
                    btnDecrease.Enabled = false;
                }

            }
        }

        public bool IsDetail
        {
            set
            {
                if (value)
                {
                    btnDecrease.Visible = false;
                    btnAdd.Visible = false;
                    lbQuantity.Visible = false;
                    lbDelete.Enabled = false;
                    lbDelete.Text = "Số lượng: " + product.quantity;
                }
            }
        }

        public OrderItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (product.quantity == 1) btnDecrease.Enabled = true;
            product.quantity++;
            MainForm.Instance.TotalProductSaleOrder++;
            lbQuantity.Text = product.quantity.ToString();
            CartForm.Instance.TotalMoney += product.price;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            product.quantity--;
            MainForm.Instance.TotalProductSaleOrder--;
            if (product.quantity == 1) btnDecrease.Enabled = false;
            lbQuantity.Text = product.quantity.ToString();
            CartForm.Instance.TotalMoney -= product.price;
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            CartForm.Instance.DeleteItem(product, this);
        }
    }
}
