using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem.Utils
{
    public class CheckListBoxItem
    {
        public string Tag;
        public string Text;
        public string GoiY;
        public string CauHoi;
        public string CauTL1;
        public string CauTL2;
        public string CauTL3;
        public string CauTL4;
        public string CauTL5;
        public string CauTL6;
        public bool IsDung1 = false;
        public bool IsDung2 = false;
        public bool IsDung3 = false;
        public bool IsDung4 = false;
        public bool IsDung5 = false;
        public bool IsDung6 = false;
        public override string ToString() { return Text; }
    }
}
