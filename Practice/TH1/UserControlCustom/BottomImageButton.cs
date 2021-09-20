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
    public partial class BottomImageButton : UserControl
    {
        public Image IconButton
        {
            get => pb_Icon.Image;
            set => pb_Icon.Image = value;
        }

        public string TextButton
        {
            get => lb_text.Text;
            set => lb_text.Text = value;
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                BackColor = value ? Color.FromArgb(255, 230, 202) : Color.White;
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user select button")]
        public event EventHandler Selected;

        public BottomImageButton()
        {
            InitializeComponent();
            SelectedEvent();
        }

        public void SelectedEvent()
        {
            foreach (Control c in Controls)
            {
                c.Click += (s, e) =>
                {
                    if (IsSelected) return;
                    IsSelected = true;

                    //bubble the event up to the parent
                    if (Selected != null)
                        Selected(this, e);
                };
            }
        }
    }
}
