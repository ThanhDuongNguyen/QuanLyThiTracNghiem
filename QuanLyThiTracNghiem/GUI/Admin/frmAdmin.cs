using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyThiTracNghiem.Utils.Utils;

namespace QuanLyThiTracNghiem
{

    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            tcAdmin.TabPages.Clear();
        }

        private void HienTabPage(QuanLyTabPage tabPage)
        {
            foreach (TabPage i in tcAdmin.TabPages)
            {
                if (i.Tag.Equals(tabPage.ToString()))
                {
                    tcAdmin.SelectedTab = i;
                    return;
                }
                else if (i.Tag.Equals(tabPage.ToString()))
                {
                    tcAdmin.SelectedTab = i;
                    return;
                }
                else if (i.Tag.Equals(tabPage.ToString()))
                {
                    tcAdmin.SelectedTab = i;
                    return;
                }
            }
            switch (tabPage)
            {
                case QuanLyTabPage.QuanLyHocSinh:
                    tcAdmin.TabPages.Add(tpQuanLyHocSinh);
                    tcAdmin.SelectedTab = tpQuanLyHocSinh;
                    break;
                case QuanLyTabPage.QuanLyGiaoVien:
                    tcAdmin.TabPages.Add(tpQuanLyGiaoVien);
                    tcAdmin.SelectedTab = tpQuanLyGiaoVien;

                    break;
                case QuanLyTabPage.KetQuaThi:
                    tcAdmin.TabPages.Add(tpKetQuaThi);
                    tcAdmin.SelectedTab = tpKetQuaThi;

                    break;
                default:
                    break;
            }
        }
        private void DanhSachGiaoVienMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyGiaoVien);
        }

        private void DanhSachHocSinhMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.QuanLyHocSinh);
        }

        private void KetQuaMenuItem_Click(object sender, EventArgs e)
        {
            HienTabPage(QuanLyTabPage.KetQuaThi);
        }

    }
}
