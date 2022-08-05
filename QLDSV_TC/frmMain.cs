using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_TC
{  

    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void closeDiffrentForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() != ftype && f.GetType() != typeof(frmMain) && f.GetType() != typeof(frptDanhSachLTC) && f.GetType() != typeof(frptBangDiemMonHoc))
                {
                    f.Close();
                }
                   
            
        }

        public frmMain()
        {
            InitializeComponent();
            QuanLy.Visible= TuyChon.Visible=BaoCao.Visible = false;
            btnDangXuat.Enabled =btnDangKy.Enabled= false;
        }

        private void DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmDangNhap));
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            if (Program.mGroup == "PKT")
            {
                MANV.Text = "Mã NV: " + Program.username;
                HOTEN.Text = "Họ tên: " + Program.username;
                NHOM.Text = "Phòng: " + Program.mGroup;
                btnDangKy.Enabled = false;
                QuanLy.Visible = MoLTC.Enabled = NhapDiem.Enabled = BaoCao.Visible = DangKyLTC.Enabled = DongHocPhi.Enabled = false;
                DongHocPhi.Enabled = TuyChon.Visible = true;
                return;
            }
            if (Program.mGroup != "PGV"&& Program.mGroup != "KHOA")
            {
                MANV.Text = "Mã SV: " + Program.username;
                HOTEN.Text = "Họ tên: " + Program.mHoTen;
                NHOM.Text = "Lớp: " + Program.mGroup;
                btnDangKy.Enabled = false;
                QuanLy.Visible = MoLTC.Enabled=NhapDiem.Enabled= BaoCao.Visible = false;
                TuyChon.Visible = DangKyLTC.Enabled = true;//= DongHocPhi.Enabled= true;
                return;
            }
            
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên: " + Program.mHoTen;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            btnDangKy.Enabled=QuanLy.Visible =TuyChon.Visible= NhapDiem.Enabled = BaoCao.Visible = true;
            DangKyLTC.Enabled = false;// DongHocPhi.Enabled = false;
            //Phân quyền
        }

        private void Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmLop));
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmMonHoc));
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanLy.Visible = TuyChon.Visible =  false;
            BaoCao.Visible = false;
            btnDangXuat.Enabled = false;
            btnDangNhap.Enabled = true;
            MANV.Text = "";
            HOTEN.Text = "";
            NHOM.Text = "";
            closeDiffrentForm(typeof(frmDangNhap));
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void LopTinChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmLTC));
            Form frm = this.CheckExists(typeof(frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmLTC f = new frmLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmDangKy));
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void SinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmSinhVien));
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void DangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmDKLTC));
            Form frm = this.CheckExists(typeof(frmDKLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDKLTC f = new frmDKLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void NhapDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmNhapDiem));
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frptDanhSachLTC));
            Form frm = this.CheckExists(typeof(frptDanhSachLTC));
            if (frm != null) frm.Activate();
            else
            {
                frptDanhSachLTC f = new frptDanhSachLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MoLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmLTC));
            Form frm = this.CheckExists(typeof(frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmLTC f = new frmLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frptBangDiemMonHoc));
            Form frm = this.CheckExists(typeof(frptBangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frptBangDiemMonHoc f = new frptBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void GiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void DongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frmDongHocPhi));
            Form frm = this.CheckExists(typeof(frmDongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmDongHocPhi f = new frmDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPrintStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frptDanhSachSinhVienDangKyLTC));
            Form frm = this.CheckExists(typeof(frptDanhSachSinhVienDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frptDanhSachSinhVienDangKyLTC f = new frptDanhSachSinhVienDangKyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            closeDiffrentForm(typeof(frptDanhSachDongHocPhiLop));
            Form frm = this.CheckExists(typeof(frptDanhSachDongHocPhiLop));
            if (frm != null) frm.Activate();
            else
            {
                frptDanhSachDongHocPhiLop f = new frptDanhSachDongHocPhiLop();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
