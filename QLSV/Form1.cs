using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        bool isLog = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập");
            }
            else if (textBox1.Text == "admin"&& (textBox2.Text == "123456"))
            {
                isLog = true;
                this.Close();
          
            }
            else MessageBox.Show("Incorrect");
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isLog) { Application.Exit(); }
        }
    }
}
