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
    class hanghoaC
    {
        hanghoaM hhm = new hanghoaM();
        public DataTable getdt()
        {
            return hhm.Getdata();
        }
        public bool adddt(hanghoaO hho)
        {
            return hhm.AddDT(hho);
        }
        public bool updatedt(hanghoaO hho)
        {
            return hhm.AddDT(hho);
        }
        public bool deletedt(string ma)
        {
            return hhm.DeleteDT(ma);
        }

        internal DataTable getdt(string v)
        {
            throw new NotImplementedException();
        }
    }
}
