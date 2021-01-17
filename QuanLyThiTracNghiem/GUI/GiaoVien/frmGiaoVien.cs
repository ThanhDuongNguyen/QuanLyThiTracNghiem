using QuanLyThiTracNghiem.Repository;
using QuanLyThiTracNghiem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static QuanLyThiTracNghiem.Utils.Utils;
using System.IO;
using ExcelDataReader;
using ClosedXML.Excel;

namespace QuanLyThiTracNghiem
{
    public partial class frmGiaoVien : Form
    {
        private GiaoVienRepository _giaoVienRepository = new GiaoVienRepository();
        private MonHocRepository _monHocRepository = new MonHocRepository();
        private CapDoRepository _capDoRepository = new CapDoRepository();
        private KhoiRepository _khoiRepository = new KhoiRepository();
        private LoaiKyThiRepository _loaiKyThiRepository = new LoaiKyThiRepository();
        private NguoiDung _nguoiDung;
        public frmGiaoVien(NguoiDung nguoiDung)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
            LoadThongTinGiaoVien();

            tcGV.ControlAdded += TcGV_ControlAdded;
            tcGV.Selecting += TcGV_Selecting;
            tcGV.TabPages.Clear();


            dgvCauHoi.SelectionChanged += DgvCauHoi_SelectionChanged;
            dgvDeThi.SelectionChanged += DgvDeThi_SelectionChanged;
            dgvKT.SelectionChanged += DgvKT_SelectionChanged;


            List<MonHoc> monHocs = _monHocRepository.FindAll().ToList();
            monHocComboBox.DataSource = monHocs;
            monHocComboBox.DisplayMember = "TenMonHoc";
            monHocComboBox.ValueMember = "MaMonHoc";
            maMHComboBox.DataSource = monHocs;
            maMHComboBox.DisplayMember = "TenMonHoc";
            maMHComboBox.ValueMember = "MaMonHoc";

            List<LoaiKiThi> loaiKiThis = _loaiKyThiRepository.FindAll().ToList();
            loaiKTComboBox.DataSource = loaiKiThis;
            loaiKTComboBox.DisplayMember = "TenLoaiKiThi";
            loaiKTComboBox.ValueMember = "LoaiKiThi1";
            

            List<CapDo> capDos = _capDoRepository.FindAll().ToList();
            capDoComboBox.DataSource = capDos;
            capDoComboBox.DisplayMember = "TenCapDo";
            capDoComboBox.ValueMember = "MaCapDo";

            List<CapHoc> Khois = _khoiRepository.FindAll().ToList();
            capHocComboBox.DataSource = Khois;
            capHocComboBox.DisplayMember = "TenCapHoc";
            capHocComboBox.ValueMember = "IDCapHoc";

            maCapHocComboBox.DataSource = Khois;
            maCapHocComboBox.DisplayMember = "TenCapHoc";
            maCapHocComboBox.ValueMember = "IDCapHoc";

            maCapHocKTCombobox.DataSource = Khois;
            maCapHocKTCombobox.DisplayMember = "TenCapHoc";
            maCapHocKTCombobox.ValueMember = "IDCapHoc";


