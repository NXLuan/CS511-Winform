using Practice.TH1;
using Practice.TH1.Model;
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

namespace Practice.TH1.UserControlCustom
{ 
    public partial class HouseworkButton : UserControl
    {
        public Image ImageButton
        {
            get => pb_ImageButton.Image;
            set => pb_ImageButton.Image = value;
        }

        public string TextButton
        {
            get => lb_TextButton.Text;
            set => lb_TextButton.Text = value;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                lb_price.Text = String.Format("{0:#,#}đ", value);
            }
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    btn_select.BackColor = value ? Color.Red : Color.FromArgb(8, 186, 29);
                    btn_select.Text = value ? "Xoá" : "Thêm";
                    TotalServiceBadge.Instance.TotalServiceOrder += value ? 1 : -1;
                }
            }
        }

        public HouseworkButton()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;

            var services = DataService.User.Cart.Services;
            if (IsSelected)
            {
                services.Add(new ServiceModel()
                {
                    Name = TextButton,
                    Price = Price,
                });
            }
            else
            {
                var find = services.Find(item => item.Name.Equals(TextButton));
                services.Remove(find);
            }
        }
    }
}
