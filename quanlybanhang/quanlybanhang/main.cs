using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlybanhang.Views;
using quanlybanhang.Controllers;


namespace quanlybanhang
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang();
            kh.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadon hd = new hoadon();
            hd.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang();
            kh.ShowDialog();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ShowDialog();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
        }

        }
}
