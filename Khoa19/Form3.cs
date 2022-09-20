using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khoa19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static int kiemTraNguyenTo(int n)
        {
            if (n < 2)
                return -1;
            if (n == 2 || n == 3)
                return 1;
            if (n % 2 == 0)
                return -1;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return -1;
            }
            return 1;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int soDau = int.Parse(txtSoDau.Text);
            int soCuoi = int.Parse(txtSoCuoi.Text);
            int tongDay = 0;
            int tongChan = 0;
            int tongNT = 0;
            for(int i= soDau; i <= soCuoi; i++)
            {
                tongDay += i;
                if (i % 2 == 0)
                {
                    tongChan += i;
                }
                if (kiemTraNguyenTo(i) == 1)
                {
                    tongNT += i;
                }
                //int demuoc = 0;
                //if (i <= 1)
                //{
                //    continue;
                //}
                //for (int j = 1; j <= i; j++)
                //{
                //    if (i % j == 0)
                //    {
                //        demuoc++;
                //    }
                //}
                //if (demuoc == 2)
                //{
                //    tongnt += i;
                //}
            }
            txtTongDay.Text = tongDay.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongNT.Text = tongNT.ToString();
        }
    }
}
