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

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                panel1.BackColor = value ? Color.FromArgb(0, 128, 128) : Color.FromArgb(64, 224, 208);
                if (lb_Price != null)
                    lb_Price.Text = value ? String.Format("{0:#,#}", Price) : "0";
            }
        }

        public decimal Price { get; set; }

        public Label lb_Price { get; set; }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user select button")]
        public event EventHandler Selected;

        public HouseworkButton()
        {
            InitializeComponent();
            SelectEvent();
        }

        public void SelectEvent()
        {
            foreach (Control c in Controls[0].Controls)
            {
                c.Click += (s, e) =>
                {
                    IsSelected = !IsSelected;

                    //bubble the event up to the parent
                    if (Selected != null)
                        Selected(this, e);
                };
            }
        }
    }
}
