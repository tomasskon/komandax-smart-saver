using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SmartSaver.Logic.HelperClasses.Images;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Balance;
using SmartSaver.Domain.Models;

namespace SmartSaver.Forms.UserControls
{
    public partial class Main : UserControl
    {
        private User _user;
        public Main()
        {
            InitializeComponent();
            UpdateImg();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if(p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp)| *.jpg; *.jpeg; *.bmp";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var _userRepository = new UserRepository();
            var helper = new BalanceHelper(_userRepository);
            _user = await helper.GetUserBalance(userId: Domain.Constants.Constants.TestUserId);
            byte[] file_byte = ImageToByteArray(pictureBox1.Image);
            _user.UserImage = file_byte;
            await _userRepository.Update(_user.Id, _user);
        }

        public Image ByteArrayToImage(byte[] ba)
        {
            if(ba != null)
            using (MemoryStream ms = new MemoryStream(ba))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateImg();
        }

        public async void UpdateImg()
        {
            var _userRepository = new UserRepository();
            var helper = new BalanceHelper(_userRepository);
            _user = await helper.GetUserBalance(userId: Domain.Constants.Constants.TestUserId);
            MoneyFormatter moneyFormatter= new MoneyFormatter();
            textBox1.Text = moneyFormatter.FormatMoney(_user.Cash + _user.Card);
            pictureBox1.Image = ByteArrayToImage(_user.UserImage);
            await _userRepository.Update(_user.Id, _user);
        }

    }
}
