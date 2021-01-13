using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem.GUI.HeThong
{
    public partial class frmDangNhap : Form
    {
        AuthService _authService = new AuthService();
        public frmDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            NguoiDung nguoiDung = _authService.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (nguoiDung != null)
            {
                this.Hide();
                switch (nguoiDung.Quyen)
                {
                    case 1:
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        break;
                    case 2:
                        GiaoVien giaoVien = _authService.LayThongTinGiaoVien(nguoiDung.IDNguoiDung);
                        frmGiaoVien frmGV = new frmGiaoVien(nguoiDung);
                        frmGV.Show();
                        break;
                    case 3:
                        HocSinh hocSinh = _authService.LayThongTinHocSinh(nguoiDung.IDNguoiDung);
                        frmHocSinh frmHocSinh = new frmHocSinh(nguoiDung);
                        frmHocSinh.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
            lblDangNhapLoi.Visible = true;
        }
    }
}
