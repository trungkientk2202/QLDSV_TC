using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frptDanhSachSinhVienDangKyLTC : Form
    {
        string maMonHoc = string.Empty;
        string nienKhoa = string.Empty;
        public frptDanhSachSinhVienDangKyLTC()
        {
            InitializeComponent();
        }

        private void frptDanhSachSinhVienDangKyLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MAMH' table. You can move, or remove it, as needed.
            this.mAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAMHTableAdapter.Fill(this.qLDSV_TCDataSet.MAMH);
            cmbKhoa.DataSource = Program.bds_dspm; //sao chep bds_pm o form dang nhap
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới.\n", "", MessageBoxButtons.OK);
            }
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
            this.mAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAMHTableAdapter.Fill(this.qLDSV_TCDataSet.MAMH);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string nienKhoa = this.nienKhoa;
                int hocKy = Convert.ToInt32(cmbHocKy.SelectedItem.ToString());
                string maMonHoc = this.maMonHoc;
                int nhom = Convert.ToInt32(NhomCB.SelectedItem.ToString());
                XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC rpt = new XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC(nienKhoa, hocKy, maMonHoc, nhom);
                //XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC rpt = new XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC("2021-2022", 1, "LTW", 1);

                rpt.labelTieuDe.Text = "Test";
                //rpt.lblHoTen.Text = cmbHoten.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }

            catch (Exception)
            {
                MessageBox.Show("VUi lòng chọn đủ thông tin!", "", MessageBoxButtons.OK);
                return;
            }
            

        }

        private void TenMonHocCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaMH.SelectedValue != null)
                    maMonHoc = cmbMaMH.SelectedValue.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienKhoa.SelectedValue == null) return;
            if (cmbNienKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            try
            {

                nienKhoa = cmbNienKhoa.SelectedValue.ToString();

            }
            catch (Exception ex)
            {

            }

        }
    }
}
