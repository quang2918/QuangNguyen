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
    class chitiethdC
    {
        chitiethdM ctm = new chitiethdM();
        public DataTable getdt(string ma)
        {
            return ctm.Getdata(ma);
        }
        public bool adddt(DataTable dt)
        {
            return ctm.AddDT(dt);
        }
        /*  public bool updatedt(nhanvienO nvo)
          {
              return nvm.AddDT(nvo);
          }
          */
        public bool deletedt(string ma)
        {
            return ctm.DeleteDT(ma);
        }

    }
}
