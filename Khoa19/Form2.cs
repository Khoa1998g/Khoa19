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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if(txtHeSoA.Text==""||txtHeSoB.Text==""||txtHeSoC.Text=="")
            {
                MessageBox.Show("Chưa nhập giá trị","Thông báo");
            }
            else
            {
                int heSoA = int.Parse(txtHeSoA.Text);
                int heSoB = int.Parse(txtHeSoB.Text);
                int heSoC = int.Parse(txtHeSoC.Text);
                //TinhDelta
                float delta = heSoB * heSoB - 4*heSoA * heSoC;
                if (delta < 0)
                {
                    txtKetQua.Text = "Phuơng trình vô nghiệm";
                }
                else if(delta == 0)
                {
                    txtKetQua.Text = "Phuơng trình có nghiệm kép \r\n x1=x2="+ -heSoB/(2*heSoA);
                }
                else //delta >0
                {
                    float x1 = (float)(-heSoB - Math.Sqrt(delta)) / (2 * heSoA);
                    float x2 = (float)(-heSoB + Math.Sqrt(delta)) / (2 * heSoA);
                    txtKetQua.Text = "Pt có 2 nghiệm \r\n x1 =" + x1 + "\r\n x2 =" + x2;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = txtHeSoB.Text = txtHeSoC.Text = txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
