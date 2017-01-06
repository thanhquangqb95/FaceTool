using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        public class TaiKhoan
        {
            public string ten { get; set; }
            public string id { get; set; }
            public string hinh { get; set; }
            public TaiKhoan(string a, string b, string c)
            {
                ten = a;
                id = b;
                hinh = c;
            }
        }
    }
}
