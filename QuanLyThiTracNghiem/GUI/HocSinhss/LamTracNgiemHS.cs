﻿using QuanLyThiTracNghiem.Data;
using QuanLyThiTracNghiem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem.GUI.HocSinhss
{
    public partial class LamTracNgiemHS : Form
    {
        private KyThi _kythi;
        private DeThi deThi;
        private QuanLyThiTracNghiem.Data.HocSinh hocsinh;
        public LamTracNgiemHS(KyThi kyThi, DeThi deThi, QuanLyThiTracNghiem.Data.HocSinh hs)
        {
            InitializeComponent();
            this._kythi = kyThi;
            this.deThi = deThi;
            this.hocsinh = hs;

            time = int.Parse(deThi.ThoiGian.ToString()) *60;
            LoadThongTin();
            LoadCheckList();
            checklist.SelectedIndexChanged += Checklist_SelectedIndexChanged;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox1_CheckedChanged;
            Runtimecount();
        }
        private System.Windows.Forms.Timer aTimer;
        private int time;
        private void Runtimecount()
        {
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(aTimer_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();

            lblTime.Text = time.ToString();
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            time--;

            if (time == 0)
            {
                aTimer.Stop();
                btnNop_Click(sender, e);
            }
                

            lblTime.Text = time.ToString();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckListBoxItem cl = checklist.SelectedItem as CheckListBoxItem;
            CheckBox checkBox = sender as CheckBox;
            switch (int.Parse(checkBox.Tag.ToString()))
            {
                case 1:
                    cl.IsDung1 = checkBox.Checked;
                    break;
                case 2:
                    cl.IsDung2 = checkBox.Checked;
                    break;
                case 3:
                    cl.IsDung3 = checkBox.Checked;
                    break;
                case 4:
                    cl.IsDung4 = checkBox.Checked;
                    break;
                case 5:
                    cl.IsDung5 = checkBox.Checked;
                    break;
                case 6:
                    cl.IsDung6 = checkBox.Checked;
                    break;
                default:
                    break;
            }

            List<bool> vs = new List<bool>();
            vs.Add(cl.IsDung1);
            vs.Add(cl.IsDung2);
            vs.Add(cl.IsDung3);
            vs.Add(cl.IsDung4);
            vs.Add(cl.IsDung5);
            vs.Add(cl.IsDung6);
            foreach (var item in vs)
            {
                if (item == true)
                {
                    checklist.SetItemChecked(checklist.SelectedIndex, true);
                    return;
                }
            }
            checklist.SetItemChecked(checklist.SelectedIndex, false);

        }

        private void LoadThongTin()
        {
            lblLop.Text = hocsinh.Lop;
            lblMaKT.Text = _kythi.MaKT;
            lblMonThi.Text = deThi.MaMH;
            lblDeThi.Text = deThi.MaDeThi;
            lblTenKT.Text = _kythi.TenKT;
            lblThoiGian.Text = deThi.ThoiGian.ToString();
        }

        QuanLyThiDataContext quanLyThiDataContext = new QuanLyThiDataContext();
        private void LoadCheckList()
        {

            List<DeThi_CauHoi> deThi_CauHois = quanLyThiDataContext.DeThi_CauHois.Where(p => p.MaDT.Equals(deThi.MaDeThi)).ToList();
            int i = 1;
            foreach (var item in deThi_CauHois)
            {
                CheckListBoxItem checkListBoxItem = new CheckListBoxItem();
                checkListBoxItem.Text = "Câu: " + i.ToString();
                CauHoi cauHoi = quanLyThiDataContext.CauHois.Where(p => p.IDCauHoi.Equals(item.IDCauHoi)).Single();
                checkListBoxItem.CauHoi = cauHoi.CauHoiDeBai;
                checkListBoxItem.GoiY = cauHoi.GoiY;
                List<DapAn> dapAns = quanLyThiDataContext.DapAns.Where(p => p.IDCauHoi.Equals(cauHoi.IDCauHoi)).ToList();
                foreach (DapAn da in dapAns)
                {
                    switch (da.STTDapAn)
                    {
                        case 1:
                            checkListBoxItem.CauTL1 = da.DapAnCauHoi;
                            break;
                        case 2:
                            checkListBoxItem.CauTL2 = da.DapAnCauHoi;
                            break;
                        case 3:
                            checkListBoxItem.CauTL3 = da.DapAnCauHoi;
                            break;
                        case 4:
                            checkListBoxItem.CauTL4 = da.DapAnCauHoi;
                            break;
                        case 5:
                            checkListBoxItem.CauTL5 = da.DapAnCauHoi;
                            break;
                        case 6:
                            checkListBoxItem.CauTL6 = da.DapAnCauHoi;
                            break;
                        default:
                            break;
                    }
                }

                checklist.Items.Add(checkListBoxItem, false);
                i++;
            }

        }

        private void Checklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCauHoi.Text = "";
            checkBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Text = "";
            checkBox2.Checked = false;
            checkBox3.Text = "";
            checkBox3.Checked = false;
            checkBox4.Text = "";
            checkBox4.Checked = false;
            checkBox5.Text = "";
            checkBox5.Checked = false;
            checkBox6.Text = "";
            checkBox6.Checked = false;

            CheckListBoxItem cl = checklist.SelectedItem as CheckListBoxItem;
            lblGoiY.Text = cl.GoiY;
            lblCauHoi.Text = cl.CauHoi;
            checkBox1.Text = cl.CauTL1;
            checkBox1.Checked = cl.IsDung1;
            checkBox2.Text = cl.CauTL2;
            checkBox2.Checked = cl.IsDung2;
            checkBox3.Text = cl.CauTL3;
            checkBox3.Checked = cl.IsDung3;
            checkBox4.Text = cl.CauTL4;
            checkBox4.Checked = cl.IsDung4;
            checkBox5.Text = cl.CauTL5;
            checkBox5.Checked = cl.IsDung5;
            checkBox6.Text = cl.CauTL6;
            checkBox6.Checked = cl.IsDung6;
        }

        private int Socaudung()
        {

            int soCauDung = 0;

            List<DeThi_CauHoi> deThi_CauHois = quanLyThiDataContext.DeThi_CauHois.Where(p => p.MaDT.Equals(deThi.MaDeThi)).ToList();
            foreach (var i in deThi_CauHois)
            {
                List<DapAn> dapAns = quanLyThiDataContext.DapAns.Where(p => p.IDCauHoi.Equals(i.IDCauHoi) && p.IsDung == true).ToList();
                List<CauTraLoi> cauTraLois = quanLyThiDataContext.CauTraLois.Where(p =>
            p.NguoiDungID.Equals(hocsinh.NguoiDungID)
            && p.MaDeThi.Equals(deThi.MaDeThi)
            && p.MaKyThi.Equals(_kythi.MaKT)
            && p.CauHoiID.Equals(i.IDCauHoi)).ToList();
                if (cauTraLois.Count == 0)
                    continue;
                if(kiemtradapan(cauTraLois, dapAns))
                {
                    soCauDung++;
                }
            }
            return soCauDung;
        }

        private float tinhdiem()
        {
            int soCauDung = 0;

            List<DeThi_CauHoi> deThi_CauHois = quanLyThiDataContext.DeThi_CauHois.Where(p => p.MaDT.Equals(deThi.MaDeThi)).ToList();
            foreach (var i in deThi_CauHois)
            {
                List<DapAn> dapAns = quanLyThiDataContext.DapAns.Where(p => p.IDCauHoi.Equals(i.IDCauHoi) && p.IsDung == true).ToList();
                List<CauTraLoi> cauTraLois = quanLyThiDataContext.CauTraLois.Where(p =>
            p.NguoiDungID.Equals(hocsinh.NguoiDungID)
            && p.MaDeThi.Equals(deThi.MaDeThi)
            && p.MaKyThi.Equals(_kythi.MaKT)
            && p.CauHoiID.Equals(i.IDCauHoi)).ToList();
                if (cauTraLois.Count == 0)
                    continue;
                if (kiemtradapan(cauTraLois, dapAns))
                {
                    soCauDung++;
                }
            }
            int count = deThi_CauHois.Count;
            return (10/count)*soCauDung;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            foreach (var item in checklist.Items)
            {
                CheckListBoxItem cl = item as CheckListBoxItem;
                if (cl.IsDung1)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 1,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }

                if (cl.IsDung2)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 2,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }

                if (cl.IsDung3)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 3,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }

                if (cl.IsDung4)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 4,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }

                if (cl.IsDung5)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 5,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }
                if (cl.IsDung6)
                {
                    quanLyThiDataContext.CauTraLois.InsertOnSubmit(new CauTraLoi
                    {
                        NguoiDungID = hocsinh.NguoiDungID,
                        MaDeThi = deThi.MaDeThi,
                        DapAn = 6,
                        MaKyThi = _kythi.MaKT,
                        CauHoiID = quanLyThiDataContext.CauHois.Where(p => p.CauHoiDeBai.Equals(cl.CauHoi)).Single().IDCauHoi
                    });
                    quanLyThiDataContext.SubmitChanges();
                }
            }

            


            int total = quanLyThiDataContext.DeThi_CauHois.Where(p => p.MaDT.Equals(deThi.MaDeThi)).ToList().Count;
            int socaudung = Socaudung();
            float diem = tinhdiem();
            quanLyThiDataContext.BaiLamHs.InsertOnSubmit(new BaiLamH
            {
                MaNguoiDung = hocsinh.NguoiDungID,
                MaKT = _kythi.MaKT,
                MaDT = deThi.MaDeThi,
                DiemThi = diem.ToString()
            });

            MessageBox.Show($"Số câu đúng : {socaudung}/{total}\n" +
                $"Số điểm : {diem}");

            this.Close();
        }

        private bool kiemtradapan(List<CauTraLoi> dapan, List<DapAn> dapandung)
        {
            int total = dapandung.Count;
            int i = 0;
            foreach (CauTraLoi da in dapan)
            {
                foreach (DapAn dadung in dapandung)
                {
                    if (da.DapAn == dadung.STTDapAn)
                        i++;
                }
            }
            if (total != i)
                return false;
            return true;
        }
    }
}
