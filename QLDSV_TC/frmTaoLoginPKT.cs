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
    public partial class frmTaoLoginPKT : Form
    {
        public frmTaoLoginPKT()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string strlenh = " exec [dbo].[SP_TAOLOGIN] '" + txtUserName.Text.Trim() + "','" + txtPassword.Text.Trim() + "','" + txtUserName.Text.Trim() + "','PKT'";
            if (Program.ExecSqlNonQuery(strlenh) == 0)
            {
                MessageBox.Show("Thành công", "", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
