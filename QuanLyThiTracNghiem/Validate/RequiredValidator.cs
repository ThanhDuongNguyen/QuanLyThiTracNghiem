using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem.Validate
{
    public class RequiredValidator : BaseValidator
    {
        public RequiredValidator()
        {
            ErrorMessage = "Không được để rỗng";
        }

        public override bool Validate()
        {
            return ControlToValidate.Text.Length > 0;
        }
    }
}
