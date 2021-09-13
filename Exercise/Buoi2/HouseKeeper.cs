using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi2
{
    public partial class HouseKeeper : Form
    {
        private decimal _totalPrice;
        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                _totalPrice = value;
                lb_TotalPrice.Text = String.Format("{0:#,#}", value);
            }
        }

        HouseworkButton SelectedButton;

        public HouseKeeper()
        {
            InitializeComponent();
            SelectTabHome(isInit: true);
            SelectHouseworkHandle();
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            SelectTabHome();
        }

        private void pb_cart_Click(object sender, EventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                pb_cart.BackColor = Color.FromArgb(46, 139, 87);
                pb_home.BackColor = Color.White;
                tab.SelectedIndex = 1;
            }
        }

        public void SelectTabHome(bool isInit = false)
        {
            if (tab.SelectedIndex == 1 || isInit)
            {
                pb_home.BackColor = Color.FromArgb(46, 139, 87);
                pb_cart.BackColor = Color.White;
                tab.SelectedIndex = 0;
            }
        }

        public void SelectHouseworkHandle()
        {
            foreach (var item in table.Controls)
            {
                HouseworkButton houseworkButton = item as HouseworkButton;
                houseworkButton.Selected += (s, e) =>
                {
                    // unfocus
                    if (SelectedButton != null)
                        SelectedButton.BackColor = SystemColors.Control;

                    SelectedButton = s as HouseworkButton;
                    TotalPrice += houseworkButton.Price * (SelectedButton.IsSelected ? 1 : -1);

                    // set focus
                    houseworkButton.BackColor = Color.FromArgb(0, 120, 215);
                };
            }
        }
    }
}
