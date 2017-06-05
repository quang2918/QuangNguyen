using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quanlybanhang.Objects;
namespace quanlybanhang.Models
{
    class chitiethdM
    {
        ConnectSQL conn = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        //  SqlConnection con = new SqlConnection();
        public DataTable Getdata(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select ct.mahoadon, hh.tenhang, ct.dongiaban, ct.soluongban, ct.dongiaban*ct.soluongban thanhtien  from dbo.chitiethoadon ct, dbo.hanghoa hh where ct.mahanghoa = hh.mahang and mahoadon = '" +ma+"'";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = conn.Con;
            try
            {
                conn.opencon();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                // adapter mở cmd lấy dữ liệu về cho hàm getdata
                conn.closecon();


            }
            catch (Exception ex)
            // nếu xảy ra lỗi thì
            {
                string mex = ex.Message;
                cmd.Dispose();
                //xóa bỏ và kết thúc phiên làm việc với cmd
                conn.closecon();

            }
            return dt;

        }
        public bool AddDT(DataTable dt)
        {
           
            try
            {
              /*  conn.opencon();
                cmd.ExecuteNonQuery();
                // adapter mở cmd lấy dữ liệu về cho hàm getdata
                conn.closecon();*/
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    cmd.CommandText = " Insert into dbo.chitiethoadon values ('" + dt.Rows[i][0].ToString() + "', N'" + dt.Rows[i][1].ToString() + "', N'" + dt.Rows[i][2].ToString() + "',N'" + dt.Rows[i][3].ToString() + "')";
                    cmd.CommandType = CommandType.Text;

                    cmd.Connection = conn.Con;
                }
                return true;
            }
            catch (Exception ex)
            // nếu xảy ra lỗi thì
            {
                string mex = ex.Message;
                cmd.Dispose();
                //xóa bỏ và kết thúc phiên làm việc với cmd
                conn.closecon();

            }
            return false;
        }
      /* public bool UpdateDT(chitiethd cto)
        {
            cmd.CommandText = " Update  chitiet set tennhanvien= '" + cto.Tennv + "',  ngaysinh=Convert(date,'" + nvo.Ngaysinh + "',103),  gioitinh= '" + nvo.Gioitinh + "', sdt='" + nvo.Sdt + "', diachi='" + nvo.Diachi + "', matkhau='" + nvo.Matkhau + "', where manhanvien='" + nvo.Manv + "'";
            cmd.CommandType = CommandType.Text;

            cmd.Connection = conn.Con;
            try
            {
                conn.opencon();
                cmd.ExecuteNonQuery();
                // adapter mở cmd lấy dữ liệu về cho hàm getdata
                conn.closecon();
                return true;
            }
            catch (Exception ex)
            // nếu xảy ra lỗi thì
            {
                string mex = ex.Message;
                cmd.Dispose();
                //xóa bỏ và kết thúc phiên làm việc với cmd
                conn.closecon();

            }
            return true;
        }
        */
        public bool DeleteDT(string ma)
        {
            cmd.CommandText = "delete chitiethoadon where mahoadon = '" + ma + "'";
            // câu lệnh query
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Con;
            try
            {
                conn.opencon();
                cmd.ExecuteNonQuery();
                // adapter mở cmd lấy dữ liệu về cho hàm getdata
                conn.closecon();
                return true;
            }
            catch (Exception ex)
            // nếu xảy ra lỗi thì
            {
                string mex = ex.Message;
                cmd.Dispose();
                //xóa bỏ và kết thúc phiên làm việc với cmd
                conn.closecon();

            }
            return false;
        }
    }
}
