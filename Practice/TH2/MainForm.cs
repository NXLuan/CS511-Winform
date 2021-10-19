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
    public partial class MainForm : Form
    {
        private static MainForm _instance;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }
        private Page currenForm;
        public int TotalProductSaleOrder
        {
            get => totalOrderBadge.Number;
            set => totalOrderBadge.Number = value;
        }

        private MainForm()
        {
            InitializeComponent();
            ShowForm(Page.HOME);
        }

        public void ShowForm(Page page)
        {
            if (currenForm == page) return;
            currenForm = page;
            pnForm.Controls.Clear();

            Form form = null;
            switch (page)
            {
                case Page.HOME:
                    form = HomeForm.Instance;
                    break;
                case Page.CART:
                    form = CartForm.Instance;
                    break;
                case Page.HISTORY:
                    form = OrderHistoryForm.Instance;
                    break;
            }

            if (form != null)
            {
                form.TopLevel = false;
                pnForm.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void pbApp_Click(object sender, EventArgs e)
        {
            ShowForm(Page.HOME);
        }

        private void lbApp_Click(object sender, EventArgs e)
        {
            ShowForm(Page.HOME);
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            ShowForm(Page.CART);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (currenForm != Page.HOME)
                ShowForm(Page.HOME);
            HomeForm.Instance.SearchProduct(tbSearch.Text);
        }

        private void pbOrderHistory_Click(object sender, EventArgs e)
        {
            ShowForm(Page.HISTORY);
        }
    }
}
