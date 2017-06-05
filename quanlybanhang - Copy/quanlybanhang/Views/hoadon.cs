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
        DataTable dtCT = new DataTable();
        hanghoaC hhc = new hanghoaC();
        int click = 0;
        public hoadon()
        {
            InitializeComponent();
        }

        private void hoadon_Load_1(object sender, EventArgs e)
        {
            dis_en(false);
            DataTable dt = new DataTable();
            dt = hdc.getdt();
            dtgvhoadon.DataSource = dt;
            bingding();
            txtngay.Enabled = false;

        }
        void bingding()
        {
            txtmahoadon.DataBindings.Clear();
            txtmahoadon.DataBindings.Add("Text", dtgvhoadon.DataSource, "mahoadon");
            cbbmakhachhang.DataBindings.Clear();
            cbbmakhachhang.DataBindings.Add("Text", dtgvhoadon.DataSource, "tenkhachhang");
            cbmanhanvien.DataBindings.Clear();
            cbmanhanvien.DataBindings.Add("Text", dtgvhoadon.DataSource, "manhanvien");
            txtngay.DataBindings.Clear();
            txtngay.DataBindings.Add("Text", dtgvhoadon.DataSource, "ngaylap");
            // truy vấn lấy ra dữ liệu từ datasource
        }
        void dis_en(bool e)
        {
            txtmahoadon.Enabled = e;
            cbbmakhachhang.Enabled = e;
            cbmanhanvien.Enabled = e;
            btluu.Enabled = e;
            btthem.Enabled = !e;
            btin.Enabled = !e;
            btxoa.Enabled = !e;
            bthuy.Enabled = e;
            btcham.Enabled = e;

        }
        void GanDT(hoadonO hdo)

        {
            // gán giá trị nhập vào biến 
            hdo.Mahd = txtmahoadon.Text.Trim();
            // Trim để loại bỏ cá khoảng trắng ở đầu và cuối text, để lại các khoảng trống giữa các từ
            hdo.Makh = cbbmakhachhang.SelectedValue.ToString();
            hdo.Manv = cbmanhanvien.SelectedValue.ToString();
            hdo.Ngaylap = txtngay.Text.Trim();
        }
        private void bingding1()
        {
            // Hàm hiển thị text lên các box
            // nếu báo lỗi cannot bind là datasource sai , kiểm tra lại câu query
            cbbtenhang.DataBindings.Clear();
            cbbtenhang.DataBindings.Add("Text", dtgvchitiet.DataSource, "tenhang");
            txtsoluong.DataBindings.Clear();
            txtsoluong.DataBindings.Add("Text", dtgvchitiet.DataSource, "soluongban");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dtgvchitiet.DataSource, "dongiaban");
            lbtien.DataBindings.Clear();
            lbtien.DataBindings.Add("Text", dtgvchitiet.DataSource, "thanhtien");
        }
        void Clear()
        {
            txtmahoadon.Text = " ";
            txtngay.Text = DateTime.Now.Date.ToShortDateString();
            Loadcbb_khachhang();
            Loadcbb_nhanvien();
        }
        void Loadcbb_khachhang()
        {
            // load dữ liệu lên combobox
            khachhangC khc = new khachhangC();
            cbbmakhachhang.DataSource = khc.getdt();
            cbbmakhachhang.DisplayMember = "Tenkhachhang";
            cbbmakhachhang.ValueMember = "Makhachhang";
        }
        void Loadcbb_hanghoa()
        {
            hanghoaC hhc = new hanghoaC();
            cbbmakhachhang.DataSource = hhc.getdt();
            cbbtenhang.DisplayMember = "Tenhanghoa";
            cbbtenhang.ValueMember = "Mahanghoa";

        }
        void Loadcbb_nhanvien()
        {
            nhanvienC khc = new nhanvienC();
            cbmanhanvien.DataSource = khc.getdt();
            cbmanhanvien.DisplayMember = "manhanvien";
            cbmanhanvien.ValueMember = "manhanvien";
        }
        private void textchange(object sender, EventArgs e)
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
            cbbtenhang.SelectedIndex = 0;
            dtCT.Rows.Clear();
            dtCT.Rows.Add("mahoadon");
            dtCT.Rows.Add("tenhang");
            dtCT.Rows.Add("soluongban");
            dtCT.Rows.Add("dongiaban");
            dtCT.Rows.Add("thanhtien");
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có muốn hủy thao tác? ", "Câu hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                dis_en(true);
            hoadon_Load_1(sender, e);
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
            hoadon_Load_1(sender, e);
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
            hoadon_Load_1(sender, e);
        }

        private void btcham_Click(object sender, EventArgs e)
        {
            txtngay.Enabled = true;


        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmahoadon.Text))
            {
                DataRow dr = dtCT.NewRow();
                dr[0] = txtmahoadon.Text.Trim();
                dr[1] = cbbtenhang.SelectedValue.ToString();
                dr[2] = txtngay.Text.Trim();
                dr[3] = txtdongia.Text.Trim();
                dr[4] = (double.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text)).ToString();
                dtCT.Rows.Add(dr);
                dtgvchitiet.DataSource = dtCT;
                // txtsoluong.Text = "1";

            }
            else
            {
                MessageBox.Show("Mã hóa đơn rỗng, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmahoadon.Focus();
            }
        }

        private void Textchange_SL(object sender, EventArgs e)
        {
            // lbtien.Text = (double.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text)).ToString();

        }

        private void cbbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = hhc.getdt("where mahang= '" + cbbtenhang.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double giaban = double.Parse(dt.Rows[0][2].ToString());
                txtdongia.Text = (giaban * 1.1).ToString();
                lbtien.Text = (double.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text)).ToString();

            }

        }

        private void dtgvchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = e.RowIndex;

        }

        private void btxoa2_Click(object sender, EventArgs e)
        {
            dtCT.Rows.RemoveAt(click);
            dtgvchitiet.DataSource = dtCT;

        }
        private bool check(string mahh)
        {
            for (int i = 0; i < dtCT.Rows.Count; i++)
            {
                if (dtCT.Rows[i][1].ToString() == mahh)
                    return true;

            }
            return false;

        }
        private void thembotSL(string mahh, int sl)
        {
            for( int i = 0; i<dtCT.Rows.Count; i++)
            {
                if ( dtCT.Rows[i][1]== mahh)
                {
                    int soluong = int.Parse((dtCT.Rows[i][4]).ToString()) + sl;
                    dtCT.Rows[i][4] = soluong;
                    double dongia = double.Parse((dtCT.Rows[i][3]).ToString());
                    dtCT.Rows[i][5] = (dongia * soluong).ToString();
                    break;

                }
            }
        }
        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhc.getdt("Where mahang = '" + cbbtenhang.SelectedValue.ToString() + "' and soluongban>= " + sl);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
                
            return false;
        }
 }
}


