using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.Objects
{
    class chitiethd
    {
        string tenhh, mahh, dongia;
        int soluong;

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
        public chitiethd(string tenhh, string mahh, string dongia, int soluong)
        {
            this.Dongia = dongia;
            this.Mahh = mahh;
            this.Soluong = soluong;
            this.Tenhh = tenhh;
        }
        public chitiethd() { }
    }
}
