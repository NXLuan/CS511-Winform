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
    public partial class TotalServiceBadge : UserControl
    {
        private static TotalServiceBadge _instance;
        public static TotalServiceBadge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TotalServiceBadge();
                }
                return _instance;
            }
        }

        private int _totalServiceOrder;
        public int TotalServiceOrder
        {
            get => _totalServiceOrder;
            set
            {
                _totalServiceOrder = value;
                lb_TotalServiceOrder.Text = value.ToString();
                Visible = value != 0;
            }
        }
        public TotalServiceBadge()
        {
            InitializeComponent();
            _instance = this;
        }
    }
}
