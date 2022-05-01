using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptDanhSachLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDanhSachLTC()
        {
            InitializeComponent();
        }
        public XrptDanhSachLTC(String nienKhoa,int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Fill();
        }
    }
}
