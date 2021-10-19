using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi6
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            ResetGame();
        }

        public string CurrentPosition { get; set; } //xy -> row x col y

        private void ResetColor()
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Green;
            btn4.BackColor = Color.Blue;
            btn5.BackColor = Color.Green;
            btn6.BackColor = Color.Blue;
            btn7.BackColor = Color.Green;
            btn8.BackColor = Color.Blue;
            btn9.BackColor = Color.Red;
        }

        private void ResetGame()
        {
            ResetColor();
            lblStep.Text = "0";
            CurrentPosition = "11";
            btn1.Select();
            Random r = new Random();
            int rInt = r.Next(11, 20);
            pbExample.ImageLocation = @"../../Buoi6/img/M" + rInt.ToString() + ".png";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        
        private void SwapColor(int oldIndex, int newIndex)
        {
            Button oldBtn = new Button();
            Button newBtn = new Button();
            foreach(var item in this.Controls)
            {
                if (item is Button && (item as Button).Name == "btn" + oldIndex)
                {
                    oldBtn = item as Button;
                    break;
                }
            }
            foreach (var item in this.Controls)
            {
                if (item is Button && (item as Button).Name == "btn" + newIndex)
                {
                    newBtn = item as Button;
                    break;
                }
            }
            Color tempColor = oldBtn.BackColor;
            oldBtn.BackColor = newBtn.BackColor;
            newBtn.BackColor = tempColor;
            newBtn.Select();
            lblStep.Text = (Int32.Parse(lblStep.Text) + 1).ToString();
        }


        private void HandlePress(Keys keyCode)
        {
            int row = CurrentPosition[0] - '0';
            int col = CurrentPosition[1] - '0';
            int indexBtn = 3 * (row - 1) + col;
            switch (keyCode)
            {
                case Keys.W:
                    if (row == 1)
                        return;
                    SwapColor(indexBtn, indexBtn - 3);
                    CurrentPosition = (row - 1).ToString() + col.ToString();
                    break;
                case Keys.S:
                    if (row == 3)
                        return;
                    SwapColor(indexBtn, indexBtn + 3);
                    CurrentPosition = (row + 1).ToString() + col.ToString();
                    break;
                case Keys.A:
                    if (col == 1)
                        return;
                    SwapColor(indexBtn, indexBtn - 1);
                    CurrentPosition = row.ToString() + (col - 1).ToString();
                    break;
                case Keys.D:
                    if (col == 3)
                        return;
                    SwapColor(indexBtn, indexBtn + 1);
                    CurrentPosition = row.ToString() + (col + 1).ToString();
                    break;
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }
        private void btn2_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn3_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn4_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn5_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn6_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn7_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);

        }

        private void btn8_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }

        private void btn9_KeyDown(object sender, KeyEventArgs e)
        {
            HandlePress(e.KeyCode);
        }
    }
}
