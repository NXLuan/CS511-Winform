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
    public partial class CategoryButton : UserControl
    {
        public string Category
        {
            get => lbCategory.Text;
            set => lbCategory.Text = value;
        }

        public bool _isSelect;
        public bool IsSelect
        {
            get => _isSelect;
            set
            {
                _isSelect = value;
                lbCategory.ForeColor = value ? Color.FromArgb(23, 162, 184) : Color.Black;
            }

        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user select button")]
        public event EventHandler Selected;

        public CategoryButton()
        {
            InitializeComponent();
        }

        private void lbCategory_MouseLeave(object sender, EventArgs e)
        {
            if (IsSelect) return;
            lbCategory.ForeColor = Color.Black;
        }

        private void lbCategory_MouseEnter(object sender, EventArgs e)
        {
            if (IsSelect) return;
            lbCategory.ForeColor = Color.FromArgb(23, 162, 184);
        }

        private void lbCategory_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (Selected != null)
                Selected(this, e);

            IsSelect = true;
        }
    }
}
