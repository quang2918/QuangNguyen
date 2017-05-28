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
        private void khachhang_load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = khc.getdt();
            dataGridView1.DataSource = dt;
            bingding();
        }
        void bingding()
        {
            txtMA.DataBindings.Clear();
            txtMA.DataBindings.Add("text", dataGridView1.DataSource, "makhachhang");
            txtTEN.DataBindings.Clear();
            txtTEN.DataBindings.Add("text", dataGridView1.DataSource, "tenkhachhang");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("text", dataGridView1.DataSource, "diachi");
            cbGT.DataBindings.Clear();
            cbGT.DataBindings.Add("text", dataGridView1.DataSource, "gioitinh");
            txtEMAIL.DataBindings.Clear();
           txtEMAIL.DataBindings.Add("text", dataGridView1.DataSource, "email");
            txSDT.DataBindings.Clear();
            txSDT.DataBindings.Add("text", dataGridView1.DataSource, "sdt");
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
            khachhang_load(sender, e);
        
        }

        private void btLUU_Click(object sender, EventArgs e)
        {
            DTgan(kho);
            if (flag == 0)
            {
                if (khc.adddt(kho))
                {
                    MessageBox.Show("Đã Thêm mới khách hàng! ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );

                }
                else
                {
                    MessageBox.Show(" Thêm mới thất bại! ", " Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else 
                    {
                if (khc.updatedt(kho))
                {
                    MessageBox.Show("Đã sửa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            khachhang_load(sender, e);
            // load dữ liệu ra ngoài

        }

        private void btHUY_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có thực sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                khachhang_load(sender, e);
                dis_en(false);
                this.Close();
            }
            else
                return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khachhang_load(sender, e);
        }
    }
}
