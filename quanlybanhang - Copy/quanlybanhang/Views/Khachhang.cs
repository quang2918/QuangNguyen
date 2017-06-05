using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using quanlybanhang.Objects;
using quanlybanhang.Models;
using quanlybanhang.Controllers;

namespace quanlybanhang.Views
{
    public partial class Khachhang : Form
    {
        int flag = 0;
        khachhangC khc = new khachhangC();
        khachhangO kho = new khachhangO();
        // khai báo 2 đối tượng từ 2 lơp 
      
        private void Khachhang_Load_1(object sender, EventArgs e)
        {
            // phần hiển thị dữ liệu lấy ra 
            dis_en(false);
            DataTable dt = new DataTable();
            dt = khc.getdt();
            dtgvkh.DataSource = dt;
            bingding();
        }
        void bingding()
        {
            txtMA.DataBindings.Clear();
            txtMA.DataBindings.Add("Text", dtgvkh.DataSource, "makhachhang");
            // chữ trong " " phải viết đúng hoa - thường
            txtTEN.DataBindings.Clear();
            txtTEN.DataBindings.Add("Text", dtgvkh.DataSource, "tenkhachhang");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", dtgvkh.DataSource, "diachi");
            cbGT.DataBindings.Clear();
            cbGT.DataBindings.Add("Text", dtgvkh.DataSource, "gioitinh");
            txtEMAIL.DataBindings.Clear();
           txtEMAIL.DataBindings.Add("Text", dtgvkh.DataSource, "email");
            txSDT.DataBindings.Clear();
            txSDT.DataBindings.Add("Text", dtgvkh.DataSource, "sdt");
        }
        void dis_en( bool e)
        {
            // phần hiển thị sau ấn nút
            txtMA.Enabled = e;
            txtTEN.Enabled = e;
            txtEMAIL.Enabled =e;
            txSDT.Enabled = e;
            txtDC.Enabled = e;
            cbGT.Enabled = e;
            btTHEM.Enabled = !e;
            btSUA.Enabled = !e;
            btXOA.Enabled = !e;
            btLUU.Enabled = e;
            btHUY.Enabled = e;
            


        }
        public Khachhang()
        {
            
            InitializeComponent();
        }

        void DTgan(khachhangO kho)
        {
            kho.Makh = txtMA.Text.Trim();
            kho.Tenkh = txtTEN.Text.Trim();
            kho.Sdt = txSDT.Text.Trim();
            kho.Gioitinh = cbGT.Text.Trim();
            kho.Diachi = txtDC.Text.Trim();
            kho.Email = txtEMAIL.Text.Trim();
        }
        void Loadcontrol()
        {
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nữ");
        }
        private void btTHEM_Click(object sender, EventArgs e)
        {
            flag = 0;
            // Clear();
           
            dis_en(true);
            Loadcontrol();
        }
        void Clear()
        {
            // clear dữ liệu hiển thị
            txtMA.Text = " ";
            txtTEN.Text = " ";
            txtDC.Text = " ";
            txtEMAIL.Text = " ";
            txSDT.Text = "";
             }

        private void btSUA_Click(object sender, EventArgs e)
        {
            flag = 1;
            // biến đại diện cho từng hàm
            dis_en(true);
            // hiển thị thông tin trên text
            Loadcontrol();
            // mở tùy chọn giơi tính 
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có chắc muốn xóa khách hàng? " ,"Make sure?" , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            dis_en(true);
            if (dr==DialogResult.Yes)
            {
                if (khc.deletedt(txtMA.Text.Trim()))
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
            Khachhang_Load_1(sender, e);
        
        }

        private void btLUU_Click(object sender, EventArgs e)
        {
            DTgan(kho);
            if (flag == 0)
            {
                if (khc.adddt(kho))
                {
                    MessageBox.Show("Đã Thêm mới khách hàng! ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    dis_en(true);
                }
                else
                {
                    MessageBox.Show(" Thêm mới thất bại! ", " Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dis_en(false);
                }
            }
            else 
                    {
                if (khc.updatedt(kho))
                {
                    MessageBox.Show("Đã sửa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dis_en(true);
                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dis_en(false);
                }
            }
            Khachhang_Load_1(sender, e);
            // load dữ liệu ra ngoài

        }

        private void btHUY_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có thực sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Khachhang_Load_1(sender, e);
                dis_en(false);
                this.Close();
            }
            else
                return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Khachhang_Load_1(sender, e);
        }

        
    }
}
