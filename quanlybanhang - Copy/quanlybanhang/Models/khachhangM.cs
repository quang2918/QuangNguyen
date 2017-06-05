using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanlybanhang.Models;
using System.Data;
using System.Data.SqlClient;
using quanlybanhang.Objects;
namespace quanlybanhang.Models
{
    class khachhangM
    {
        ConnectSQL conn = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        //  SqlConnection con = new SqlConnection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = " select * from khachhang";
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
        public bool AddDT(khachhangO kho)
        {
            cmd.CommandText = "   Insert into dbo.khachhang values ('" + kho.Makh +"', N'"+kho.Tenkh + "', N'" + kho.Gioitinh + "', N'"  +kho.Diachi + "', N'"  +kho.Sdt+ "', N'"+kho.Email +"')" ;
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
        public bool UpdateDT(khachhangO kho)
        {
            cmd.CommandText = " Update  khachhang set tenkhachhang= '" + kho.Tenkh + "',    gioitinh= '" + kho.Gioitinh + "', sdt='" + kho.Sdt + "', diachi='" + kho.Diachi + "', matkhau='" + kho.Email + "', where makhachhang='" + kho.Makh + "'";
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
        public bool DeleteDT(string ma)
        {
            cmd.CommandText = "delete khachhang where makhachhang= '" + ma + "'";
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

