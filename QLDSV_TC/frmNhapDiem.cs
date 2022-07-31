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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MAMH' table. You can move, or remove it, as needed.
            this.mAMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mAMHTableAdapter.Fill(this.qLDSV_TCDataSet.MAMH);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.NIENKHOA' table. You can move, or remove it, as needed.
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);

            cmbKhoa.DataSource = Program.bds_dspm; //sao chep bds_pm o form dang nhap
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            cmbHocki.SelectedIndex = 0;
            cmbNhom.SelectedIndex = 0;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            String nienKhoa = cmbNienKhoa.SelectedValue.ToString();
            String hocKi = cmbHocki.Text;
            String monHoc = cmbMaMH.SelectedValue.ToString();
            String nhom = cmbNhom.Text;
            String strlenh = "exec dbo.SP_DanhSachSinhVienDangKiLopTinChi '" + nienKhoa + "'," + hocKi + ",'" + monHoc + "'," + nhom;
            DataTable dt = Program.ExecSqlDataTable(strlenh);
            if (Program.myReader == null)
            {
                MessageBox.Show("Lỗi tra cứu, bạn xem lại niên khóa, học kì, môn học, nhóm", "", MessageBoxButtons.OK);
                return;
            };
            dgvDiem.DataSource = dt;
            dgvDiem.Columns[6].Visible = false;
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
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
            {
                try
                {
                    dgvDiem.Rows[i].Cells[5].Value = (float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString()) * 0.1
                    + float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()) * 0.3 + float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString()) * 0.6).ToString();
                }
                catch (Exception ex) { }

            }
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            String strlenh = "Declare @testGhiDiem as [dbo].[DiemSV]";
            for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
            {

                strlenh += " insert into @testGhiDiem(MASV, DIEM_CC, DIEM_GK, DIEM_CK) values('" + dgvDiem.Rows[i].Cells[0].Value + "', " + (float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString())) + ", " + (float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()))
                    + ", " + (float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString())) + ")";


            }
            strlenh += " exec[dbo].[SP_GHI_DIEM] " + int.Parse(dgvDiem.Rows[0].Cells[6].Value.ToString()) + ",@testGhiDiem";
            Program.ExecSqlNonQuery(strlenh);
            MessageBox.Show("Nhập điểm thành công", "", MessageBoxButtons.OK);

        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
                {
                    if (!(dgvDiem.Rows[i].Cells[2].Value.ToString() is null || dgvDiem.Rows[i].Cells[3].Value.ToString() is null || dgvDiem.Rows[i].Cells[4].Value.ToString() is null))
                    {
                        dgvDiem.Rows[i].Cells[5].Value = (float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString()) * 0.1
                        + float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()) * 0.3 + float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString()) * 0.6).ToString();
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter|| e.KeyCode == Keys.Tab)
            {
                try
                {
                    for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
                    {
                        if (!(dgvDiem.Rows[i].Cells[2].Value.ToString() is null || dgvDiem.Rows[i].Cells[3].Value.ToString() is null || dgvDiem.Rows[i].Cells[4].Value.ToString() is null))
                        {
                            dgvDiem.Rows[i].Cells[5].Value = (float.Parse(dgvDiem.Rows[i].Cells[2].Value.ToString()) * 0.1
                            + float.Parse(dgvDiem.Rows[i].Cells[3].Value.ToString()) * 0.3 + float.Parse(dgvDiem.Rows[i].Cells[4].Value.ToString()) * 0.6).ToString();
                        }

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
