﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace VD
{
    public partial class Form2 : Form
    {
       
       
        public bool isClosed = false;
        public Form2()
        {

            InitializeComponent();
            Form1 f1=new Form1();
            f1.ShowDialog();
            
        }
        
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhapSV f3 = new nhapSV();
            f3.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            timSV f4 = new timSV();
            f4.Show();
            
           
        }

       
    }
}
