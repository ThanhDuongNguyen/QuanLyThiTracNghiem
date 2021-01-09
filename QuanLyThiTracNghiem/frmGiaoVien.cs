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

namespace QuanLyThiTracNghiem
{
    public partial class frmGiaoVien : Form
    {
        private GiaoVienRepository _giaoVienRepository;
        public frmGiaoVien()
        {
            InitializeComponent();
            _giaoVienRepository = new GiaoVienRepository();
            LoadThongTinGiaoVien();
        }

        public void LoadThongTinGiaoVien()
        {
            GiaoVien giaoVien = new GiaoVien();

            giaoVien = _giaoVienRepository.FindByCondition(p => p.MaGV.Equals(1)).SingleOrDefault();
            Binding binding = new Binding("Text", giaoVien, "HoTen");
            lblHoTenGv.DataBindings.Add(binding);
        }

       
    }
}
