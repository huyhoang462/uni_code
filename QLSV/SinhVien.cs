using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Collections;
using Microsoft.SqlServer.Server;
using System.Runtime.CompilerServices;

namespace VD
{
    public class SinhVien
    {
        public string ten;
        public int STT;
        public string malop;
        public string MSSV;
        public double dT, dA, dV, dTB;
        public SinhVien() { }
        public void add(string[] a)
        {
            if (!File.Exists("sinhvien.txt"))
                File.WriteAllText("sinhvien.txt", "");
            this.STT = soSV() + 1;
            this.MSSV = a[1];
            for (int i = 2; i <= a.Length - 6; i++)
            {
                this.ten += a[i]+" ";
            }
            this.ten += a[a.Length - 5];
            this.malop = a[a.Length-4];
            this.dT = double.Parse(a[a.Length-3]);
            this.dV = double.Parse(a[a.Length-2]);
            this.dA = double.Parse(a[a.Length-1]);
            this.dTB = Math.Round((dT + dV + dA) / 3, 2);
            this.writeInforToFile();
        }
        public void addFromFile(string[] a)
        {
            this.STT = int.Parse(a[0]);
            this.malop = a[1];
            this.MSSV = a[2];
            for (int i = 3; i <= a.Length - 6; i++)
            {
                this.ten += a[i]+" ";
            }
            this.ten += a[a.Length - 5];
            this.dT = double.Parse(a[a.Length-4]);
            this.dV = double.Parse(a[a.Length-3]);
            this.dA = double.Parse(a[a.Length-2]);
            this.dTB = double.Parse(a[a.Length-1]);
        }

        public string infor()
        {
            return STT + "_" + malop + "_" + MSSV + "_" + ten + "_" + dT + "_" + dV + "_" + dA + "_"+ dTB+"\n";
        }
        public void writeInforToFile()
        {
            File.AppendAllText("sinhvien.txt", STT + " " + malop + " " + MSSV + " " + ten + " " + dT + " " + dV + " " + dA + " " + dTB + "\n");
        }
        public int soSV()
        {
            return File.ReadAllLines("sinhvien.txt").Length;
        }
        public void readInfor()
        {
            Console.WriteLine(File.ReadAllText("sinhvien.txt"));
        }
        public void search(string s1, string s2)
        {
            List<SinhVien> sv_list = new List<SinhVien>();
            sv_list = readFileToList();
            for (int i = 0; i < sv_list.Count; i++)
            {
                if ((sv_list[i].MSSV == s1 && sv_list[i].ten == s2) || (sv_list[i].MSSV == s2 && sv_list[i].ten == s1))
                    sv_list[i].infor();
            }

        }
        public void search(string s)
        {
            List<SinhVien> sv_list = new List<SinhVien>();
            sv_list = readFileToList();
            for (int i = 0; i < sv_list.Count; i++)
            {
                if (sv_list[i].MSSV == s || sv_list[i].ten == s)
                    sv_list[i].infor();
            }

        }
        public void remove(string s)
        {
            List<SinhVien> sv_list = new List<SinhVien>();
            sv_list = readFileToList();
            for (int i = 0; i < sv_list.Count; i++)
            {
                if (sv_list[i].MSSV == s)
                {
                    sv_list.RemoveAt(i);
                    break;
                }
            }
            writeListToFile(sv_list);
        }
        public List<SinhVien> readFileToList()
        {
            List<SinhVien> sv_list = new List<SinhVien>();
            string[] s = File.ReadAllLines("sinhvien.txt");
            for (int i = 0; i < s.Length; i++)
            {
                string[] sv_arr = s[i].Split(' ');
                SinhVien sv_add = new SinhVien();
                sv_add.addFromFile(sv_arr);
                sv_list.Add(sv_add);
            }
            return sv_list;
        }
        public void writeListToFile(List<SinhVien> sv)
        {
            File.WriteAllText("sinhvien.txt", "");
            for (int i = 0; i < sv.Count; i++)
            {
                sv[i].STT = i + 1;
                sv[i].writeInforToFile();
            }
        }
        public void topN(int n, string b)
        {
            int tongsv = soSV();
            if (n > tongsv) n = tongsv;
            List<SinhVien> sv_list = new List<SinhVien>();
            sv_list = readFileToList();
            SortedList diem = new SortedList();
            for (int i = 0; i < tongsv; i++)
            {
                diem.Add(sv_list[i].STT, sv_list[i].dTB);
            }
            List<double> tb = new List<double>();
            for (int i = 0; i < tongsv; i++)
            {
                tb.Add(sv_list[i].dTB);
            }
            tb.Sort();
            int dain = 0;
            if (b == "true")
            {

                for (int i = 0; i < n; i++)
                {
                    while ((i < tongsv - 1) && (tb[tongsv - i - 1] == tb[tongsv - i - 2]))
                    {
                        i++;
                    }
                    for (int j = 0; j < tongsv; j++)
                    {
                        if (tb[tongsv - 1 - i] == sv_list[j].dTB)
                        {
                            Console.WriteLine(sv_list[j].STT + " " + sv_list[j].malop + " " + sv_list[j].MSSV + " " + sv_list[j].ten + " " + sv_list[j].dTB);
                            dain++;
                        }
                    }
                    if (dain > n) break;

                }
            }
            else if (b == "false")
            {
                for (int i = 0; i < n; i++)
                {
                    while ((i < tongsv - 1) && (tb[i] == tb[i + 1]))
                    {
                        i++;
                    }
                    for (int j = 0; j < tongsv; j++)
                    {
                        if (tb[i] == sv_list[j].dTB)
                        {
                            Console.WriteLine(sv_list[j].STT + " " + sv_list[j].malop + " " + sv_list[j].MSSV + " " + sv_list[j].ten + " " + sv_list[j].dTB);
                            dain++;
                        }
                    }
                    if (dain > n) break;
                }
            }
        }
        public void export(string a, string path)
        {
            if (a == "all" || a == "All" || a == "ALL")
            {
                File.WriteAllText(@path, File.ReadAllText("sinhvien.txt"));
            }
            else
            {
                List<SinhVien> sv_list = new List<SinhVien>();
                sv_list = readFileToList();
                File.WriteAllText(@path, "");
                for (int i = 0; i < sv_list.Count; i++)
                {
                    if (sv_list[i].malop == a)
                        File.AppendAllText(path, sv_list[i].STT + " " + sv_list[i].malop + " " + sv_list[i].MSSV + " " + sv_list[i].ten + " " + sv_list[i].dT + " " + sv_list[i].dV + " " + sv_list[i].dA + " " + sv_list[i].dTB + "\n");
                }
            }
        }

    }
}
