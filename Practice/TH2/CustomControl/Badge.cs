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
    public partial class Badge : UserControl
    {
        private static Badge _instance;
        public static Badge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Badge();
                }
                return _instance;
            }
        }

        private int _number;
        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                lb_TotalServiceOrder.Text = value.ToString();
                Visible = value != 0;
            }
        }
        public Badge()
        {
            InitializeComponent();
            _instance = this;
        }
    }
}