            dgvDSCauHoi.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Chon",
                HeaderText = "Chọn câu hỏi",
                Width = 80,
                TrueValue = true,
                FalseValue = false,
                IndeterminateValue = false
            });

            dgvKTDT.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Chon",
                HeaderText = "Chọn đề thi",
                Width = 80,
                TrueValue = true,
                FalseValue = false,
                IndeterminateValue = false
            });
            dgvKTHS.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Chon",
                HeaderText = "Chọn học sinh",
                Width = 80,
                TrueValue = true,
                FalseValue = false,
                IndeterminateValue = false
            });
        }

        private void DgvKT_SelectionChanged(object sender, EventArgs e)
        {
            LoadKT_DT();
            LoadKT_HS();
        }

        private void DgvDeThi_SelectionChanged(object sender, EventArgs e)
        {
            LoadDSCH();
        }

        private void DgvCauHoi_SelectionChanged(object sender, EventArgs e)
        {
            txtCauTL1.DataBindings.Clear();
            txtCauTL2.DataBindings.Clear();
            txtCauTL3.DataBindings.Clear();
            txtCauTL4.DataBindings.Clear();
            txtCauTL5.DataBindings.Clear();
            txtCauTL6.DataBindings.Clear();

            txtCauTL1.Text = "";
            txtCauTL2.Text = "";
            txtCauTL3.Text = "";
            txtCauTL4.Text = "";
            txtCauTL5.Text = "";
            txtCauTL6.Text = "";

            cbDung1.DataBindings.Clear();
            cbDung2.DataBindings.Clear();
            cbDung3.DataBindings.Clear();
            cbDung4.DataBindings.Clear();
            cbDung5.DataBindings.Clear();
            cbDung6.DataBindings.Clear();

            cbDung1.Checked = false;
            cbDung2.Checked = false;
            cbDung3.Checked = false;
            cbDung4.Checked = false;
            cbDung5.Checked = false;
            cbDung6.Checked = false;
            if (dgvCauHoi.SelectedRows.Count <= 0)
                return;
            string cauhoitemp = dgvCauHoi.SelectedRows[0].Cells["CauHoi"].Value.ToString();
            CauHoi cauhoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(cauhoitemp)).SingleOrDefault();

            List<DapAn> dapAns = _dapAnRepository.FindByCondition(p => p.IDCauHoi.Equals(cauhoi.IDCauHoi)).ToList();
            foreach (var item in dapAns)
            {
                switch (item.STTDapAn)
                {
                    case 1:
                        txtCauTL1.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung1.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    case 2:
                        txtCauTL2.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung2.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    case 3:
                        txtCauTL3.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung3.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    case 4:
                        txtCauTL4.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung4.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    case 5:
                        txtCauTL5.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung5.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    case 6:
                        txtCauTL6.DataBindings.Add("Text", item, "DapAnCauHoi");
                        cbDung6.DataBindings.Add("Checked", item, "IsDung");
                        break;
                    default:
                        break;
                }
            }

        }

        private void ReLoad()
        {

            if (tcGV.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyCauHoi.ToString()))
            {
                LoadCauHoi();
            }
            else if (tcGV.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyDeThi.ToString()))
            {
                LoadDeThi();
            }
            else if (tcGV.SelectedTab.Tag.Equals(QuanLyTabPage.QuanLyKyThi.ToString()))
            {
                LoadKyThi();
            }
            //else
            //{
            //}
        }

        

        private BindingSource bindingCH = new BindingSource();
        private BindingSource bindingDA = new BindingSource();
        private CauHoiRepository _cauHoiRepository = new CauHoiRepository();
        private DapAnRepository _dapAnRepository = new DapAnRepository();
        private void LoadCauHoi()
        {
            dgvCauHoi.DataBindings.Clear();

            bindingCH.DataSource = _cauHoiRepository.FindAll().Select(ch => new
            {
                ch.CauHoiDeBai,
                ch.CapDo1.TenCapDo,
                ch.CapDo,
                ch.MonHoc,
                ch.CapHoc,
                ch.GoiY,
                ch.MonHoc1.TenMonHoc,
                ch.CapHoc1.TenCapHoc
            });
            dgvCauHoi.DataSource = bindingCH;

            cauHoiDeBaiTextBox.DataBindings.Clear();
            capDoComboBox.DataBindings.Clear();
            goiYTextBox.DataBindings.Clear();
            monHocComboBox.DataBindings.Clear();
            capHocComboBox.DataBindings.Clear();


            cauHoiDeBaiTextBox.DataBindings.Add("Text", bindingCH, "CauHoiDeBai");
            capDoComboBox.DataBindings.Add("SelectedValue", bindingCH, "CapDo");
            goiYTextBox.DataBindings.Add("Text", bindingCH, "GoiY");
            monHocComboBox.DataBindings.Add("SelectedValue", bindingCH, "MonHoc");
            capHocComboBox.DataBindings.Add("SelectedValue", bindingCH, "CapHoc");


        }

        private BindingSource bindingDT = new BindingSource();
        private BindingSource bindingDSCH = new BindingSource();
        private BindingSource bindingKT = new BindingSource();
        private BindingSource bindingKTHS = new BindingSource();
        private BindingSource bindingKTDT = new BindingSource();
        private DeThiRepository _deThiRepository = new DeThiRepository();
        private KyThiRepository _kyThiRepository = new KyThiRepository();
        private DeThi_CH_Repository _dt_chRepository = new DeThi_CH_Repository();

        private void LoadKyThi()
        {
            dgvKT.DataBindings.Clear();

            //List<KyThi> kyThis = _kyThiRepository.FindAll().ToList();
            bindingKT.DataSource = _kyThiRepository.FindAll().ToList();
            dgvKT.DataSource = bindingKT;

            maKTTextBox.DataBindings.Clear();
            tenKTTextBox.DataBindings.Clear();
            ngayBDDateTimePicker.DataBindings.Clear();
            ngayKTDateTimePicker.DataBindings.Clear();
            loaiKTComboBox.DataBindings.Clear();
            maCapHocKTCombobox.DataBindings.Clear();

            maKTTextBox.DataBindings.Add("Text", bindingKT, "MaKT");
            tenKTTextBox.DataBindings.Add("Text", bindingKT, "TenKT");
            ngayBDDateTimePicker.DataBindings.Add("Value", bindingKT, "NgayBD");
            ngayKTDateTimePicker.DataBindings.Add("Value", bindingKT, "NgayKT");
            loaiKTComboBox.DataBindings.Add("SelectedValue", bindingKT, "LoaiKT");
            maCapHocKTCombobox.DataBindings.Add("SelectedValue", bindingKT, "MaCapHoc");
            LoadKT_DT();
            LoadKT_HS();
        }
        private KT_DTRepository _KT_DT_RePository = new KT_DTRepository();
        private KT_HSRepository _KT_HS_Repository = new KT_HSRepository();
        private void LoadKT_DT()
        {
            //refresh
            dgvKTDT.DataBindings.Clear();
            foreach (DataGridViewRow item in dgvKTDT.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                cell.Value = cell.FalseValue;
            }


            bindingKTDT.DataSource = _deThiRepository.FindAll().ToList();
            dgvKTDT.DataSource = bindingKTDT;

            if (dgvKT.SelectedRows.Count <= 0)
                return;
            string maKT = dgvKT.SelectedRows[0].Cells["MaKT"].Value.ToString();

            List<KT_DT> kt_dt = _KT_DT_RePository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();

            foreach (DataGridViewRow item in dgvKTDT.Rows)
            {
                string madethi = item.Cells["MaDeThi"].Value.ToString();
                foreach (KT_DT j in kt_dt)
                {
                    if (j.MaDT.Equals(madethi))
                    {
                        var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                        cell.Value = cell.TrueValue;
                    }
                }
            }
        }

        private HocSinhRepository _hocSinhRepository = new HocSinhRepository();
        private void LoadKT_HS()
        {
            //refresh
            dgvKTHS.DataBindings.Clear();
            foreach (DataGridViewRow item in dgvKTHS.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                cell.Value = cell.FalseValue;
            }


            bindingKTHS.DataSource = _hocSinhRepository.FindAll().ToList();
            dgvKTHS.DataSource = bindingKTHS;

            if (dgvKT.SelectedRows.Count <= 0)
                return;
            string maKT = dgvKT.SelectedRows[0].Cells["MaKT"].Value.ToString();

            List<KT_H> kt_hs = _KT_HS_Repository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();

            foreach (DataGridViewRow item in dgvKTHS.Rows)
            {
                string mahs = item.Cells["MaHS"].Value.ToString();
                foreach (KT_H j in kt_hs)
                {
                    if (j.MaHS.Equals(mahs))
                    {
                        var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                        cell.Value = cell.TrueValue;
                    }
                }
            }
        }

        private void LoadDeThi()
        {
            dgvDeThi.DataBindings.Clear();

            List<DeThi> deThis = _deThiRepository.FindAll().ToList();
            bindingDT.DataSource = _deThiRepository.FindAll().ToList();
            dgvDeThi.DataSource = bindingDT;

            maDeThiTextBox.DataBindings.Clear();
            tenDeThiTextBox.DataBindings.Clear();
            maMHComboBox.DataBindings.Clear();
            thoiGianTextBox.DataBindings.Clear();
            maCapHocComboBox.DataBindings.Clear();

            maDeThiTextBox.DataBindings.Add("Text", bindingDT, "MaDeThi");
            tenDeThiTextBox.DataBindings.Add("Text", bindingDT, "TenDeThi");
            maMHComboBox.DataBindings.Add("SelectedValue", bindingDT, "MaMH");
            thoiGianTextBox.DataBindings.Add("Text", bindingDT, "ThoiGian");
            maCapHocComboBox.DataBindings.Add("SelectedValue", bindingDT, "MaCapHoc");

            LoadDSCH();

        }

        private void LoadDSCH()
        {


            dgvDSCauHoi.DataBindings.Clear();
            foreach (DataGridViewRow item in dgvDSCauHoi.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                cell.Value = cell.FalseValue;
            }

            bindingDSCH.DataSource = _cauHoiRepository.FindAll();
            dgvDSCauHoi.DataSource = bindingDSCH;

            if (dgvDeThi.SelectedRows.Count <= 0)
                return;
            string maDT = dgvDeThi.SelectedRows[0].Cells["MaDT"].Value.ToString();
            List<DeThi_CauHoi> dt_ch = _dt_chRepository.FindByCondition(p => p.MaDT.Equals(maDT)).ToList();
            foreach (DataGridViewRow item in dgvDSCauHoi.Rows)
            {
                string cauhoi = item.Cells["DeThiCauHoi"].Value.ToString();
                CauHoi idCauHoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(cauhoi)).Single();
                foreach (DeThi_CauHoi j in dt_ch)
                {
                    if (idCauHoi.IDCauHoi.Equals(j.IDCauHoi))
                    {
                        var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                        cell.Value = cell.TrueValue;
                    }
                }
            }

        }


        //event thay doi
        private void TcGV_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tcGV.SelectedTab != null)
                ReLoad();
        }
        private void TcGV_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tcGV.SelectedTab != null)
                ReLoad();
        }

        //hien tabpageh
        private void HienTabPage(QuanLyTabPage tabPage)
        {
            foreach (TabPage i in tcGV.TabPages)
            {
                if (i.Tag.Equals(tabPage.ToString()))
                {
                    tcGV.SelectedIndex = -1;
                    tcGV.SelectedTab = i;
                    return;
                }
            }
            switch (tabPage)
            {
                case QuanLyTabPage.QuanLyCauHoi:
                    tcGV.TabPages.Add(tpQuanLyCauHoi);
                    tcGV.SelectedTab = tpQuanLyCauHoi;
                    break;
                case QuanLyTabPage.QuanLyDeThi:
                    tcGV.TabPages.Add(tpQuanLyDeThi);
                    tcGV.SelectedTab = tpQuanLyDeThi;
                    break;

                case QuanLyTabPage.QuanLyKyThi:
                    tcGV.TabPages.Add(tpQuanLyKyThi);
                    tcGV.SelectedTab = tpQuanLyKyThi;
                    break;
                default:
                    break;
            }
        }

        //event chọn tabpage



        private void DanhSachCauHoiMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyCauHoi);
        }
        private void DanhSachDeThiMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyDeThi);
            LoadDeThi();
        }
        private void DanhSachKyThiMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyKyThi);
            ReLoad();
        }
        public void LoadThongTinGiaoVien()
        {
            GiaoVien giaoVien = new GiaoVien();

            giaoVien = _giaoVienRepository.FindByCondition(p => p.NguoiDungID.Equals(_nguoiDung.IDNguoiDung)).SingleOrDefault();
            Binding binding = new Binding("Text", giaoVien, "HoTen");
            Binding bdmaGv = new Binding("Text", giaoVien, "MaGV");
            Binding bdDchi = new Binding("Text", giaoVien, "DiaChi");
            Binding bdNsgv = new Binding("Text", giaoVien, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, true, "MM/dd/yyyy");
            lblHoTenGv.DataBindings.Add(binding);
            lblMaGV.DataBindings.Add(bdmaGv);
            lbDchiGv.DataBindings.Add(bdDchi);
            lblNsGv.DataBindings.Add(bdNsgv);
        }


        //Cau hoi
        private void btnCapNhatCauHoi_Click(object sender, EventArgs e)
        {
            string oldCH = dgvCauHoi.SelectedRows[0].Cells["CauHoi"].Value.ToString();
            CauHoi cauhoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(oldCH)).SingleOrDefault();



            cauhoi.MonHoc = monHocComboBox.SelectedValue.ToString();
            cauhoi.CauHoiDeBai = cauHoiDeBaiTextBox.Text;
            cauhoi.CapDo = int.Parse(capDoComboBox.SelectedValue.ToString());
            cauhoi.CapHoc = int.Parse(capHocComboBox.SelectedValue.ToString());
            cauhoi.GoiY = goiYTextBox.Text;
            _cauHoiRepository.Update();

            List<TextBox> list = new List<TextBox>();
            list.Add(txtCauTL1);
            list.Add(txtCauTL2);
            list.Add(txtCauTL3);
            list.Add(txtCauTL4);
            list.Add(txtCauTL5);
            list.Add(txtCauTL6);

            List<CheckBox> listcheck = new List<CheckBox>();
            listcheck.Add(cbDung1);
            listcheck.Add(cbDung2);
            listcheck.Add(cbDung3);
            listcheck.Add(cbDung4);
            listcheck.Add(cbDung5);
            listcheck.Add(cbDung6);

            List<DapAn> dapAns = _dapAnRepository.FindByCondition(p => p.IDCauHoi.Equals(cauhoi.IDCauHoi)).ToList();
            foreach (var i in list)
            {
                bool flag = false;
                foreach (var j in dapAns)
                {
                    if (int.Parse(i.Tag.ToString()).Equals(j.STTDapAn))
                    {
                        j.DapAnCauHoi = i.Text;
                        flag = true;
                    }
                }
                if (!string.IsNullOrEmpty(i.Text) && !flag)
                {
                    _dapAnRepository.Create(new DapAn
                    {
                        IDCauHoi = cauhoi.IDCauHoi,
                        DapAnCauHoi = i.Text,
                        STTDapAn = int.Parse(i.Tag.ToString()),
                        IsDung = false
                    });
                }
            }
            _dapAnRepository.Update();

            List<DapAn> dapAnsNew = _dapAnRepository.FindByCondition(p => p.IDCauHoi.Equals(cauhoi.IDCauHoi)).ToList();
            foreach (var i in listcheck)
            {
                foreach (var j in dapAnsNew)
                {
                    if (int.Parse(i.Tag.ToString()).Equals(j.STTDapAn))
                    {
                        j.IsDung = i.Checked;
                    }
                }
            }
            _dapAnRepository.Update();
            LoadCauHoi();
        }

        private void btThemCauHoi_Click(object sender, EventArgs e)
        {
            if (_cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(cauHoiDeBaiTextBox.Text)).SingleOrDefault() != null)
            {
                MessageBox.Show("Câu hỏi này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CauHoi cauhoi = new CauHoi()
            {
                CauHoiDeBai = cauHoiDeBaiTextBox.Text,
                GoiY = goiYTextBox.Text,
                CapDo = int.Parse(capDoComboBox.SelectedValue.ToString()),
                CapHoc = int.Parse(capHocComboBox.SelectedValue.ToString()),
                MonHoc = monHocComboBox.SelectedValue.ToString()
            };
            _cauHoiRepository.Create(cauhoi);
            _cauHoiRepository.Update();

            List<TextBox> list = new List<TextBox>();
            list.Add(txtCauTL1);
            list.Add(txtCauTL2);
            list.Add(txtCauTL3);
            list.Add(txtCauTL4);
            list.Add(txtCauTL5);
            list.Add(txtCauTL6);

            List<CheckBox> listcheck = new List<CheckBox>();
            listcheck.Add(cbDung1);
            listcheck.Add(cbDung2);
            listcheck.Add(cbDung3);
            listcheck.Add(cbDung4);
            listcheck.Add(cbDung5);
            listcheck.Add(cbDung6);

            foreach (var item in list)
            {
                if (!String.IsNullOrEmpty(item.Text))
                {
                    _dapAnRepository.Create(new DapAn
                    {
                        IDCauHoi = cauhoi.IDCauHoi,
                        DapAnCauHoi = item.Text,
                        STTDapAn = int.Parse(item.Tag.ToString()),
                        IsDung = false
                    });
                }
            }
            _dapAnRepository.Update();

            List<DapAn> dapAnsNew = _dapAnRepository.FindByCondition(p => p.IDCauHoi.Equals(cauhoi.IDCauHoi)).ToList();
            foreach (var i in listcheck)
            {
                foreach (var j in dapAnsNew)
                {
                    if (int.Parse(i.Tag.ToString()).Equals(j.STTDapAn))
                    {
                        j.IsDung = i.Checked;
                    }
                }
            }
            _dapAnRepository.Update();
            LoadCauHoi();
        }

        private void btnXoaCH_Click(object sender, EventArgs e)
        {
            string oldCH = dgvCauHoi.SelectedRows[0].Cells["CauHoi"].Value.ToString();
            CauHoi cauhoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(oldCH)).Single();

            List<DapAn> dapAns = _dapAnRepository.FindByCondition(p => p.IDCauHoi.Equals(cauhoi.IDCauHoi)).ToList();
            foreach (var item in dapAns)
            {
                _dapAnRepository.Delete(item);
            }
            _dapAnRepository.Update();

            _cauHoiRepository.Delete(cauhoi);
            _cauHoiRepository.Update();
            LoadCauHoi();
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            int soluongCHThanhCong = 0;
            int CHTrung = 0;
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

                    DataTable dataCH = ds.Tables["CauHoi"];
                    DataTable dataDA = ds.Tables["DapAn"];

                    foreach (DataRow row in dataCH.Rows)
                    {
                        if (_cauHoiRepository.FindByCondition(ch => ch.CauHoiDeBai.Equals(row["CauHoiDeBai"].ToString())).SingleOrDefault() != null)
                        {
                            CHTrung++;
                            continue;
                        }
                        else
                        {
                            CauHoi cauhoi = new CauHoi()
                            {
                                CauHoiDeBai = row["CauHoiDeBai"].ToString(),
                                GoiY = row["GoiY"].ToString(),
                                CapDo = int.Parse(row["CapDo"].ToString()),
                                CapHoc = int.Parse(row["Khoi"].ToString()),
                                MonHoc = row["MonHoc"].ToString()
                            };

                            _cauHoiRepository.Create(cauhoi);
                            _cauHoiRepository.Update();

                            int maCH = int.Parse(row["MaCH"].ToString());
                            foreach (DataRow rowDA in dataDA.Rows)
                            {
                                if (int.Parse(rowDA["MaCH"].ToString()).Equals(maCH))
                                {
                                    _dapAnRepository.Create(new DapAn
                                    {
                                        IDCauHoi = cauhoi.IDCauHoi,
                                        DapAnCauHoi = rowDA["DapAnCauHoi"].ToString(),
                                        STTDapAn = int.Parse(rowDA["STT"].ToString()),
                                        IsDung = bool.Parse(rowDA["Dung"].ToString())
                                    });
                                    _dapAnRepository.Update();
                                }
                            }

                            soluongCHThanhCong++;
                        }
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Lỗi file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Số câu hỏi thêm thành công: {soluongCHThanhCong}\n" +
                        $"Số học sinh bị trùng: {CHTrung}\n");
                    return;
                }
            MessageBox.Show($"Số câu hỏi thêm thành công: {soluongCHThanhCong}\n" +
                        $"Số học sinh bị trùng: {CHTrung}\n");
            LoadCauHoi();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
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
                    DataTable dtCauHoi = new DataTable();
                    dtCauHoi.TableName = "CauHoi";
                    dtCauHoi.Columns.Add("MaCH", typeof(int));
                    dtCauHoi.Columns.Add("CauHoiDeBai", typeof(string));
                    dtCauHoi.Columns.Add("MonHoc", typeof(string));
                    dtCauHoi.Columns.Add("CapDo", typeof(int));
                    dtCauHoi.Columns.Add("Khoi", typeof(int));
                    dtCauHoi.Columns.Add("GoiY", typeof(string));

                    DataTable dtDapAn = new DataTable();
                    dtDapAn.TableName = "DapAn";
                    dtDapAn.Columns.Add("MaCH", typeof(int));
                    dtDapAn.Columns.Add("DapAnCauHoi", typeof(string));
                    dtDapAn.Columns.Add("Dung", typeof(int));
                    dtDapAn.Columns.Add("STT", typeof(int));

                    List<CauHoi> cauHois = _cauHoiRepository.FindAll().ToList();
                    foreach (var ch in cauHois)
                    {
                        dtCauHoi.Rows.Add(ch.IDCauHoi, ch.CauHoiDeBai, ch.MonHoc, ch.CapDo, ch.CapHoc, ch.GoiY);
                    }

                    List<DapAn> dapAns = _dapAnRepository.FindAll().ToList();
                    foreach (var da in dapAns)
                    {
                        dtDapAn.Rows.Add(da.IDCauHoi, da.DapAnCauHoi, da.IsDung, da.STTDapAn);
                    }

                    XLWorkbook wb = new XLWorkbook();
                    wb.Worksheets.Add(dtCauHoi, dtCauHoi.TableName);
                    wb.Worksheets.Add(dtDapAn, dtDapAn.TableName);

                    wb.SaveAs(sfd.InitialDirectory + sfd.FileName);
                }
            }
        }

        private void btnThemDT_Click(object sender, EventArgs e)
        {
            string maDT = maDeThiTextBox.Text;
            maDeThiTextBox.Undo();
            if (_deThiRepository.FindByCondition(p => p.MaDeThi.Equals(maDT)).Count() > 0)
            {
                MessageBox.Show("Mã đề thi đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            _deThiRepository = new DeThiRepository();
            DeThi deThi = new DeThi();
            deThi.MaDeThi = maDT;
            deThi.TenDeThi = tenDeThiTextBox.Text;
            deThi.MaMH = maMHComboBox.SelectedValue.ToString();
            deThi.ThoiGian = int.Parse(thoiGianTextBox.Text);
            deThi.MaCapHoc = int.Parse(maCapHocComboBox.SelectedValue.ToString());
            deThi.MaGV = lblMaGV.Text;
            deThi.NgayTao = DateTime.Now;

            _deThiRepository.Create(deThi);
            _deThiRepository.Update();


            foreach (DataGridViewRow item in dgvDSCauHoi.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string cauhoi = item.Cells["DeThiCauHoi"].Value.ToString();
                    CauHoi idCauHoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(cauhoi)).Single();
                    _dt_chRepository.Create(new DeThi_CauHoi
                    {
                        MaDT = maDT,
                        IDCauHoi = idCauHoi.IDCauHoi
                    });

                }
            }
            _dt_chRepository.Update();
            ReLoad();
        }

        private void btnSuaDT_Click(object sender, EventArgs e)
        {
            string maDT = dgvDeThi.SelectedRows[0].Cells["MaDT"].Value.ToString();

            DeThi dt = _deThiRepository.FindByCondition(p => p.MaDeThi.Equals(maDT)).Single();
            dt.MaDeThi = maDeThiTextBox.Text;
            dt.TenDeThi = tenDeThiTextBox.Text;
            dt.MaMH = maMHComboBox.SelectedValue.ToString();
            dt.ThoiGian = int.Parse(thoiGianTextBox.Text);
            dt.MaCapHoc = int.Parse(maCapHocComboBox.SelectedValue.ToString());
            _deThiRepository.Update();

            List<DeThi_CauHoi> deThi_CauHois = _dt_chRepository.FindByCondition(p => p.MaDT.Equals(maDT)).ToList();
            foreach (var item in deThi_CauHois)
            {
                _dt_chRepository.Delete(item);
            }
            _dt_chRepository.Update();

            foreach (DataGridViewRow item in dgvDSCauHoi.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string cauhoi = item.Cells["DeThiCauHoi"].Value.ToString();
                    CauHoi idCauHoi = _cauHoiRepository.FindByCondition(p => p.CauHoiDeBai.Equals(cauhoi)).Single();
                    _dt_chRepository.Create(new DeThi_CauHoi
                    {
                        MaDT = dgvDeThi.SelectedRows[0].Cells["MaDT"].Value.ToString(),
                        IDCauHoi = idCauHoi.IDCauHoi
                    });

                }
            }
            _dt_chRepository.Update();

            ReLoad();
        }
        private void btnXoaDT_Click(object sender, EventArgs e)
        {
            string maDT = dgvDeThi.SelectedRows[0].Cells["MaDT"].Value.ToString();
            DeThi dt = _deThiRepository.FindByCondition(p => p.MaDeThi.Equals(maDT)).Single();

            List<DeThi_CauHoi> deThi_CauHois = _dt_chRepository.FindByCondition(p => p.MaDT.Equals(maDT)).ToList();
            foreach (var item in deThi_CauHois)
            {
                _dt_chRepository.Delete(item);
            }
            _dt_chRepository.Update();
            _deThiRepository.Delete(dt);
            _deThiRepository.Update();
            ReLoad();
        }

        private void btnThemKT_Click(object sender, EventArgs e)
        {
            string maKT = maKTTextBox.Text;
            maKTTextBox.Undo();
            if (_kyThiRepository.FindByCondition(p => p.MaKT.Equals(maKT)).Count() > 0)
            {
                MessageBox.Show("Mã kì thi đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return;
            }
            _kyThiRepository = new KyThiRepository();
            KyThi kt = new KyThi();
            kt.MaKT =   maKT;
            kt.TenKT = tenKTTextBox.Text;
            kt.NgayBD = ngayBDDateTimePicker.Value;
            kt.NgayKT = ngayKTDateTimePicker.Value;
            kt.MaCapHoc = int.Parse(maCapHocKTCombobox.SelectedValue.ToString());
            kt.LoaiKT = int.Parse(loaiKTComboBox.SelectedValue.ToString());

            _kyThiRepository.Create(kt);
            _kyThiRepository.Update();


            foreach (DataGridViewRow item in dgvKTDT.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string madethi = item.Cells["MaDeThi"].Value.ToString();
                    _KT_DT_RePository.Create(new KT_DT
                    {
                        MaDT = madethi,
                        MaKT = maKT
                    });

                }
            }
            _KT_DT_RePository.Update();

            foreach (DataGridViewRow item in dgvKTHS.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string mahs = item.Cells["MaHS"].Value.ToString();
                    _KT_HS_Repository.Create(new KT_H
                    {
                        MaHS = mahs,
                        MaKT = maKT
                    });

                }
            }
            _KT_HS_Repository.Update();

            ReLoad();
        }

        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            string maKT = dgvKT.SelectedRows[0].Cells["MaKT"].Value.ToString();
            KyThi kt = _kyThiRepository.FindByCondition(p => p.MaKT.Equals(maKT)).Single();

            List<KT_DT> kT_DTs = _KT_DT_RePository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();
            foreach (var item in kT_DTs)
            {
                _KT_DT_RePository.Delete(item);
            }
            _KT_DT_RePository.Update();
            List<KT_H> kT_Hs = _KT_HS_Repository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();
            foreach (var item in kT_Hs)
            {
                _KT_HS_Repository.Delete(item);
            }
            _KT_HS_Repository.Update();

            _kyThiRepository.Delete(kt);
            _kyThiRepository.Update();
            ReLoad();
        }

        private void btnSuaKT_Click(object sender, EventArgs e)
        {
            string maKT = dgvKT.SelectedRows[0].Cells["MaKT"].Value.ToString();

            KyThi kt = _kyThiRepository.FindByCondition(p => p.MaKT.Equals(maKT)).Single();
            kt.MaKT = maKTTextBox.Text;
            kt.TenKT = tenKTTextBox.Text;
            kt.NgayBD = ngayBDDateTimePicker.Value;
            kt.NgayKT = ngayKTDateTimePicker.Value;
            kt.MaCapHoc = int.Parse(maCapHocKTCombobox.SelectedValue.ToString());
            kt.LoaiKT = int.Parse(loaiKTComboBox.SelectedValue.ToString());
            _kyThiRepository.Update();


            List<KT_DT> kT_DTs = _KT_DT_RePository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();
            foreach (var item in kT_DTs)
            {
                _KT_DT_RePository.Delete(item);
            }
            _KT_DT_RePository.Update();
            foreach (DataGridViewRow item in dgvKTDT.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string madt = item.Cells["MaDeThi"].Value.ToString();
                    _KT_DT_RePository.Create(new KT_DT
                    {
                        MaDT = madt,
                        MaKT = maKT
                    });

                }
            }
            _KT_DT_RePository.Update();

            List<KT_H> kT_HSs = _KT_HS_Repository.FindByCondition(p => p.MaKT.Equals(maKT)).ToList();
            foreach (var item in kT_HSs)
            {
                _KT_HS_Repository.Delete(item);
            }
            _KT_HS_Repository.Update();
            foreach (DataGridViewRow item in dgvKTHS.Rows)
            {
                var cell = item.Cells["Chon"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    string mahs = item.Cells["MaHS"].Value.ToString();
                    _KT_HS_Repository.Create(new KT_H
                    {
                        MaHS = mahs,
                        MaKT = maKT
                    });

                }
            }
            _KT_HS_Repository.Update();

            ReLoad();
        }
    }

    //Quan ly de thi
}
