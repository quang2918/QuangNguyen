using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quanlybanhang.Models;
using quanlybanhang.Objects;
using quanlybanhang.Views;

namespace quanlybanhang.Controllers
{
    class khachhangC
    {
        khachhangM khm = new khachhangM();
        public DataTable getdt()
        {
            return khm.Getdata();
        }
        public bool adddt(khachhangO kho)
        {
            return khm.AddDT(kho);
        }
        public bool updatedt(khachhangO kho)
        {
            return khm.AddDT(kho);
        }
        public bool deletedt(string ma)
        {
            return khm.DeleteDT(ma);
        }

    }
}
