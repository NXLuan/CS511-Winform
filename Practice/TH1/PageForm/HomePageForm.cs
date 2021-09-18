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
    public partial class HomePageForm : Form
    {
        private static HomePageForm _instance;
        public static HomePageForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomePageForm();
                }
                return _instance;
            }
        }

        public List<HouseworkButton> DataHousework { get; set; }

        public HomePageForm()
        {
            InitializeComponent();

            var services = DataService.User.Cart.Services;

            foreach (var item in services)
            {
                foreach (var button in table.Controls)
                {
                    HouseworkButton btn_hosework = button as HouseworkButton;
                    if (item.Name.Equals(btn_hosework.TextButton))
                    {
                        btn_hosework.IsSelected = true;
                        break;
                    }
                }
            }

            DataHousework = new List<HouseworkButton>();
            foreach (var button in table.Controls)
            {
                HouseworkButton btn_hosework = button as HouseworkButton;
                DataHousework.Add(btn_hosework);
            }
        }
    }
}
