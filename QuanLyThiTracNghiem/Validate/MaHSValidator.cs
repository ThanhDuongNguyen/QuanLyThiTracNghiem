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
    public class MaHSValidator : BaseValidator
    {
        public MaHSValidator()
        {
            ErrorMessage = "Mã học sinh đã tồn tại";
        }
        public override bool Validate()
        {
            string newMaHS = ControlToValidate.Text;
            TextBox textBox = (TextBox)ControlToValidate;
            textBox.Undo();
            string oldMaHS = textBox.Text;
            textBox.Text = newMaHS;
            HocSinhRepository hocSinhRepository = new HocSinhRepository();
            HocSinh hocSinh = hocSinhRepository.FindByCondition(p => p.MaHS.Equals(newMaHS) && !p.MaHS.Equals(oldMaHS)).SingleOrDefault();
            if (hocSinh != null)
                return false;
            return true;
        }
    }
}
