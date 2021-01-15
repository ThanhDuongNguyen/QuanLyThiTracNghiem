using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem.Validate
{
    public class TenTaiKhoanValidator : BaseValidator
    {
        public TenTaiKhoanValidator()
        {
            ErrorMessage = "Tên tài khoản đã tồn tại";
        }
        public override bool Validate()
        {
            string newNguoiDung = ControlToValidate.Text;
            TextBox textBox = (TextBox)ControlToValidate;
            textBox.Undo();
            string oldNguoiDung = textBox.Text;
            textBox.Text = newNguoiDung;
            NguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
            NguoiDung tenTaiKhoang = nguoiDungRepository.FindByCondition(p => p.TenTaiKhoan.Equals(newNguoiDung) && !p.TenTaiKhoan.Equals(oldNguoiDung)).SingleOrDefault();
            if (tenTaiKhoang != null)
                return false;
            return true;
        }
    }
}
