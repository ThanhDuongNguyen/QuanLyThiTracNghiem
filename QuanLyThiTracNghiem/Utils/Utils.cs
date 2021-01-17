using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem.Utils
{
    public static class Utils
    {
        public enum QuanLyTabPage
        {
            QuanLyHocSinh,
            QuanLyGiaoVien,
            KetQuaThi,
            QuanLyCauHoi,
            QuanLyKyThi,
            QuanLyDeThi
        }

        public static bool KiemTraKetNoi(string connectionString)
        {
            using(var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool KiemTraKetNoiTonTai(string connectionString)
        {
            string databaseName = new SqlConnectionStringBuilder(connectionString).InitialCatalog;
            try
            {
                if (KiemTraKetNoi(connectionString) && databaseName == Program.databaseName)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool KiemTraChuoiKetNoi(string serverName, string databaseName, string username = "", string password = null)
        {
            string conString = "";
            if (!String.IsNullOrEmpty(username))
            {
                conString = String.Format("server={0};uid={1};pwd={2};database={3}", serverName, username, password, databaseName);
            }
            else
            {
                conString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", serverName, databaseName);
            }
            return KiemTraKetNoi(conString);
        }

        public static List<string> GetAllDatabase(string serverName, string username = "", string password = null)
        {
            List<string> list = new List<string>();
            string conString = "";
            if (!String.IsNullOrEmpty(username))
            {
                conString = String.Format("server={0};uid={1};pwd={2};database=master",serverName, username, password);
            }
            else
            {
                conString = String.Format("Data Source={0};Initial Catalog=master;Integrated Security=True", serverName);
            }
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                return null;
            }
            
            return list;
        }

        public static void UpdateConnectionString(string serverName, string databaseName, string username = "", string password = null)
        {
            string conString = "";
            if (!String.IsNullOrEmpty(username))
            {
                conString = String.Format("server={0};uid={1};pwd={2};database={3}", serverName, username, password, databaseName);
            }
            else
            {
                conString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", serverName, databaseName);
            }
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["QuanLyThiTracNghiem.Properties.Settings.QLThiConnectionString"].ConnectionString = conString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
        }
    }
}
