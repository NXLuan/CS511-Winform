using Practice.TH2.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.TH2
{
    public partial class CartForm : Form
    {
        private static CartForm _instance;
        public static CartForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CartForm();
                }
                return _instance;
            }
        }

        private List<Product> products;
        private List<Delivery> deliveries;

        private decimal _totalMoney;
        public decimal TotalMoney
        {
            get => _totalMoney;
            set
            {
                _totalMoney = value;
                lbTotalMoney.Text = FormatHelper.MoneyVN(value);
            }
        }

        decimal saveFee;

        private CartForm()
        {
            InitializeComponent();
            products = new List<Product>();
            pnCart.Visible = false;
            deliveries = FileHelper.ReadData<List<Delivery>>("delivery.json");

            cbProvince.DataSource = deliveries;
            cbProvince.DisplayMember = "province";

            for (int i = 1; i <= 4; i++)
                cbDay.Items.Add(FormatHelper.DayMonthYear(DateTime.Now.AddDays(i)));

            cbTime.SelectedIndex = 0;
            cbDay.SelectedIndex = 0;
        }

        public void AddToCart(Product product)
        {
            if (products.Contains(product)) return;
            product.quantity = 1;
            products.Insert(0, product);

            OrderItem orderItem = new OrderItem()
            {
                product = product,
                Dock = DockStyle.Top,
            };

            pnListProduct.Controls.Add(orderItem);

            MainForm.Instance.TotalProductSaleOrder++;
            MainForm.Instance.ShowForm(Page.CART);
            pnCart.Visible = true;
            TotalMoney += product.price;
        }

        public void DeleteItem(Product product, Control control)
        {
            pnListProduct.Controls.Remove(control);
            TotalMoney -= product.price * product.quantity;
            MainForm.Instance.TotalProductSaleOrder -= product.quantity;
            products.Remove(product);
            if (products.Count == 0) pnCart.Visible = false;
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            cbDistrict.DataSource = deliveries[combobox.SelectedIndex].districts;
            cbDistrict.DisplayMember = "district";
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            var district = combobox.SelectedItem as Delivery.District;
            cbWard.DataSource = district.wards;
            TotalMoney -= saveFee;
            saveFee = district.transportFee;
            lbFee.Text = FormatHelper.MoneyVN(saveFee);
            TotalMoney += saveFee;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Order order = new Order()
            {
                products = new List<Product>(this.products),
                address = tbAddress.Text + ", " + cbWard.Text + ", " + cbDistrict.Text + ", " + cbProvince.Text,
                dateDelivery = cbDay.SelectedItem.ToString() + " " + cbTime.SelectedItem.ToString(),
                totalMoney = TotalMoney,
                status = (int)OrderStatus.DELIVERING,
                transportFee = saveFee,
                dateOrder = DateTime.Now,
            };

            products.Clear();
            pnListProduct.Controls.Clear();
            pnCart.Visible = false;
            MainForm.Instance.TotalProductSaleOrder = 0;

            OrderHistoryForm.Instance.AddOrderHistory(order);
        }
    }
}
