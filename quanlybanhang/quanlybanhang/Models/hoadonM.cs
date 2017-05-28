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
    class hoadonM
    {
        ConnectSQL conn = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        //  SqlConnection con = new SqlConnection();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = " select hd.mahoadon,hd.ngaylap, kh.makhachhang, nv.manhanvien from dbo.hoadon hd, dbo.khachhang kh, dbo.nhanvien nv where kh.makhachhang = hd.makhachhang and nv.manhanvien = hd.manhanvien ";
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
        public bool AddDT(hoadonO hdo)
        {
            cmd.CommandText = " Insert into dbo.hoadon values ('" + hdo.Mahd + "',CONVERT(DATE,'" + hdo.Ngaylap + "',103), '" + hdo.Makh + "', '" + hdo.Manv + "')";
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
            cmd.CommandText = "delete hoadon where mahoadon= '" + ma + "'";
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
