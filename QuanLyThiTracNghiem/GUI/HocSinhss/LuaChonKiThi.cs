using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.GUI.HocSinhss;
using QuanLyThiTracNghiem.Repository;

namespace QuanLyThiTracNghiem.GUI.HocSinh
{
    public partial class LuaChonKiThi : Form
    {
        KT_HSRepository _kT_HSRepository = new KT_HSRepository();
        KT_DTRepository _kT_DTRepository = new KT_DTRepository();
        KyThiRepository _kyThiRepos = new KyThiRepository();
        DeThiRepository _deThiRepos = new DeThiRepository();
        QuanLyThiTracNghiem.Data.HocSinh hocsinh;
        public LuaChonKiThi(QuanLyThiTracNghiem.Data.HocSinh hocSinh)
        {
            InitializeComponent();
            hocsinh = hocSinh;
            
            List<KT_H> kT_Hs = _kT_HSRepository.FindByCondition(p => p.MaHS.Equals(hocSinh.MaHS)).ToList();

            List<KyThi> kyThis = new List<KyThi>();
            foreach (var item in kT_Hs)
            {
                kyThis.Add(_kyThiRepos.FindByCondition(p => p.MaKT.Equals(item.MaKT)).Single());
            }

            cbKyThi.DataSource = kyThis;
            cbKyThi.DisplayMember = "TenKT";
            cbKyThi.ValueMember = "MaKT";

            cbDeThi.DropDown += CbDeThi_DropDown;
        }

        private void CbDeThi_DropDown(object sender, System.EventArgs e)
        {
            List<KT_DT> _kT_DTs = _kT_DTRepository.FindByCondition(p => p.MaKT.Equals(cbKyThi.SelectedValue.ToString())).ToList();

            List<DeThi> deThis = new List<DeThi>();
            foreach (var item in _kT_DTs)
            {
                deThis.Add(_deThiRepos.FindByCondition(p => p.MaDeThi.Equals(item.MaDT)).Single());
            }

            cbDeThi.DataSource = deThis;
            cbDeThi.DisplayMember = "TenDeThi";
            cbDeThi.ValueMember = "MaDeThi";
        }

        private void btnXacNhan_Click(object sender, System.EventArgs e)
        {
            KyThi kyThi = _kyThiRepos.FindByCondition(p => p.MaKT.Equals(cbKyThi.SelectedValue.ToString())).Single();
            DeThi deThi = _deThiRepos.FindByCondition(p => p.MaDeThi.Equals(cbDeThi.SelectedValue.ToString())).Single();
            LamTracNgiemHS lamTracNgiemHS = new LamTracNgiemHS(kyThi, deThi, hocsinh);
            lamTracNgiemHS.ShowDialog();
        }
    }
}
