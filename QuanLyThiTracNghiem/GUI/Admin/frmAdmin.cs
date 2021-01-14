using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyThiTracNghiem.Utils.Utils;

namespace QuanLyThiTracNghiem
{

    public partial class frmAdmin : Form
    {
        private BindingSource bindingGV = new BindingSource();
        private BindingSource bindingHS = new BindingSource();

        private GiaoVienRepository _giaoVienRepository = new GiaoVienRepository();
        private HocSinhRepository _hocSinhRepository = new HocSinhRepository();


        private BindingManagerBase _bindingManagerGV;
        private BindingManagerBase _bindingManagerHS;
        public frmAdmin()
        {
            InitializeComponent();
            tcAdmin.ControlAdded += TcAdmin_SelectedIndexChanged;
            tcAdmin.Selecting += TcAdmin_SelectedIndexChanged;
            tcAdmin.TabPages.Clear();

            dgvGiaoVien.CellFormatting += DgvGiaoVien_CellFormatting;
            dgvHocSinh.CellFormatting += DgvHocSinh_CellFormatting;
        }

        //Che mật khẩu 
        private void DgvGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGiaoVien.Columns["MatKhauHash"].Index == e.ColumnIndex && e.Value != null)
                    e.Value = new string('*', e.Value.ToString().Length);
        }

        private void DgvHocSinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHocSinh.Columns["MatKhauHashHS"].Index == e.ColumnIndex && e.Value != null)
                e.Value = new string('*', e.Value.ToString().Length);
        }

        // Tải lại
        private void ReLoad()
        {

            if (tcAdmin.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyGiaoVien.ToString()))
            {
                LoadGiaoVien();
            }
            else if(tcAdmin.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyHocSinh.ToString()))
            {
                LoadHocSinh();
            }
            else
            {
            }
        }

        private void LoadGiaoVien()
        {
            //if (bindingGV.Count > 0)
            //{
            //    bindingGV.ResetBindings(true);
            //    return;
            //}
            dgvGiaoVien.DataBindings.Clear();
            bindingGV.DataSource = _giaoVienRepository.FindAll().Select(giaovien => new
            {
                giaovien.MaGV,
                giaovien.HoTen,
                giaovien.NgaySinh,
                giaovien.DiaChi,
                giaovien.NguoiDung.TenTaiKhoan,
                giaovien.NguoiDung.MatKhauHash
            });
            dgvGiaoVien.DataSource = bindingGV;

            txtHoTen.DataBindings.Add("Text", bindingGV, "HoTen");
            txtMaGV.DataBindings.Add("Text", bindingGV, "MaGV");
            dtpNgaySinh.DataBindings.Add("Value", bindingGV, "NgaySinh");
            txtDiaChi.DataBindings.Add("Text", bindingGV, "DiaChi");
            txtTenTaiKhoan.DataBindings.Add("Text", bindingGV, "TenTaiKhoan");
            txtMatKhau.DataBindings.Add("Text", bindingGV, "MatKhauHash");
            _bindingManagerGV = BindingContext[bindingGV];
        }
        
        private void LoadHocSinh()
        {
            //if (bindingHS.Count > 0)
            //{
            //    bindingHS.ResetBindings(true);
            //    return;
            //}
            dgvHocSinh.DataBindings.Clear();

            bindingHS.DataSource = _hocSinhRepository.FindAll().Select(hocsinh => new
            {
                hocsinh.MaHS,
                hocsinh.HoTen,
                hocsinh.NgaySinh,
                hocsinh.DiaChi,
                hocsinh.Lop,
                hocsinh.NguoiDung.TenTaiKhoan,
                hocsinh.NguoiDung.MatKhauHash
            });
            dgvHocSinh.DataSource = bindingHS;

            txtHoTenHS.DataBindings.Clear();
            txtMaHS.DataBindings.Clear();
            dtpNgaySinhHS.DataBindings.Clear();
            txtDiaChiHS.DataBindings.Clear();
            txtLop.DataBindings.Clear();
            txtTenTaiKhoanHS.DataBindings.Clear();
            txtMatKhauHS.DataBindings.Clear();

            txtHoTenHS.DataBindings.Add("Text", bindingHS, "HoTen");
            txtMaHS.DataBindings.Add("Text", bindingHS, "MaHS");
            dtpNgaySinhHS.DataBindings.Add("Value", bindingHS, "NgaySinh");
            txtDiaChiHS.DataBindings.Add("Text", bindingHS, "DiaChi");
            txtLop.DataBindings.Add("Text", bindingHS, "Lop");
            txtTenTaiKhoanHS.DataBindings.Add("Text", bindingHS, "TenTaiKhoan");
            txtMatKhauHS.DataBindings.Add("Text", bindingHS, "MatKhauHash");
            _bindingManagerHS = BindingContext[bindingHS];
        }


        //Event khi tab thay đổi
        private void TcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcAdmin.SelectedTab != null)
                ReLoad();
        }


        //xử lý tabpage
        private void HienTabPage(QuanLyTabPage tabPage)
        {
            foreach (TabPage i in tcAdmin.TabPages)
            {
                if (i.Tag.Equals(tabPage.ToString()))
                {
                    tcAdmin.SelectedIndex = -1;
                    tcAdmin.SelectedTab = i;
                    return;
                }
            }
            switch (tabPage)
            {
                case QuanLyTabPage.QuanLyHocSinh:
                    tcAdmin.TabPages.Add(tpQuanLyHocSinh);
                    tcAdmin.SelectedTab = tpQuanLyHocSinh;
                    break;
                case QuanLyTabPage.QuanLyGiaoVien:
                    tcAdmin.TabPages.Add(tpQuanLyGiaoVien);
                    tcAdmin.SelectedTab = tpQuanLyGiaoVien;

                    break;
                case QuanLyTabPage.KetQuaThi:
                    tcAdmin.TabPages.Add(tpKetQuaThi);
                    tcAdmin.SelectedTab = tpKetQuaThi;

                    break;
                default:
                    break;
            }
        }

        //Event khi chọn tabpage
        private void DanhSachGiaoVienMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyGiaoVien);
        }

        private void DanhSachHocSinhMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyHocSinh);
        }

        private void KetQuaMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.KetQuaThi);
        }




        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            HocSinh hs = _hocSinhRepository.FindByCondition(p => p.MaHS.Equals(txtMaHS.Text)).Single();
            hs.MaHS = txtMaHS.Text;
            hs.Lop = txtLop.Text;
            hs.HoTen = txtHoTenHS.Text;
            hs.DiaChi = txtDiaChiHS.Text;
            hs.NgaySinh = dtpNgaySinhHS.Value;
            hs.NguoiDung.TenTaiKhoan = txtTenTaiKhoanHS.Text;
            hs.NguoiDung.MatKhauHash = txtMatKhauHS.Text;

            _hocSinhRepository.Update();
            LoadHocSinh();
        }
    }
}
