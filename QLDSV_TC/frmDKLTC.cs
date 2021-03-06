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

        }

        private void btnTimLTC_Click(object sender, EventArgs e)
        {
            String nienKhoa = txtNienKhoa.Text;
            String hocKi = txtHocKi.Text;
            String strlenh = "exec [dbo].[GET_LOP_TIN_CHI_BY_NIEN_KHOA_AND_HOC_KY] '" + nienKhoa + "',"+hocKi+",'"+Program.username+"'" ;
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
            String strlenh = "Declare @dk as DanhSachDangKi ";
            String strlenh1 = "Declare @dk as DanhSachDangKi ";
            for (int i = 0; i < dgvDKLTC.Rows.Count-1;i++)
            {

                String maLTC =dgvDKLTC.Rows[i].Cells[0].Value.ToString();
                if (dgvDKLTC.Rows[i].Cells[6].Value.ToString().Equals("False"))
                {
                    strlenh+="insert into @dk(MALTC, MASV) values(" + maLTC + ", '" + Program.username + "')";
                    
                }
                else
                {
                    strlenh1 += "insert into @dk(MALTC, MASV) values(" + maLTC + ", '" + Program.username + "')";
                }
                
            }
            strlenh += "exec HUY_DANG_KI_LTC @DS = @dk";
            strlenh1 += "exec DANG_KI_LTC @DS = @dk";
            Program.ExecSqlNonQuery(strlenh);
            Program.ExecSqlNonQuery(strlenh1);
            MessageBox.Show("Đăng kí thành công", "", MessageBoxButtons.OK);
            
            return;
        }
    }
}
