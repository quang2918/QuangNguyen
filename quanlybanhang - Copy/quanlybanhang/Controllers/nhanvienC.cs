using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quanlybanhang.Models;
using quanlybanhang.Objects;

namespace quanlybanhang.Controllers
{
    class nhanvienC
    {
        nhanvienM nvm = new nhanvienM();
        public DataTable getdt()
        {
            return nvm.Getdata();
        }
        public bool adddt(nhanvienO nvo)
        {
            return nvm.AddDT(nvo);
        }
        public bool updatedt(nhanvienO nvo)
        {
            return nvm.AddDT(nvo);
        }
        public bool deletedt(string ma)
        {
            return nvm.DeleteDT(ma);
        }

    }
}
