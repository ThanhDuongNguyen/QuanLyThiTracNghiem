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
    public class MaGVValidator : BaseValidator
    {
        public MaGVValidator()
        {
            ErrorMessage = "Mã giáo viên đã tồn tại";
        }
        public override bool Validate()
        {
            string newMaGV = ControlToValidate.Text;
            TextBox textBox = (TextBox)ControlToValidate;
            textBox.Undo();
            string oldMaGV = textBox.Text;
            textBox.Text = newMaGV;
            GiaoVienRepository giaoVienRepository = new GiaoVienRepository();
            GiaoVien giaoVien = giaoVienRepository.FindByCondition(p => p.MaGV.Equals(newMaGV) && !p.MaGV.Equals(oldMaGV)).SingleOrDefault();
            if (giaoVien != null)
                return false;
            return true;
        }
    }
}
