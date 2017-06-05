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
    class hoadonC
    {
        hoadonM hdm = new hoadonM();
        public DataTable getdt()
        {
            return hdm.Getdata();
        }
        public bool adddt(hoadonO hdo)
        {
            return hdm.AddDT(hdo);
        }
        /*  public bool updatedt(nhanvienO nvo)
          {
              return nvm.AddDT(nvo);
          }
          */
        public bool deletedt(string ma)
        {
            return hdm.DeleteDT(ma);
        }

    }
}

