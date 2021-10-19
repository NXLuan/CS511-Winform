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
    public partial class OrderHistoryForm : Form
    {
        private static OrderHistoryForm _instance;
        public static OrderHistoryForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderHistoryForm();
                }
                return _instance;
            }
        }

        public List<Order> orders { get; set; }

        public OrderHistoryForm()
        {
            InitializeComponent();
            orders = FileHelper.ReadData<List<Order>>("order.json");

            foreach (var order in orders)
            {
                HistoryItem historyItem = new HistoryItem()
                {
                    order = order,
                    Dock = DockStyle.Top,
                };
                pnListOrder.Controls.Add(historyItem);
            }

            cbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cbYear.SelectedIndex = 0;
        }

        public void AddOrderHistory(Order order)
        {
            order.id = "DH" + (orders.Count + 1);
            orders.Add(order);
            HistoryItem historyItem = new HistoryItem()
            {
                order = order,
                Dock = DockStyle.Top,
            };
            pnListOrder.Controls.Add(historyItem);
            MainForm.Instance.ShowForm(Page.HISTORY);
            MessageBox.Show("Mã đơn: " + order.id, "Đặt hàng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileHelper.WriteData<List<Order>>(orders, "order.json");
            cbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cbYear.SelectedIndex = 0;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilter();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilter();
        }

        public void ShowFilter()
        {
            if (cbMonth.SelectedItem == null || cbYear.SelectedItem == null) return;
            int numOrder = 0;
            decimal totalMoney = 0;
            pnListOrder.Controls.Clear();
            foreach (var order in orders)
            {
                if ((order.dateOrder.Month == (cbMonth.SelectedIndex + 1)) && (order.dateOrder.Year == int.Parse(cbYear.SelectedItem.ToString())))
                {
                    numOrder++;
                    totalMoney += order.totalMoney;

                    HistoryItem historyItem = new HistoryItem()
                    {
                        order = order,
                        Dock = DockStyle.Top,
                    };
                    pnListOrder.Controls.Add(historyItem);
                }
            }

            lbNumOrder.Text = numOrder.ToString();
            lbTotalMoney.Text = FormatHelper.MoneyVN(totalMoney);
        }
    }
}
