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
    class hanghoaM
    {
        ConnectSQL conn = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        //  SqlConnection con = new SqlConnection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = " select * from hanghoa";
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
        public bool AddDT(hanghoaO hho)
        {
            cmd.CommandText = " Insert into dbo.hanghoa values ('" + hho.Mahh + "', N'" + hho.Tenhh + "', " + hho.Soluong + "," + hho.Dongia +  ")";
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
        public bool UpdateDT(hanghoaO hho)
        {
            cmd.CommandText = " Update  hanghoa set mahanghoa= '" + hho.Mahh + "',   tenhanghoa = '" + hho.Tenhh + "', soluong='" + hho.Soluong + "', dongia='" + hho.Dongia + "', where manhanvien='" + hho.Mahh + "'";
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
            cmd.CommandText = "delete hanghoa where mahanghoa= '" + ma + "'";
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
