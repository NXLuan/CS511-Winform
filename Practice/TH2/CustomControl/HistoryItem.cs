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
    public partial class HistoryItem : UserControl
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
                    lbId.Text = value.id;
                    lbDateOrder.Text = FormatHelper.DayMonthYear(value.dateOrder);
                    switch (value.status)
                    {
                        case (int)OrderStatus.DELIVERED:
                            lbStatus.Text = "Đã giao hàng";
                            lbStatus.ForeColor = Color.Green;
                            break;
                        case (int)OrderStatus.DELIVERING:
                            lbStatus.Text = "Đang giao hàng";
                            lbStatus.ForeColor = Color.Orange;
                            break;
                        case (int)OrderStatus.CANCEL:
                            lbStatus.Text = "Đã huỷ";
                            lbStatus.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }
        public HistoryItem()
        {
            InitializeComponent();

            foreach (Control control in Controls[0].Controls[0].Controls)
            {
                control.Click += (s, e) =>
                {
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        order = this.order,
                        Text = "Chi tiết đơn hàng " + lbId.Text,
                        historyItem = this
                    };
                    orderDetail.Show();
                };
            }
        }

        public void CancelOrder()
        {
            lbStatus.Text = "Đã huỷ";
            lbStatus.ForeColor = Color.Red;
        }
    }
}
