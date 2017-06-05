using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybanhang.Objects
{
    class nhanvienO
    {
        // lớp khai báo các thuộc tính của nhanvien
        string manv, tennv, diachi, gioitinh,  matkhau;
        string ngaysinh;
        string sdt;
        public nhanvienO (string manv, string tennv, string gioitinh, string diachi, string sdt, string ngaysinh, string matkhau)
        {
            this.Tennv = tennv;
            this.Sdt = sdt;
            this.Manv = manv;
            this.Ngaysinh = ngaysinh;
            this.Matkhau = matkhau;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
        }
        public nhanvienO() { }
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

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

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

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }
    }
}
