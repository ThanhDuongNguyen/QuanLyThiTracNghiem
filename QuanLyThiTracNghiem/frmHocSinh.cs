﻿using QuanLyThiTracNghiem.Data;
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
using System.Configuration;

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
            Binding bdmaHS = new Binding("Text", hocSinh, "MaHS");
            Binding bdLop = new Binding("Text", hocSinh, "Lop");
            Binding bdNgs = new Binding("Text", hocSinh, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, true, "MM/dd/yyyy");           
            lblHoTen.DataBindings.Add(binding);
            lblMaHS.DataBindings.Add(bdmaHS);
            lblLop.DataBindings.Add(bdLop);
            lblNgaySinh.DataBindings.Add(bdNgs);
            
        } 
    }
}
