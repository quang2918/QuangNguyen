using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlybanhang.Objects
{
    public  class hanghoaO
    {
        
        public hanghoaO(string mahh, string tenhh, string soluong, string dongia)
        {
            this.Mahh = mahh;
            this.Tenhh = tenhh;
            this.Soluong = soluong;
            this.Dongia = dongia;

        }
        public hanghoaO() { }
        public string mahh;

        public string Mahh
        {
            get
            {
                return mahh;
            }

            set
            {
                mahh = value;
            }
        }

        public string Tenhh
        {
            get
            {
                return tenhh;
            }

            set
            {
                tenhh = value;
            }
        }
        public string tenhh;
        public string Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public string soluong;
       public string dongia;
    }
}
