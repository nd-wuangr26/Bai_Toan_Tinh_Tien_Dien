using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int N = (int)numericUpDown1.Value;

            lib_TinhTienDien.cls_TienDien tg = new lib_TinhTienDien.cls_TienDien();
            tg.N = N;
            tg.TinhTienDien();

            double TienPhaiTra = tg.tiendien;
            label_kq.Text=TienPhaiTra + " đồng";
        }
    }
}
