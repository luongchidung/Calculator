using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        float data1, data2;
        string pheptinh;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number0_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void cham_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + ".";
        }

        private void C_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
        }

        private void bang_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " + " + float.Parse(hienthi1.Text) +  " = ";
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " - " + float.Parse(hienthi1.Text) + "=";
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + " * " + float.Parse(hienthi1.Text) + "=";
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "chia")
            {
                if (float.Parse(hienthi1.Text) == 0)
                {
                    hienthi1.Text = "Lỗi";
                }
                else
                {
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = data1.ToString() + " ÷ " + float.Parse(hienthi1.Text) + "=";
                    hienthi1.Text = data2.ToString();
                }
            }
        }

        private void tru_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1= float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }
    }

}
