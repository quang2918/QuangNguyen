using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.Objects
{
    class khachhangO
    {
      //  string makh, tenkh, diachi, gioitinh, matkhau , gioitinh ,sdt;
       
        public khachhangO ( string makh, string tenkh,string diachi, string gioitinh, string sdt, string email)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Diachi = diachi;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Email =email;

           

        }
        public khachhangO() { }
        private string makh;

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }
        private string tenkh;
        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }
        private string gioitinh;
        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }
        private string diachi;
        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        private string sdt;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

       
        private string email;

    }
}
