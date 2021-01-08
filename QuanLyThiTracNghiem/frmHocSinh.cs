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
            Binding binding = new Binding("Text", hocSinh, "HoTen");
            lblHoTen.DataBindings.Add(binding);
        }
    }
}
