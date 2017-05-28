using System;
using System.Data;
using System.Windows.Forms;
using quanlybanhang.Controllers;
using quanlybanhang.Models;
using quanlybanhang.Objects;

namespace quanlybanhang.Views
{
    public partial class Nhanvien : Form
    {
        int flag = 0;
        nhanvienC nvc = new nhanvienC();
        nhanvienM nvm = new nhanvienM();
        nhanvienO nvo = new nhanvienO();
        
        public Nhanvien()
        {
            
            InitializeComponent();
        }
        private void nhanvien_load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nvc.getdt();
            dtgvnhanvien.DataSource = dt;
           
            bingding();
           

        }
        void dis_en(bool e)
        {
            txtmanhanvien.Enabled = e;
            txttennhanvien.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            txtmk.Enabled = e;
            bt1.Enabled = !e;
            bt2.Enabled = !e;
            bt3.Enabled = !e;
            bt4.Enabled = e;
            bt7.Enabled = e;
        }
        void dis_en1(bool e)
        {
            txtmanhanvien.Enabled = e;
            txttennhanvien.Enabled = e;
            txtdiachi.Enabled = e;
            txtsdt.Enabled = e;
            txtmk.Enabled = e;
            bt1.Enabled = e;
            bt2.Enabled = e;
            bt3.Enabled = e;
            bt4.Enabled = !e;
            bt7.Enabled = !e;
        }
        void gandt(nhanvienO nvo)
        {
            
            nvo.Manv = txtmanhanvien.Text.Trim();
            nvo.Tennv = txttennhanvien.Text.Trim();
            nvo.Sdt = txtsdt.Text.Trim();
            nvo.Diachi = txtdiachi.Text.Trim();
            nvo.Matkhau = txtmk.Text.Trim();
            nvo.Gioitinh = cb1.Text.Trim();
        }
        void bingding()
        {
            txtmanhanvien.DataBindings.Clear();
            txtmanhanvien.DataBindings.Add("text", dtgvnhanvien.DataSource , "manhanvien");
            txttennhanvien.DataBindings.Clear();
            txttennhanvien.DataBindings.Add("text", dtgvnhanvien.DataSource , "tennhanvien");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("text", dtgvnhanvien.DataSource , "diachi");
            cb1.DataBindings.Clear();
            cb1.DataBindings.Add("text", dtgvnhanvien.DataSource , "gioitinh");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("text", dtgvnhanvien.DataSource , "sdt");
            txtmk.DataBindings.Clear();
           txtmk.DataBindings.Add("text", dtgvnhanvien.DataSource , "matkhau");
        }
        void Loadcontrol()
        {
            cb1.Items.Add("Nam");
            cb1.Items.Add("Nữ");
        }
      
        void Clear()
        {
            // clear dữ liệu hiển thị
            txtmanhanvien.Text = " ";
            txttennhanvien.Text = " ";
            txtdiachi.Text = " ";
            txtmk.Text = " ";
            txtsdt.Text = "";
        }
        
        private void bt1_Click(object sender, EventArgs e)
        {
            flag = 0;
            // Clear();
           // nhanvien_load(sender, e);
            dis_en(true);
            Loadcontrol();
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            nhanvien_load(sender, e);
            flag = 1;
            // biến đại diện cho từng hàm
           // dis_en(true);
            // hiển thị thông tin trên text
            Loadcontrol();
            // mở tùy chọn giơi tính 
          
        }
        private void bt3_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(" Bạn có chắc muốn xóa nhienvien? ", "Make sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            dis_en(true);
            if (dr == DialogResult.Yes)
            {
                if (nvc.deletedt(txtmanhanvien.Text.Trim()))
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
            nhanvien_load(sender, e);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            gandt(nvo);
            if (flag == 0)
            {
                if (nvc.adddt(nvo))
                {
                    MessageBox.Show("Đã Thêm mới khách hàng! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(" Thêm mới thất bại! ", " Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (nvc.updatedt(nvo))
                {
                    MessageBox.Show("Đã sửa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            nhanvien_load(sender, e);
            // load dữ liệu ra ngoài
        }

        private void bt7_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(" Bạn có thực sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               // nhanvien_load(sender, e);
              //  dis_en(false);
                this.Close();
            }
            else
            {

               // dis_en(true);
            }
                return;
        }




    }

}
