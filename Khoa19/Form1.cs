﻿using System.Security.Cryptography;

namespace Khoa19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if(txtSoThuNhat.Text == ""||txtSoThuHai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
            else
            {
                int soThuNhat = int.Parse(txtSoThuNhat.Text);
                int soThuHai = int.Parse(txtSoThuHai.Text);
                int ketQua = soThuNhat + soThuHai;
                txtKetQua.Text = ketQua.ToString();
            }         
        }

        private void btnTru_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSoThuNhat.Text == "" || txtSoThuHai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
            else
            {
                int soThuNhat = int.Parse(txtSoThuNhat.Text);
                int soThuHai = int.Parse(txtSoThuHai.Text);
                int ketQua = soThuNhat - soThuHai;
                txtKetQua.Text = ketQua.ToString();
            }
        }

        private void btnNhan_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSoThuNhat.Text == "" || txtSoThuHai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
            else
            {
                int soThuNhat = int.Parse(txtSoThuNhat.Text);
                int soThuHai = int.Parse(txtSoThuHai.Text);
                int ketQua = soThuNhat * soThuHai;
                txtKetQua.Text = ketQua.ToString();
            }
        }

        private void btnChia_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSoThuNhat.Text == "" || txtSoThuHai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
            else
            {
                float soThuNhat = float.Parse(txtSoThuNhat.Text);
                float soThuHai = float.Parse(txtSoThuHai.Text);
                if(soThuHai == 0)
                {
                    MessageBox.Show("Mẫu phải khác 0");
                }
                else
                {
                    float ketQua = soThuNhat/ soThuHai;
                    txtKetQua.Text = ketQua.ToString();
                }
                
            }
        }

        private void txtSoThuNhat_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider1.SetError(control, "Nhập sai format");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txtSoThuHai_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider2.SetError(control, "Nhập sai format");
            }
            else
            {
                this.errorProvider2.Clear();
            }
        }
    }
}