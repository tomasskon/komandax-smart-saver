﻿using System;
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
using System.Drawing.Imaging;


namespace SmartSaver.Forms.UserControls
{
    public partial class Main : UserControl
    {
        private User _user;
        public Main()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if(p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp;*.png)| *.jpg; *.jpeg; *.bmp; *.png" ;
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if(pictureBox1.Image != null)
            using (MemoryStream ms = new MemoryStream())
            {
                    Bitmap bmp = new Bitmap(imageIn);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
            }
            return null;
        }

        private async void SaveImageClick(object sender, EventArgs e)
        {
            var _userRepository = new UserRepository();
            var helper = new BalanceHelper(_userRepository);
            _user = await helper.GetUserBalance(userId: Domain.Constants.Constants.TestUserId);
            byte[] file_byte = ImageToByteArray(pictureBox1.Image);
            _user.UserImage = file_byte;
            await _userRepository.Update(_user.Id, _user);
            string text = "Image successfully saved!";
            MessageBox.Show(text);
        
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

        private void RefreshClick(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        public async void UpdateInfo()
        {
            var _userRepository = new UserRepository();
            var helper = new BalanceHelper(_userRepository);
            _user = await helper.GetUserBalance(userId: Domain.Constants.Constants.TestUserId);
            
#pragma warning disable CS0472 
            if (_user.Cash + _user.Card != null)
                textBox1.Text = (_user.Cash + _user.Card).FormatMoney();
            if(_user.UserImage != null)
                pictureBox1.Image = ByteArrayToImage(_user.UserImage);
            await _userRepository.Update(_user.Id, _user);
        }

    }
}
