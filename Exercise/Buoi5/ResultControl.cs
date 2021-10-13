using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi5
{
    public partial class ResultControl : UserControl
    {
        int _index;
        public int Index
        {
            get => _index;
            set
            {
                _index = value;
                label1.Text = "Q" + (value + 1);
            }
        }
        private Quiz _quiz;
        public Quiz Quiz
        {
            get => _quiz;
            set
            {
                _quiz = value;
                pictureBox1.Image = value.IsCorrect ? pictureBox1.Image = global::Exercise.Properties.Resources.True : pictureBox1.Image = global::Exercise.Properties.Resources.False;
            }
        }
        public ResultControl()
        {
            InitializeComponent();

            foreach (Control c in Controls)
            {
                c.Click += (s, e) =>
                {
                    ResultForm formResult = new ResultForm();
                    formResult.Text = "Result " + label1.Text;
                    formResult.SetData(Quiz);
                    formResult.Show();
                };
            }
        }
    }
}
