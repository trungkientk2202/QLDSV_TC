using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLDSV_TC
{
    public partial class frptBangDiemMonHoc : Form
    {
        String nienKhoa;
        String maMH;
        public frptBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void frptBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MAMH' table. You can move, or remove it, as needed.
            this.MAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MAMHTableAdapter.Fill(this.qLDSV_TCDataSet.MAMH);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.NIENKHOA' table. You can move, or remove it, as needed.
            this.NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
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

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

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
            this.MAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MAMHTableAdapter.Fill(this.qLDSV_TCDataSet.MAMH);
            this.NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbMonHoc.SelectedValue.ToString() == "System.Data.DataRowView") return;

            if (cmbNienKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            try
            {
                maMH = cmbMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
            try
            {
                nienKhoa = cmbNienKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
            XrptBANG_DIEM_MON_HOC rpt = new XrptBANG_DIEM_MON_HOC(nienKhoa, int.Parse(cmbHocKy.Text),maMH, int.Parse(cmbNhom.Text));

            rpt.lblNienKhoa.Text = nienKhoa;
            rpt.lblHocKy.Text = cmbHocKy.Text;
            rpt.lblMonHoc.Text = maMH;
            rpt.lblNhom.Text = cmbNhom.Text;
            rpt.lblKhoa.Text = cmbKhoa.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonHoc.SelectedValue == null)
                return;
            if (cmbMonHoc.SelectedValue.ToString() == "System.Data.DataRowView") return;

            try
            {
                
                maMH = cmbMonHoc.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNienKhoa.SelectedValue == null)
                return;
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
