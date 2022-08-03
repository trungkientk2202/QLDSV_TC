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
    public partial class frptDanhSachDongHocPhiLop : Form
    {

        string maLop = string.Empty;
        string nienKhoa = string.Empty;
        public frptDanhSachDongHocPhiLop()
        {
            InitializeComponent();
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
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
        }

    

        private void frptDanhSachDongHocPhiLop_Load(object sender, EventArgs e)
        {
            

            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MAMH' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
            cmbHocKy.SelectedIndex = 1;
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
     

        private void tENLOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tENLOPComboBox.SelectedValue == null) return;
                if (tENLOPComboBox.SelectedValue.ToString() == "System.Data.DataRowView") return;
                maLop = tENLOPComboBox.SelectedValue.ToString();
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string nienKhoa = cmbNienKhoa.SelectedValue.ToString();
                int hocKy = Convert.ToInt32(cmbHocKy.SelectedItem.ToString());
                string maLop = tENLOPComboBox.SelectedValue.ToString();
                XrptDANH_SACH_DONG_HOC_PHI_LOP rpt = new XrptDANH_SACH_DONG_HOC_PHI_LOP(maLop,nienKhoa, hocKy);
                //XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC rpt = new XrptDANH_SACH_SINH_VIEN_DANG_KI_LTC("2021-2022", 1, "LTW", 1);

                rpt.labelTitle.Text = "Test";
                rpt.labelTitle.Text = "Danh sách sinh viên đóng học phí";
                rpt.labelKhoa.Text = "Khoa "+ cmbKhoa.Text;
                rpt.labelMaLop.Text = "Mã lớp: " + maLop;
                //rpt.lblHoTen.Text = cmbHoten.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Vui lòng chọn đủ thông tin!", "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
