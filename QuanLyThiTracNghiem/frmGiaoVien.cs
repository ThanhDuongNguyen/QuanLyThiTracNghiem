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
            Binding bdmaGv = new Binding("Text", giaoVien, "MaGV");
            Binding bdDchi = new Binding("Text", giaoVien, "DiaChi");
            Binding bdNsgv = new Binding("Text", giaoVien, "NgaySinh", true,DataSourceUpdateMode.OnPropertyChanged,true, "MM/dd/yyyy");
            lblHoTenGv.DataBindings.Add(binding);
            lblMaGV.DataBindings.Add(bdmaGv);
            lbDchiGv.DataBindings.Add(bdDchi);
            lblNsGv.DataBindings.Add(bdNsgv);
            
            
        }

       
    }
}
