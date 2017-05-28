using System;
using System.Data;
using System.Windows.Forms;
using quanlybanhang.Objects;
using quanlybanhang.Controllers;

namespace quanlybanhang.Views
{
    public partial class hanghoa : Form
    {
        int flag = 0;
        hanghoaO hho = new hanghoaO();
        // nvo là biến lưu giá trị tạm thời 
        hanghoaC hhc = new hanghoaC();
        public hanghoa()
        {
            InitializeComponent();

            
        }
      

        private void hanghoa_Load(object sender, EventArgs e)
        {
            DataTable dthh = new DataTable();
            dthh = hhc.getdt();
            dataGridView1.DataSource = dthh;
            bingding();
            dis_en(false);
        }
        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dataGridView1.DataSource, "mahang");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dataGridView1.DataSource, "tenhang");
            numUD.DataBindings.Clear();
            numUD.DataBindings.Add("text", dataGridView1.DataSource, "soluong");
            txtdongia.DataBindings.Clear();
            txtdongia.DataBindings.Add("Text", dataGridView1.DataSource, "dongia");
           
            
        }
        void dis_en(bool e)
        {
            txtma.Enabled = e;
            txtten.Enabled = e;
            numUD.Enabled = e;
            txtdongia.Enabled = e;
            
            //
            btthem.Enabled = e;
            btsua.Enabled = e;
           btxoa.Enabled = e;
            btluu.Enabled = e;
          

         

        }
        void Clear()
        {
            // clear dữ liệu hiển thị
            txtma.Text = " ";
            txtten.Text = " ";
            numUD.Text = " ";
            txtdongia.Text = " ";
         


        }
        void Gandt(hanghoaO hho)
        {

            hho.Mahh = txtma.Text.Trim();
            hho.Tenhh = txtten.Text.Trim();
            hho.Soluong = numUD.Text.Trim();

            hho.Dongia = txtdongia.Text.Trim();


        }
        private void txtma_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;

            dis_en(true);
           // Clear();

           
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn đồng ý xóa dữ liệu? ", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            dis_en(true);
            if (dr == DialogResult.Yes)
            {
                if (hhc.deletedt(txtma.Text.Trim()))
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
            hanghoa_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            hanghoaO hho = new hanghoaO();
            
            Gandt(hho);
            if (flag == 0)
            {
                if (hhc.adddt(hho))
                {
                    MessageBox.Show(" Đã thêm mới nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show(" Thêm mới thất bại! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (hhc.updatedt(hho))
                {
                    MessageBox.Show(" Đã sửa thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Nhiệm vụ chưa hoàn thành! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            hanghoa_Load(sender, e);
        }
    }
}
