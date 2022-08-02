
namespace QLDSV_TC
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Lop = new DevExpress.XtraBars.BarButtonItem();
            this.LopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.MonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.GiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.SinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.DangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.NhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.MoLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.DongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintStudent = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ToChuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CaNhan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TuyChon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Lop,
            this.LopTinChi,
            this.MonHoc,
            this.GiangVien,
            this.SinhVien,
            this.DangKyLTC,
            this.NhapDiem,
            this.btnDangNhap,
            this.btnDangKy,
            this.MoLTC,
            this.btnDangXuat,
            this.DongHocPhi,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem1,
            this.btnPrintStudent,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.QuanLy,
            this.TuyChon,
            this.BaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 164);
            // 
            // Lop
            // 
            this.Lop.Caption = "Lớp";
            this.Lop.Id = 2;
            this.Lop.Name = "Lop";
            this.Lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Lop_ItemClick);
            // 
            // LopTinChi
            // 
            this.LopTinChi.Caption = "Lớp tín chỉ";
            this.LopTinChi.Id = 3;
            this.LopTinChi.Name = "LopTinChi";
            this.LopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LopTinChi_ItemClick);
            // 
            // MonHoc
            // 
            this.MonHoc.Caption = "Môn học";
            this.MonHoc.Id = 4;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MonHoc_ItemClick);
            // 
            // GiangVien
            // 
            this.GiangVien.Caption = "Giảng viên";
            this.GiangVien.Id = 5;
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GiangVien_ItemClick);
            // 
            // SinhVien
            // 
            this.SinhVien.Caption = "Sinh viên";
            this.SinhVien.Id = 6;
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SinhVien_ItemClick);
            // 
            // DangKyLTC
            // 
            this.DangKyLTC.Caption = "Đăng ký lớp tín chỉ";
            this.DangKyLTC.Id = 7;
            this.DangKyLTC.Name = "DangKyLTC";
            this.DangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangKyLTC_ItemClick);
            // 
            // NhapDiem
            // 
            this.NhapDiem.Caption = "Nhập điểm";
            this.NhapDiem.Id = 8;
            this.NhapDiem.Name = "NhapDiem";
            this.NhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhapDiem_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 9;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangNhap_ItemClick);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Id = 10;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // MoLTC
            // 
            this.MoLTC.Caption = "Mở lớp tín chỉ";
            this.MoLTC.Id = 11;
            this.MoLTC.Name = "MoLTC";
            this.MoLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MoLTC_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 12;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // DongHocPhi
            // 
            this.DongHocPhi.Caption = "Đóng học phí";
            this.DongHocPhi.Id = 13;
            this.DongHocPhi.Name = "DongHocPhi";
            this.DongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DongHocPhi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In danh sách lớp tín chỉ";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "In bảng điểm môn học";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 16;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnPrintStudent
            // 
            this.btnPrintStudent.Caption = "In danh sách sinh viên đăng kí lớp tín chỉ";
            this.btnPrintStudent.Id = 17;
            this.btnPrintStudent.Name = "btnPrintStudent";
            this.btnPrintStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintStudent_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeThong.Appearance.Options.UseFont = true;
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // QuanLy
            // 
            this.QuanLy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLy.Appearance.Options.UseFont = true;
            this.QuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ToChuc,
            this.CaNhan});
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.Text = "Quản lý";
            // 
            // ToChuc
            // 
            this.ToChuc.ItemLinks.Add(this.Lop);
            this.ToChuc.ItemLinks.Add(this.LopTinChi);
            this.ToChuc.ItemLinks.Add(this.MonHoc);
            this.ToChuc.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ToChuc.Name = "ToChuc";
            this.ToChuc.Text = "Tổ chức";
            // 
            // CaNhan
            // 
            this.CaNhan.ItemLinks.Add(this.GiangVien);
            this.CaNhan.ItemLinks.Add(this.SinhVien);
            this.CaNhan.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.CaNhan.Name = "CaNhan";
            this.CaNhan.Text = "Cá Nhân";
            // 
            // TuyChon
            // 
            this.TuyChon.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuyChon.Appearance.Options.UseFont = true;
            this.TuyChon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ChucNang});
            this.TuyChon.Name = "TuyChon";
            this.TuyChon.Text = "Tùy chọn";
            // 
            // ChucNang
            // 
            this.ChucNang.ItemLinks.Add(this.DangKyLTC);
            this.ChucNang.ItemLinks.Add(this.NhapDiem);
            this.ChucNang.ItemLinks.Add(this.DongHocPhi);
            this.ChucNang.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Text = "Chức năng";
            // 
            // BaoCao
            // 
            this.BaoCao.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCao.Appearance.Options.UseFont = true;
            this.BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Lớp tín chỉ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrintStudent);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sinh viên";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1137, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(42, 17);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "In bảng điểm môn học";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "In bảng điểm môn học";
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "In bảng điểm môn học";
            this.barButtonItem5.Id = 15;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Học phí";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "In danh sách sinh viên đóng học phí ";
            this.barButtonItem6.Id = 18;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage QuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ToChuc;
        private DevExpress.XtraBars.BarButtonItem Lop;
        private DevExpress.XtraBars.BarButtonItem LopTinChi;
        private DevExpress.XtraBars.BarButtonItem MonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage TuyChon;
        private DevExpress.XtraBars.Ribbon.RibbonPage BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem GiangVien;
        private DevExpress.XtraBars.BarButtonItem SinhVien;
        private DevExpress.XtraBars.BarButtonItem DangKyLTC;
        private DevExpress.XtraBars.BarButtonItem NhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CaNhan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ChucNang;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem MoLTC;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem DongHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

