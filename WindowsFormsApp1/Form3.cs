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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            for (int i = 0; i < 9999; i++)
            {
                MessageBox.Show("Đăng ký thành công");
                
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Email: ";
            label2.Text = "Tên tài khoản";
            label3.Text = "Mật khẩu";
            label4.Text = "Nhập lại mật khẩu";
            button1.Text = "Đăng ký";

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
