using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlybanhang.Controllers;
using quanlybanhang.Models;
using quanlybanhang.Objects;
using System.Data.SqlClient;
namespace quanlybanhang.Views
{
    public partial class hoadon : Form
    {
        hoadonC hdc = new hoadonC();
        hoadonM hdm = new hoadonM();
        hoadonO hdo = new hoadonO();
        chitiethdC ctc = new chitiethdC();
        public hoadon()
        {
            InitializeComponent();
        }
        public void hoadon_load(object sender, EventArgs e)
        {
            dis_en(false);
            DataTable dt = new DataTable();
            dt = hdc.getdt();
            dtgvhoadon.DataSource = dt;
            bingding();
            txtngay.Enabled =false;



        }
        void bingding()
        {
            txtmahoadon.DataBindings.Clear();
            txtmahoadon.DataBindings.Add("Text",dtgvhoadon.DataSource,"mahoadon");
            cbbmakhachhang.DataBindings.Clear();
            cbbmakhachhang.DataBindings.Add("Text",dtgvhoadon.DataSource,"makhachhang");
            txtmanhanvien.DataBindings.Clear();
            txtmanhanvien.DataBindings.Add("text",dtgvhoadon.DataSource,"manhanvien");
            txtngay.DataBindings.Clear();
            txtngay.DataBindings.Add("Text", dtgvhoadon.DataSource,"ngaysinh");
           
        }
        void dis_en(bool e )
        {
            txtmahoadon.Enabled = e;
            cbbmakhachhang.Enabled = e;
            txtmanhanvien.Enabled = e;
            btluu.Enabled = e;
            btthem.Enabled = !e;
            btin.Enabled = !e;
            btxoa.Enabled = !e;
            bthuy.Enabled = e;
            btcham.Enabled = e;
            
        }
        void GanDT(hoadonO hdo)

        {

            hdo.Mahd = txtmahoadon.Text.Trim();
            hdo.Makh = cbbmakhachhang.SelectedValue.ToString();
            hdo.Manv = txtmanhanvien.Text.Trim();
            hdo.Ngaylap = txtngay.Text.Trim();
        }
        public void bingding1()
        {
            cbbmahanghoa.DataBindings.Clear();
            cbbmahanghoa.DataBindings.Add("Text", dtgvchitiet.DataSource, "mahanghoa");
            txttenhang.DataBindings.Clear();
            txttenhang.DataBindings.Add("Text", dtgvchitiet.DataSource, "tenhanghoa");
            txtdg.DataBindings.Clear();
            txtdg.DataBindings.Add("text", dtgvchitiet.DataSource, "dongiaban");
            numUD.DataBindings.Clear();
            numUD.DataBindings.Add("Text", dtgvchitiet.DataSource, "soluongban");

        }
        void Clear()
        {
            txtmahoadon.Text = " " ;
            txtmanhanvien.Text = " ";
           
            txtngay.Text = DateTime.Now.Date.ToShortDateString();
            Loadcbb_khachhang();
        }
        void Loadcbb_khachhang()
        {
            khachhangC khc = new khachhangC();
            cbbmakhachhang.DataSource = khc.getdt();
            cbbmakhachhang.DisplayMember = "Tenkhachhang";
            cbbmakhachhang.ValueMember = "Makhachhang";
        }
        void Loadcbb_hanghoa()
        {
            hanghoaC hhc = new hanghoaC();
            cbbmakhachhang.DataSource = hhc.getdt();
            cbbmahanghoa.DisplayMember = "Tenhanghoa";
            cbbmahanghoa.ValueMember = "Mahanghoa";
        
    }

       private void txtma_change(object sender, EventArgs e)
        {
            try
            {
                DataTable dt1 = new DataTable();
                dt1 = ctc.getdt(txtmahoadon.Text.Trim());
                dtgvchitiet.DataSource = dt1;
                

            }
            catch
            {
                dtgvchitiet.DataSource = null;
            }
            bingding1();
        }

        private void Datasourcechange(object sender, EventArgs e)
        {
            bingding1();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Clear();
            dis_en(true);
            
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show(" Bạn có muốn hủy thao tác? ", "Câu hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                dis_en(true);
            hoadon_load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn đồng ý xóa dữ liệu? ", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            dis_en(true);
            if (dr == DialogResult.Yes)
            {
                if (hdc.deletedt(txtmahoadon.Text.Trim()))
                {
                    MessageBox.Show(" Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Xóa thất bại! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            hoadon_load(sender, e);
        }

        private void btin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" đang nâng cấp!");
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            hoadonO hdo = new hoadonO();
            GanDT(hdo);
            if (hdc.adddt(hdo))
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dtgvchitiet.DataSource;
                if (ctc.adddt(dt))
                {


                    MessageBox.Show(" Đã thêm mới hóa đơn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(" Thêm mới chi tiết hóa đơn thất bại! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" Thêm mới hóa đơn thất bại! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hoadon_load(sender, e);
        }

        private void btcham_Click(object sender, EventArgs e)
        {
            txtngay.Enabled = true;


        }
    }

}
