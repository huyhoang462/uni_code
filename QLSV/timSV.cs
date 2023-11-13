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
    public partial class timSV : Form
    {
        public timSV()
        {
            InitializeComponent();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            kqtk.Rows.Clear();
            if (searchBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                SinhVien sv = new SinhVien();
                List<SinhVien> sv_list = new List<SinhVien>();
                sv_list = sv.readFileToList();
               
                for (int i = 0; i < sv_list.Count; i++)
                {
                    if (sv_list[i].MSSV == searchBox.Text || sv_list[i].ten.Contains(searchBox.Text))
                    {
                        
                        string[] kq = sv_list[i].infor().Split('_');
                        
                        kqtk.Rows.Add(kq);
                        
                    }

                    
                }
               
            }
        }

        private void timSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fr = Application.OpenForms;
            foreach (Form form in fr)
            {
                form.Show();
                return;
            }
        }
    }
}
