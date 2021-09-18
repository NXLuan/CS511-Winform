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
    public partial class InputCustom : UserControl
    {
        public string Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }
        public string Content
        {
            get => tb_Content.Text;
            set => tb_Content.Text = value;
        }

        [Browsable(true)]
        [Category("Property Changed")]
        public event EventHandler ContentChange;
        [Browsable(true)]
        [Category("Key")]
        public event KeyPressEventHandler KeyInputPress;
        public InputCustom()
        {
            InitializeComponent();
            FocusEvent();
        }

        private void FocusEvent()
        {
            tb_Content.GotFocus += (s, e) =>
            {
                pn_Underline.BackColor = Color.FromArgb(252, 133, 51);
                lb_Title.ForeColor = Color.FromArgb(252, 133, 51);
            };

            tb_Content.LostFocus += (s, e) =>
            {
                pn_Underline.BackColor = Color.Silver;
                lb_Title.ForeColor = Color.Silver;
            };
        }

        private void tb_Content_TextChanged(object sender, EventArgs e)
        {
            if (ContentChange != null)
                ContentChange(this, e);
        }

        private void tb_Content_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyInputPress != null)
                KeyInputPress(this, e);
        }
    }
}
