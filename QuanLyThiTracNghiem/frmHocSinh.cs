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

namespace QuanLyThiTracNghiem
{
    public partial class frmHocSinh : Form
    {
        private HocSinhRepository _hocSinhRepository;
        public frmHocSinh()
        {
            InitializeComponent();
            _hocSinhRepository = new HocSinhRepository();
            LoadThongTinHocSinh();
        }

        public void LoadThongTinHocSinh()
        {
            HocSinh hocSinh = new HocSinh();

            hocSinh =_hocSinhRepository.FindByCondition(p=>p.MaHS.Equals(1)).SingleOrDefault();


            Binding bindingHoTen = new Binding("Text", hocSinh, "HoTen");
            lblHoTen.DataBindings.Add(bindingHoTen);
            Binding bindingLop = new Binding("Text", hocSinh, "Lop");
            lblLop.DataBindings.Add(bindingLop);
            Binding bindingMaHS = new Binding("Text", hocSinh, "MaHS");
            lblMaHS.DataBindings.Add(bindingMaHS);
            Binding bindingNgaySinh = new Binding("Text", hocSinh, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, true, "MM/dd/yyyy");
            lblNgaySinh.DataBindings.Add(bindingNgaySinh);
        }
    }
}
