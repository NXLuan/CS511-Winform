using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Buoi8
{
    public partial class Paint : Form
    {
        Pen pen;
        Rectangle rect;
        Point LocationStart;
        Point LocationEnd;
        Graphics graphics;
        public Paint()
        {
            InitializeComponent();
            graphics = pnPage.CreateGraphics();
            pen = new Pen(Color.Black);
        }

        private void btnPencolor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnPenColor.BackColor = dialog.Color;
                pen.Color = dialog.Color;
            }
        }

        public Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationStart.X, LocationEnd.X);
            rect.Y = Math.Min(LocationStart.Y, LocationEnd.Y);
            rect.Width = Math.Abs(LocationStart.X - LocationEnd.X);
            rect.Height = Math.Abs(LocationStart.Y - LocationEnd.Y);
            return rect;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            pnPage.Refresh();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(dialog.FileName);
                graphics.DrawImage(img, new Point(Int32.Parse(lbX.Text), Int32.Parse(lbY.Text)));
            }
        }

        private void pnPage_MouseUp(object sender, MouseEventArgs e)
        {
            LocationEnd = e.Location;
            if (radioRec.Checked)
            {
                graphics.DrawRectangle(pen, GetRect());
            }
            else
            if (radioLine.Checked)
            {
                graphics.DrawLine(pen, LocationStart.X, LocationStart.Y, LocationEnd.X, LocationEnd.Y);
            }
            else
            if (radioString.Checked)
            {
                graphics.DrawString("Nhom10 - 18521066 - 18521494", pnPage.Font, new SolidBrush(btnPenColor.BackColor), LocationStart);
            }
            else
            if (radioEllipse.Checked)
            {
                graphics.DrawEllipse(pen, GetRect());
            }
            else
            if (radioFillEllipse.Checked)
            {
                graphics.FillEllipse(new SolidBrush(btnPenColor.BackColor), GetRect());
            }
            else
            if (radioFillRec.Checked)
            {
                graphics.FillRectangle(new SolidBrush(btnPenColor.BackColor), GetRect());
            }
        }

        private void pnPage_MouseDown(object sender, MouseEventArgs e)
        {
            LocationStart = e.Location;
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = Int32.Parse(numeric.Value.ToString());
        }
    }
}
