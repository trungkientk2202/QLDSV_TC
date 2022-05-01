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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddLogin_Click(object sender, EventArgs e)
        {
            
            if (txtLGName.Text.Trim() == "" || txtPass.Text.Trim() == ""||txtUserName.Text.Trim()=="")
            {
                MessageBox.Show("Login name, mật khẩu và user name không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            String role = "";
            role = cmbRole.SelectedItem.ToString();
            String strlenh = "EXEC [dbo].[SP_TAOLOGIN] '" + txtLGName.Text.Trim() + "', '"
                + txtPass.Text.Trim() + "', '"+ txtUserName.Text.Trim()+ "', '"+role+"'";
            if (Program.ExecSqlNonQuery(strlenh) == 0)
            {
                MessageBox.Show("Tạo thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                cmbRole.Items.Add("PGV");
                cmbRole.Items.Add("KHOA");
            }
            else
            {
                cmbRole.Items.Add("KHOA");
            }
        }
    }
}
