using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.GUI.HocSinh;
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

namespace QuanLyThiTracNghiem
{
    public partial class frmHocSinh : Form
    {
        private HocSinhRepository _hocSinhRepository;
        private NguoiDung _nguoiDung;
        public frmHocSinh(NguoiDung nguoiDung)
        {
            InitializeComponent();

            tcHocSinh.TabPages.Clear();
            _hocSinhRepository = new HocSinhRepository();
            _nguoiDung = nguoiDung;
            LoadThongTinHocSinh();
        }

        public void LoadThongTinHocSinh()
        {
            HocSinh hocSinh = new HocSinh();

            hocSinh =_hocSinhRepository.FindByCondition(p=>p.NguoiDungID.Equals(_nguoiDung.IDNguoiDung)).SingleOrDefault();


            Binding bindingHoTen = new Binding("Text", hocSinh, "HoTen");
            lblHoTen.DataBindings.Add(bindingHoTen);
            Binding bindingLop = new Binding("Text", hocSinh, "Lop");
            lblLop.DataBindings.Add(bindingLop);
            Binding bindingMaHS = new Binding("Text", hocSinh, "MaHS");
            lblMaHS.DataBindings.Add(bindingMaHS);
            Binding bindingNgaySinh = new Binding("Text", hocSinh, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, true, "MM/dd/yyyy");
            lblNgaySinh.DataBindings.Add(bindingNgaySinh);
        }

        private void TracNghiemMenuItem_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = _hocSinhRepository.FindByCondition(p => p.NguoiDungID.Equals(_nguoiDung.IDNguoiDung)).SingleOrDefault();
            LuaChonKiThi luaChonKiThi = new LuaChonKiThi(hocSinh);
            luaChonKiThi.ShowDialog();
        }
    }
}
