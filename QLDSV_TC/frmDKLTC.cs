using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmDKLTC : Form
    {
        public frmDKLTC()
        {
            InitializeComponent();
        }



        private void frmDKLTC_Load(object sender, EventArgs e)
        {

            qLDSV_TCDataSet.EnforceConstraints = false;
            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.NIENKHOA);
            cmbHocki.SelectedIndex = 0;

        }

        private void btnTimLTC_Click(object sender, EventArgs e)
        {
            String nienKhoa = cmbNienKhoa.SelectedValue.ToString();
            String hocKi = cmbHocki.Text;
            String strlenh = "exec [dbo].[GET_LOP_TIN_CHI_BY_NIEN_KHOA_AND_HOC_KY] '" + nienKhoa + "',"+hocKi+",'"+Program.username+"'" ;
            MessageBox.Show(strlenh);
            DataTable dt = Program.ExecSqlDataTable(strlenh);
            if (Program.myReader == null)
            {
                MessageBox.Show("Lỗi tra cứu, bạn xem lại niên khóa và học kì", "", MessageBoxButtons.OK);
                return;
            };
            dgvDKLTC.DataSource = dt;
        }

        private void btnDKLTC_Click(object sender, EventArgs e)
        {
            String strlenh = "Declare @dk as DanhSachDangKiNew ";
            //String strlenh1 = "Declare @dk as DanhSachDangKi ";
            for (int i = 0; i < dgvDKLTC.Rows.Count-1;i++)
            {

                String maLTC =dgvDKLTC.Rows[i].Cells[0].Value.ToString();
                if (dgvDKLTC.Rows[i].Cells[6].Value.ToString().Equals("False"))
                {
                    strlenh+="insert into @dk(MALTC, MASV, LOAI) values(" + maLTC + ", '" + Program.username + "',0)";//Huy
                    
                }
                else
                {
                    strlenh += "insert into @dk(MALTC, MASV, LOAI) values(" + maLTC + ", '" + Program.username + "',1)";//Dang ky
                }
                
            }
            //strlenh += "exec HUY_DANG_KI_LTC @DS = @dk";
            strlenh += "exec DANG_KI_LTC @DS = @dk";
            Program.ExecSqlNonQuery(strlenh);
            //Program.ExecSqlNonQuery(strlenh1);
            MessageBox.Show("Đăng kí thành công", "", MessageBoxButtons.OK);
            
            return;
        }
    }
}
