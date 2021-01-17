using QuanLyThiTracNghiem.GUI.HeThong;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThiTracNghiem.Utils;
using QuanLyThiTracNghiem.GUI.Admin;

namespace QuanLyThiTracNghiem
{
    static class Program
    {
        public static string databaseName;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            databaseName = ConfigurationManager.AppSettings["DatabaseName"];
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem.Properties.Settings.QLThiConnectionString"].ConnectionString;
            if (Utils.Utils.KiemTraKetNoiTonTai(connectionString))
            {
                Application.Run(new frmHocSinh(new Data.NguoiDung {IDNguoiDung = 531 }));
            }
            else
            {
                Application.Run(new frmCauHinhDB());
            }
        }
    }
}
