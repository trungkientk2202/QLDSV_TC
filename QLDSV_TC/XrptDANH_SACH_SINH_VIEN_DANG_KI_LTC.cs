using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC()
        {
            InitializeComponent();
        }

        public XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC(string nienKhoa, int hocKy, string maMonHoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMonHoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }

    }
}
