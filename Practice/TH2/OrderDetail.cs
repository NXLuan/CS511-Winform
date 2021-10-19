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
    public partial class OrderDetail : Form
    {
        private Order _order;
        public Order order
        {
            get => _order;
            set
            {
                _order = value;
                if (value != null)
                {
                    lbAddress.Text = value.address;
                    lbDateTime.Text = value.dateDelivery;
                    lbFee.Text = FormatHelper.MoneyVN(value.transportFee);
                    lbTotalMoney.Text = FormatHelper.MoneyVN(value.totalMoney);

                    if (value.status == (int)OrderStatus.CANCEL)
                    {
                        btnCancel.Enabled = false;
                        btnCancel.Text = "Đã huỷ";
                        btnCancel.BackColor = Color.White;
                    }
                    else if (value.status == (int)OrderStatus.DELIVERED)
                    {
                        btnCancel.Visible = false;
                    }

                    foreach (var product in value.products)
                    {
                        OrderItem orderItem = new OrderItem()
                        {
                            product = product,
                            IsDetail = true,
                            Dock = DockStyle.Top,
                        };
                        pnListProduct.Controls.Add(orderItem);
                    }
                        
                }
            }
        }

        public HistoryItem historyItem { get; set; }

        public OrderDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            order.status = (int) OrderStatus.CANCEL;
            btnCancel.Enabled = false;
            btnCancel.Text = "Đã huỷ";
            historyItem.order = order;
        }
    }
}
