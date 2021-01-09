using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem.Services
{
    public class AuthService
    {
        private NguoiDungRepository _nguoiDungRepository = new NguoiDungRepository();
        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDung nguoiDung = _nguoiDungRepository.FindByCondition(p => p.TenTaiKhoan.Equals(tenDangNhap)
            && p.MatKhauHash.Equals(matKhau)).SingleOrDefault();
            return nguoiDung;
        }

        public HocSinh LayThongTinHocSinh(int idNguoiDung)
        {
            HocSinhRepository hocSinhRepository = new HocSinhRepository();
            return hocSinhRepository.FindByCondition(p => p.NguoiDungID.Equals(idNguoiDung)).Single();
        }
        public GiaoVien LayThongTinGiaoVien(int idNguoiDung)
        {
            GiaoVienRepository giaoVienRepository = new GiaoVienRepository();
            return giaoVienRepository.FindByCondition(p => p.NguoiDungID.Equals(idNguoiDung)).Single();
        }

    }
}
