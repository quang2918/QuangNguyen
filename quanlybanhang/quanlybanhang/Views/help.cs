using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang.Views
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
            webBrowser1.Navigate ( @"C:\Users\Do Quang\Documents\GitHub\QuangNguyen\quanlybanhang\quanlybanhang\Views\HỖ TRỢ NGƯỜI DÙNG.htm");
        }

        



    }
}
