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
    class nhanvienM
    {
       ConnectSQL conn = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
      //  SqlConnection con = new SqlConnection();
        public  DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = " select * from nhanvien";
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
            catch( Exception ex)
            // nếu xảy ra lỗi thì
            {
                string mex = ex.Message;
                cmd.Dispose();
                //xóa bỏ và kết thúc phiên làm việc với cmd
                conn.closecon();

            }
            return dt;

        } 
        public bool AddDT(nhanvienO nvo) 
        {
            cmd.CommandText = " Insert into dbo.nhanvien values ('" + nvo.Manv +"', N'"+nvo.Tennv + "',CONVERT(DATE,'" +nvo.Ngaysinh +"',103), N'" + nvo.Gioitinh + "',N'" + nvo.Sdt + "',N'" + nvo.Matkhau + "',N'" + nvo.Diachi + "')";
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
        public bool UpdateDT(nhanvienO nvo)
        {
            cmd.CommandText = " Update  nhanvien set tennhanvien= '" + nvo.Tennv + "',  ngaysinh=Convert(date,'" + nvo.Ngaysinh + "',103),  gioitinh= '" + nvo.Gioitinh + "', sdt='" + nvo.Sdt + "', diachi='" + nvo.Diachi + "', matkhau='" + nvo.Matkhau + "', where manhanvien='"+ nvo.Manv+"'" ;
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
        public bool DeleteDT(string ma)
        {
            cmd.CommandText = "delete nhanvien where manhanvien= '" + ma+ "'";
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
