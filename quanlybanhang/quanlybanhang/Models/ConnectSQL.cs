using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace quanlybanhang.Models
{
   public  class ConnectSQL
    {
        #region availible
        private SqlConnection con;
        private SqlCommand cmd;

        public SqlCommand Cmd
        {
            get
            {
                return cmd;
            }

            set
            {
                cmd = value;
            }
        }

        public SqlConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        private string error;
   

        #endregion
        #region
        public ConnectSQL()
        {
            string strcon = @"Data Source=DESKTOP-G6V39FB\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
            con = new SqlConnection(strcon);
        }
        #endregion
        #region method
        public bool opencon()
        {
            try
            {
                if (con.State == ConnectionState.Closed)

                    con.Open();

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool closecon()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            
            return true;

        }
     /*   public DataTable getthongtin()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from thongtin";
            cmd.Connection = con;
            try
            {
               opencon();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
               error= ex.Message;
            }
            return dt;
        }*/
    }
    #endregion

    }

