using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.Objects
{
    class chitiethd
    {
        string tenhh, mahh, dongia, thanhtien;
        int soluong;


        public string Tenhh
        {
            get
            {
                return Tenhh;
            }

            set
            {
                Tenhh = value;
            }
        }

        public string Mahh
        {
            get
            {
                return Mahh;
            }

            set
            {
                Mahh = value;
            }
        }

        public string Dongia
        {
            get
            {
                return Dongia;
            }

            set
            {
                Dongia = value;
            }
        }

        public int Soluong
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

   

        public string Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }

        public chitiethd(string tenhh, string mahh, string dongia, int soluong, string thanhtien)
        {
            this.Dongia = dongia;
            this.Mahh = mahh;
            this.Soluong = soluong;
            this.Tenhh = tenhh;
            this.Thanhtien = thanhtien;
        }
        public chitiethd() { }
    }
}
