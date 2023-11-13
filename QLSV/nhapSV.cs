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
    public partial class nhapSV : Form
    {
        
        public nhapSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (msBox.Text==""||maLop.Text==""|| nameBox.Text==""|| dtoanBox.Text==""||  dvanBox.Text==""|| danhBox.Text=="")
            { 
                MessageBox.Show("Vui lòng điền hết thông tin","Notice");
            }
            else if (!int.TryParse(msBox.Text,out int r))
            {
                MessageBox.Show("MSSV không hợp lệ","Notice");
            }
            else if(!double.TryParse(dtoanBox.Text,out double dt)){
                MessageBox.Show("Điểm toán không hợp lệ");
            }
            else if (!double.TryParse(dvanBox.Text, out double dv))
            {
                MessageBox.Show("Điểm văn không hợp lệ");
            }
            else if (!double.TryParse(danhBox.Text, out double da))
            {
                MessageBox.Show("Điểm anh không hợp lệ");
            }
            else if(double.Parse(dtoanBox.Text)<0|| double.Parse(dtoanBox.Text) > 10)
            {
                MessageBox.Show("Điểm toán không hợp lệ");
            }
            else if (double.Parse(dvanBox.Text) < 0 || double.Parse(dvanBox.Text) > 10)
            {
                MessageBox.Show("Điểm văn không hợp lệ");
            }
            else if (double.Parse(danhBox.Text) < 0 || double.Parse(danhBox.Text) > 10)
            {
                MessageBox.Show("Điểm Anh không hợp lệ");
            }
            else {
                SinhVien sv = new SinhVien();
                string[] ds = new string[7];
                ds[0] = "add";
                ds[1] = msBox.Text;
                ds[2] = nameBox.Text;
                ds[3] = maLop.Text;
                
                ds[4] = dtoanBox.Text;
                ds[5] = dvanBox.Text;
                ds[6] = danhBox.Text;
                sv.add(ds);
                MessageBox.Show("Da luu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             msBox.Text="";
             nameBox.Text="";
            maLop.Text="";
            dtoanBox.Text="";
             dvanBox.Text="";
            danhBox.Text="";
        }
        
       

        private void nhapSV_Enter(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void nhapSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fr = Application.OpenForms;
            foreach(Form form in fr)
            {
                form.Show();
                return;
            }

        }
    }
}
