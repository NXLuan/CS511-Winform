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
    public partial class OrderItem : UserControl
    {
        public Image ImageItem
        {
            get => pb_ItemImage.Image;
            set => pb_ItemImage.Image = value;
        }

        public string TextItem
        {
            get => lb_ItemText.Text;
            set => lb_ItemText.Text = value;
        }

        private decimal _priceItem;
        public decimal PriceItem
        {
            get => _priceItem;
            set
            {
                _priceItem = value;
                lb_ItemPrice.Text = String.Format("{0:#,#}đ", value);
            }
        }

        public HouseworkButton housework { get; set; } 

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler Delete;

        public OrderItem()
        {
            InitializeComponent();
        }

        private void pb_delete_Click(object sender, EventArgs e)
        {
            if (Delete != null)
                Delete(this, e);
        }
    }
}
