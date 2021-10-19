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
    public partial class HomeForm : Form
    {
        private static HomeForm _instance;
        public static HomeForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomeForm();
                }
                return _instance;
            }
        }

        private List<Product> products;
        private int currentCategory;

        private HomeForm()
        {
            InitializeComponent();
            products = FileHelper.ReadData<List<Product>>("product.json");
            currentCategory = -1;
            SelectCategory(Category.ALL);
            btnAll.IsSelect = true;
            EventHandle();
        }
        private void EventHandle()
        {
            btnAll.Selected += (s, e) =>
            {
                SelectCategory(Category.ALL);
            };
            btnApple.Selected += (s, e) =>
            {
                SelectCategory(Category.APPLE);
            };
            btnOppo.Selected += (s, e) =>
            {
                SelectCategory(Category.OPPO);
            };
            btnXiaomi.Selected += (s, e) =>
            {
                SelectCategory(Category.XIAOMI);
            };
            btnSamSung.Selected += (s, e) =>
            {
                SelectCategory(Category.SAMSUNG);
            };
        }

        public void SelectCategory(Category category)
        {
            if (currentCategory == (int)category) return;
            currentCategory = (int)category;
            ResetConrol();

            foreach (var item in products)
            {
                ProductItem product = new ProductItem()
                {
                    product = item
                };

                if (category == Category.ALL)
                    flListProduct.Controls.Add(product);
                else if (item.brandID == (int)category)
                    flListProduct.Controls.Add(product);
            }
        }

        public void ResetConrol()
        {
            btnAll.IsSelect = false;
            btnApple.IsSelect = false;
            btnOppo.IsSelect = false;
            btnXiaomi.IsSelect = false;
            btnSamSung.IsSelect = false;
            flListProduct.Controls.Clear();
        }

        public void SearchProduct(string text)
        {
            ResetConrol();
            currentCategory = -1;
            foreach (var item in products)
            {
                ProductItem product = new ProductItem()
                {
                    product = item
                };

                if (item.name.ToLower().Contains(text.Trim().ToLower()))
                    flListProduct.Controls.Add(product);
            }
        }
    }
}
