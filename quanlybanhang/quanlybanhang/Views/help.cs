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
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string hd = "Giới thiệu phần mềm1.docx";
            FileStream fs = new FileStream(hd, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;
            //doc tat ca du lieu trong file luu vao str;
            str = sr.ReadToEnd();
            //set text cua textbox1 = str;
            richTextBox1.Text = str;
            sr.Close();
            fs.Close();
           
        }
        private void Text_Load(object sender, EventArgs e)
        {
            string[] args = System.Environment.GetCommandLineArgs();
            string filePath = args[0];
            for (int i = 0; i <= args.Length - 1; i++)
            {
                if (args[i].EndsWith(".exe") == false)
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(args[i],
                    Encoding.Default);
                }
            }
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string[] args = System.Environment.GetCommandLineArgs();
            string filePath = args[0];
        }
        public sealed class StartupEventArgs : EventArgs
        {

        }



    }
}
