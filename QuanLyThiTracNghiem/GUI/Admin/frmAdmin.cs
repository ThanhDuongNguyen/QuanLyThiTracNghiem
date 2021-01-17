using ClosedXML.Excel;
using ExcelDataReader;
using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.GUI.Admin;
using QuanLyThiTracNghiem.Repository;
using QuanLyThiTracNghiem.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
        private NguoiDungRepository _nguoiDungRepository = new NguoiDungRepository();

        private BindingManagerBase _bindingManagerGV;
        private BindingManagerBase _bindingManagerHS;

        private string oldMaHS;
        private string oldMaGV;
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
            if (tcAdmin.SelectedTab == null)
                return;
            if (tcAdmin.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyGiaoVien.ToString()))
            {
                LoadGiaoVien();
            }
            else if (tcAdmin.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyHocSinh.ToString()))
            {
                LoadHocSinh();
            }
            else
            {
            }
        }

        private void LoadGiaoVien()
        {

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

            txtHoTen.DataBindings.Clear();
            txtMaGV.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtLop.DataBindings.Clear();
            txtTenTaiKhoan.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();

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

            string oldHS = dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value.ToString();

            if (oldHS != txtMaHS.Text)
            {
                MessageBox.Show("Không thể chỉnh sửa mã học sinh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HocSinh hs = _hocSinhRepository.FindByCondition(p => p.MaHS.Equals(oldHS)).Single();
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

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            string oldGV = dgvGiaoVien.SelectedRows[0].Cells["MaGV"].Value.ToString();

            if (oldGV != txtMaGV.Text)
            {
                MessageBox.Show("Không thể chỉnh sửa mã giáo viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien gv = _giaoVienRepository.FindByCondition(p => p.MaGV.Equals(oldGV)).Single();
            gv.MaGV = txtMaGV.Text;
            gv.HoTen = txtHoTen.Text;
            gv.DiaChi = txtDiaChi.Text;
            gv.NgaySinh = dtpNgaySinh.Value;
            gv.NguoiDung.TenTaiKhoan = txtTenTaiKhoan.Text;
            gv.NguoiDung.MatKhauHash = txtMatKhau.Text;

            _giaoVienRepository.Update();
            LoadGiaoVien();
        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            string oldHS = dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value.ToString();
            HocSinh hs = _hocSinhRepository.FindByCondition(p => p.MaHS.Equals(oldHS)).Single();
            int nguoiDungID = hs.NguoiDungID;
            _hocSinhRepository.Delete(hs);
            _hocSinhRepository.Update();

            NguoiDung nguoiDung = _nguoiDungRepository.FindByCondition(p => p.IDNguoiDung.Equals(nguoiDungID)).Single();

            _nguoiDungRepository.Delete(nguoiDung);
            _nguoiDungRepository.Update();

            LoadHocSinh();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            string oldGV = dgvGiaoVien.SelectedRows[0].Cells["MaGV"].Value.ToString();
            GiaoVien gv = _giaoVienRepository.FindByCondition(p => p.MaGV.Equals(oldGV)).Single();
            int nguoiDungID = gv.NguoiDungID;
            _giaoVienRepository.Delete(gv);
            _giaoVienRepository.Update();

            NguoiDung nguoiDung = _nguoiDungRepository.FindByCondition(p => p.IDNguoiDung.Equals(nguoiDungID)).Single();

            _nguoiDungRepository.Delete(nguoiDung);
            _nguoiDungRepository.Update();

            LoadGiaoVien();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (_hocSinhRepository.FindByCondition(p => p.MaHS.Equals(txtMaHS.Text)).SingleOrDefault() != null)
            {
                MessageBox.Show("Mã học sinh này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_nguoiDungRepository.FindByCondition(p => p.TenTaiKhoan.Equals(txtTenTaiKhoanHS.Text)).SingleOrDefault() != null)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiDung nd = new NguoiDung();
            nd.TenTaiKhoan = txtTenTaiKhoanHS.Text;
            nd.MatKhauHash = txtMatKhauHS.Text;
            nd.Quyen = 3;
            _nguoiDungRepository.Create(nd);
            _nguoiDungRepository.Update();

            HocSinh hs = new HocSinh();
            hs.MaHS = txtMaHS.Text;
            hs.Lop = txtLop.Text;
            hs.HoTen = txtHoTenHS.Text;
            hs.DiaChi = txtDiaChiHS.Text;
            hs.NgaySinh = dtpNgaySinhHS.Value;
            hs.NguoiDungID = nd.IDNguoiDung;
            _hocSinhRepository.Create(hs);
            _hocSinhRepository.Update();
            LoadHocSinh();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (_giaoVienRepository.FindByCondition(p => p.MaGV.Equals(txtMaGV.Text)).SingleOrDefault() != null)
            {
                MessageBox.Show("Mã giáo viên này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_nguoiDungRepository.FindByCondition(p => p.TenTaiKhoan.Equals(txtTenTaiKhoan.Text)).SingleOrDefault() != null)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiDung nd = new NguoiDung();
            nd.TenTaiKhoan = txtTenTaiKhoan.Text;
            nd.MatKhauHash = txtMatKhau.Text;
            nd.Quyen = 2;
            _nguoiDungRepository.Create(nd);
            _nguoiDungRepository.Update();

            GiaoVien gv = new GiaoVien();
            gv.MaGV = txtMaGV.Text;
            gv.HoTen = txtHoTen.Text;
            gv.DiaChi = txtDiaChi.Text;
            gv.NgaySinh = dtpNgaySinh.Value;
            gv.NguoiDungID = nd.IDNguoiDung;

            _giaoVienRepository.Create(gv);
            _giaoVienRepository.Update();
            LoadGiaoVien();
        }

        private void ImportMenuItem_Click(object sender, EventArgs e)
        {

            int soluongHSThanhCong = 0;
            int soluongGVThanhCong = 0;
            int giaoVienTrung = 0;
            int hocSinhTrung = 0;
            DataSet ds = new DataSet();
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            { ValidateNames = true, Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls" })
                try
                {

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            IExcelDataReader reader;

                            if (openFileDialog.FilterIndex == 2)
                            {
                                reader = ExcelReaderFactory.CreateBinaryReader(stream);
                            }
                            else
                            {
                                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                            }

                            ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            reader.Close();
                        }
                    }

                    DataTable dataGiaoVien = ds.Tables["GiaoVien"];
                    DataTable dataHocSinh = ds.Tables["HocSinh"];

                    foreach (DataRow row in dataGiaoVien.Rows)
                    {
                        if (_giaoVienRepository.FindByCondition(gv => gv.MaGV == row["MaGV"].ToString()).SingleOrDefault() != null)
                        {

                            giaoVienTrung++;
                            continue;
                        }
                        else
                        {
                            NguoiDung nd = new NguoiDung()
                            {
                                TenTaiKhoan = row["TenTaiKhoan"].ToString(),
                                MatKhauHash = row["MatKhau"].ToString(),
                                Quyen = 2
                            };
                            _nguoiDungRepository.Create(nd);
                            _nguoiDungRepository.Update();

                            _giaoVienRepository.Create(new GiaoVien
                            {
                                MaGV = row["MaGV"].ToString(),
                                HoTen = row["HoTen"].ToString(),
                                NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                                DiaChi = row["DiaChi"].ToString(),
                                NguoiDungID = nd.IDNguoiDung
                            });
                            _giaoVienRepository.Update();
                            soluongGVThanhCong++;
                        }
                    }
                    foreach (DataRow row in dataHocSinh.Rows)
                    {
                        if (_hocSinhRepository.FindByCondition(nd => nd.MaHS == row["MaHS"].ToString()).SingleOrDefault() != null)
                        {
                            hocSinhTrung++;
                            continue;
                        }
                        else
                        {
                            NguoiDung nd = new NguoiDung()
                            {
                                TenTaiKhoan = row["TenTaiKhoan"].ToString(),
                                MatKhauHash = row["MatKhau"].ToString(),
                                Quyen = 3
                            };
                            _nguoiDungRepository.Create(nd);
                            _nguoiDungRepository.Update();

                            _hocSinhRepository.Create(new HocSinh
                            {
                                MaHS = row["MaHS"].ToString(),
                                HoTen = row["HoTen"].ToString(),
                                NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                                DiaChi = row["DiaChi"].ToString(),
                                Lop = row["Lop"].ToString(),
                                NguoiDungID = nd.IDNguoiDung
                            });
                            _hocSinhRepository.Update();
                            soluongHSThanhCong++;
                        }
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Lỗi file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Số học sinh thêm thành công: {soluongHSThanhCong}\n" +
                        $"Số giáo viên thêm thành công: {soluongGVThanhCong}\n" +
                        $"Số học sinh bị trùng: {hocSinhTrung}\n" +
                        $"Số giáo viên bị trùng: {giaoVienTrung}\n");
                    return;
                }
            MessageBox.Show($"Số học sinh thêm thành công: {soluongHSThanhCong}\n" +
                        $"Số giáo viên thêm thành công: {soluongGVThanhCong}\n" +
                        $"Số học sinh bị trùng: {hocSinhTrung}\n" +
                        $"Số giáo viên bị trùng: {giaoVienTrung}\n");
            ReLoad();
        }

        private void ExportMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog()
            {
                CreatePrompt = false,
                OverwritePrompt = true,
                AddExtension = true,
                Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls",
                ValidateNames = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtHocSinh = new DataTable();
                    dtHocSinh.TableName = "HocSinh";
                    dtHocSinh.Columns.Add("MaHS", typeof(string));
                    dtHocSinh.Columns.Add("HoTen", typeof(string));
                    dtHocSinh.Columns.Add("NgaySinh", typeof(DateTime));
                    dtHocSinh.Columns.Add("Lop", typeof(string));
                    dtHocSinh.Columns.Add("DiaChi", typeof(string));
                    dtHocSinh.Columns.Add("TenTaiKhoan", typeof(string));
                    dtHocSinh.Columns.Add("MatKhau", typeof(string));

                    DataTable dtGiaoVien = new DataTable();
                    dtGiaoVien.TableName = "GiaoVien";
                    dtGiaoVien.Columns.Add("MaGV", typeof(string));
                    dtGiaoVien.Columns.Add("HoTen", typeof(string));
                    dtGiaoVien.Columns.Add("NgaySinh", typeof(DateTime));
                    dtGiaoVien.Columns.Add("DiaChi", typeof(string));
                    dtGiaoVien.Columns.Add("TenTaiKhoan", typeof(string));
                    dtGiaoVien.Columns.Add("MatKhau", typeof(string));

                    List <HocSinh> hocSinhs = _hocSinhRepository.FindAll().ToList();
                    foreach (var hs in hocSinhs)
                    {
                        dtHocSinh.Rows.Add(hs.MaHS, hs.HoTen, hs.NgaySinh, hs.Lop,hs.DiaChi, hs.NguoiDung.TenTaiKhoan,hs.NguoiDung.MatKhauHash);
                    }

                    List<GiaoVien> giaoViens = _giaoVienRepository.FindAll().ToList();
                    foreach (var gv in giaoViens)
                    {
                        dtGiaoVien.Rows.Add(gv.MaGV, gv.HoTen, gv.NgaySinh, gv.DiaChi,gv.NguoiDung.TenTaiKhoan, gv.NguoiDung.MatKhauHash);
                    }

                    XLWorkbook wb = new XLWorkbook();
                    wb.Worksheets.Add(dtHocSinh, dtHocSinh.TableName);
                    wb.Worksheets.Add(dtGiaoVien, dtGiaoVien.TableName);

                    wb.SaveAs(sfd.InitialDirectory + sfd.FileName);
                }
            }
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }
    }

}
