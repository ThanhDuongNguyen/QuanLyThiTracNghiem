using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThiTracNghiem.Utils;

namespace QuanLyThiTracNghiem.GUI.HeThong
{
    public partial class frmCauHinhDB : Form
    {
        string[] listAuthen = { "Xác thực bằng tài khoản Window", "Xác thực bằng tài khoản SQL Server" };
        public frmCauHinhDB()
        {
            InitializeComponent();

            //config

            cbAuthen.TextChanged += CbAuthen_TextChanged;
            cbAuthen.DataSource = listAuthen;
            cbDatabaseName.DropDown += CbDatabaseName_DropDown;
        }

        private void CbDatabaseName_DropDown(object sender, EventArgs e)
        {
            if (cbAuthen.SelectedValue.ToString().Equals(listAuthen[0])) // window
            {
                cbDatabaseName.DataSource = Utils.Utils.GetAllDatabase(txtServerName.Text);
                return;
            }
            cbDatabaseName.DataSource = Utils.Utils.GetAllDatabase(txtServerName.Text,txtUsername.Text, txtPassword.Text);
        }

        private void CbAuthen_TextChanged(object sender, EventArgs e)
        {
            if (cbAuthen.SelectedValue.ToString().Equals(listAuthen[0]))//window
            {
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
                return;
            }
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            bool rs = TestConnection();
            
            if(rs)
                MessageBox.Show($"Kết nối hợp lệ", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show($"Kết nối không hợp lệ", "Thông báo", MessageBoxButtons.OK);
        }

        private bool TestConnection()
        {
            if (cbAuthen.SelectedValue.ToString().Equals(listAuthen[0]))
            {
                return Utils.Utils.KiemTraChuoiKetNoi(txtServerName.Text, cbDatabaseName.Text);
            }
            else
            {
                return Utils.Utils.KiemTraChuoiKetNoi(txtServerName.Text, cbDatabaseName.Text, txtUsername.Text, txtPassword.Text);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool rs = TestConnection();
            if (rs)
            {
                MessageBox.Show($"Kết nối hợp lệ, Ứng dụng sẽ chạy lại để hoàn tất thiết lập", "Thông báo", MessageBoxButtons.OK);
                Utils.Utils.UpdateConnectionString(txtServerName.Text, cbDatabaseName.Text, txtUsername.Text, txtPassword.Text);
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show($"Kết nối không hợp lệ", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
