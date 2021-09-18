using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.TH1.PageForm
{
    public partial class ProfilePageForm : Form
    {
        private static ProfilePageForm _instance;
        public static ProfilePageForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProfilePageForm();
                }
                return _instance;
            }
        }

        public ProfilePageForm()
        {
            InitializeComponent();
            InitData();
            EventHandle();
        }

        private void InitData() {
            try
            {
                input_HoTen.Content = DataService.User.HoTen;
                input_SDT.Content = DataService.User.SDT;
                input_DiaChi.Content = DataService.User.DiaChi;
                pb_Avatar.Image = Image.FromFile(DataService.User.Avatar);
            }
            catch
            {

            }
        }

        private void EventHandle()
        {
            input_HoTen.ContentChange += (s, e) =>
            {
                DataService.User.HoTen = input_HoTen.Content;
            };
            input_SDT.ContentChange += (s, e) =>
            {
                DataService.User.SDT = input_SDT.Content;
            };
            input_DiaChi.ContentChange += (s, e) =>
            {
                DataService.User.DiaChi = input_DiaChi.Content;
            };

            input_SDT.KeyInputPress += (s, e) =>
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void pb_ChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog UploadImg = new OpenFileDialog();
                UploadImg.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                if (UploadImg.ShowDialog() == DialogResult.OK)
                {
                    pb_Avatar.Image = Image.FromFile(UploadImg.FileName);
                    DataService.User.Avatar = UploadImg.FileName;
                }
            }
            catch
            {

            }
        }
    }
}
