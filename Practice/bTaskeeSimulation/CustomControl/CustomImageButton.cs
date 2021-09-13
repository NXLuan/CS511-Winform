using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bTaskeeSimulation.CustomControl
{
    public partial class CustomImageButton : UserControl
    {
        public string TextButton
        {
            get => lb_text.Text;
            set => lb_text.Text = value;
        }

        public Image IconButton
        {
            get => pt_icon.Image;
            set => pt_icon.Image = value;
        }

        #region color button
        private Color _normalColor;
        public Color NormalColor
        {
            get => _normalColor;
            set => _normalColor = BackColor = value;
        }
        public Color HoverColor { get; set; }
        public Color ActiveColor { get; set; }
        #endregion

        public CustomImageButton()
        {
            InitializeComponent();
            MouseEvent();
        }

        private void MouseEvent()
        {
            foreach (Control c in this.Controls)
            {
                c.MouseEnter += (s, e) => { BackColor = HoverColor; };
                c.MouseLeave += (s, e) => { BackColor = NormalColor; };
                c.MouseDown += (s, e) => { BackColor = ActiveColor; };
                c.MouseUp += (s, e) => { BackColor = NormalColor; };
            }
        }
    }
}
