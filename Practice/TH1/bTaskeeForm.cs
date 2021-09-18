using Practice.TH1.PageForm;
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

namespace Practice.TH1
{
    public partial class bTaskeeForm : Form
    { 
        private BottomImageButton currentSelected;
        private enum Page { HOME, CART, PROFILE };

        public bTaskeeForm()
        {
            DataService.ReadData();
            InitializeComponent();
            SelectPage(btn_Home, Page.HOME);
            btn_Home.IsSelected = true;
        }

        private void btn_Home_Selected(object sender, EventArgs e)
        {
            SelectPage(sender, Page.HOME);
        }

        private void btn_Activity_Selected(object sender, EventArgs e)
        {
            SelectPage(sender, Page.CART);
            CartPageForm.Instance.Load();
        }

        private void btn_Profile_Selected(object sender, EventArgs e)
        {
            SelectPage(sender, Page.PROFILE);
        }

        private void SelectPage(object currentButtonSelected, Page page)
        {
            pn_page.Controls.Clear();
            if (currentSelected != null) currentSelected.IsSelected = false;
            currentSelected = currentButtonSelected as BottomImageButton;

            Form form = null;
            switch (page)
            {
                case Page.HOME:
                    form = HomePageForm.Instance;
                    break;
                case Page.CART:
                    form = CartPageForm.Instance;
                    break;
                case Page.PROFILE:
                    form = ProfilePageForm.Instance;
                    break;
                default:
                    form = HomePageForm.Instance;
                    break;
            }

            if (form != null)
            {
                form.TopLevel = false;
                pn_page.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void bTaskeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataService.WriteData();
        }
    }
}
