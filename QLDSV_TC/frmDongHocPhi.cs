using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDongHocPhi : Form
    {
        private string strCurrentMSV = string.Empty;
        private DataRowView currentDataRowView = null;
        public frmDongHocPhi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        //private void gridDSLopTinChi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int intSelected = ((GridView)gridDSLopTinChi.MainView).GetSelectedRows()[0];
        //        DataRowView selRow = (DataRowView)(((GridView)gridDSLopTinChi.MainView).GetRow(intSelected));
        //        frmNhapHocPhi frmNhapHocPhi = new frmNhapHocPhi();
        //        frmNhapHocPhi.strNienKhoa = selRow["NIENKHOA"].ToString();
        //        frmNhapHocPhi.intHocKy = Convert.ToInt32(selRow["HOCKY"]);
        //        frmNhapHocPhi.ShowDialog();

        //    }
        //    catch(Exception objEx)
        //    {
        //        MessageBox.Show("Lỗi " + objEx);
        //    }

        //}

        private void gridDSLopTinChi_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(sender != null && e != null)
                    strCurrentMSV = txtMSV.Text.Trim();

                this.sP_DanhSachHocPHiTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sP_DanhSachHocPHiTableAdapter1.Fill(this.qLDSV_TCDataSet4.SP_DanhSachHocPHi, strCurrentMSV);
                int intRowCount = ((GridView)gridHocPhi.MainView).RowCount;
                
            }
            catch
            {

            }

        }

        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int intRowCount = ((GridView)gridHocPhi.MainView).RowCount;
            //    for (int i = 0; i < intRowCount; i++)
            //    {
            //        DataRowView selRow = (DataRowView)(((GridView)gridHocPhi.MainView).GetRow(i));
            //        //if(Convert.ToDecimal(selRow["HOCPHI"]) < Convert.ToDecimal(selRow["DADONG"]))
            //        //{
            //        //    MessageBox.Show("Vui lòng nhập số tiền học phí lớn hơn số tiền đã đóng");
            //        //    btnSave.Enabled = false;
            //        //    return;
            //        //}
            //        selRow["CONLAI"] = Convert.ToDecimal(selRow["HOCPHI"]) - Convert.ToDecimal(selRow["DADONG"]);

            //    }
            //}
            //catch (Exception objEx)
            //{
            //    MessageBox.Show("Vui lòng nhập đúng định dạng!");
            //}
        }

        private void gridHocPhi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                int intSelected = ((GridView)gridHocPhi.MainView).GetSelectedRows()[0];
                DataRowView selRow = (DataRowView)(((GridView)gridHocPhi.MainView).GetRow(intSelected));
                this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_DONGHOCPHITableAdapter.FillBy(this.qLDSV_TCDataSetGoc.CT_DONGHOCPHI, selRow["MASV"].ToString(), selRow["NIENKHOA"].ToString(), Convert.ToInt32(selRow["HOCKY"]));
            }
            catch (System.Exception ex)
            {

            }
        }

        private void btnThemHocPhi_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(strCurrentMSV )|| string.IsNullOrEmpty(txtMSV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "", MessageBoxButtons.OK);
                return;
            }

            string strlenh = " exec [dbo].[SP_ThemHocPHi] '" + strCurrentMSV + "','" + txtNienKhoa.Text + "'," + txtHocKy.Text + "," + txthocPhi.Text;
            if (Program.ExecSqlNonQuery(strlenh) == 0)
                MessageBox.Show("Nhập học phí thành công", "", MessageBoxButtons.OK);
            button1_Click(null, null);
        }

        private void btnThemChiTietHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentDataRowView == null) return;

                long longSum = Convert.ToInt64(txtChiTietTienHocPhi.Text);
                if (longSum > Convert.ToInt64(currentDataRowView["CONLAI"]))
                {
                    MessageBox.Show("Vui lòng nhập số tiền nhỏ hơn số tiền còn lại", "Thông báo ", MessageBoxButtons.OK);
                    return;
                }

                string strlenh = " exec [dbo].[SP_ThemCTHocPHi] '" + currentDataRowView["MASV"].ToString() + "','" + currentDataRowView["NIENKHOA"].ToString() + "'," + Convert.ToString(currentDataRowView["HOCKY"]) + "," + txtChiTietTienHocPhi.Text;
                if (Program.ExecSqlNonQuery(strlenh) == 0)
                {

                    MessageBox.Show("Nhập học phí thành công", "", MessageBoxButtons.OK);
                    gridHocPhi_DoubleClick(null, null);
                    button1_Click(null, null);
                }
            }
            catch (Exception objex)
            {
                MessageBox.Show(objex.ToString(),"Thông báo ",MessageBoxButtons.OK);
            }

        }

        private void gridChiTietHocPhi_Click(object sender, EventArgs e)
        {

        }

        private void gridHocPhi_Click(object sender, EventArgs e)
        {

        }

        private void gridHocPhi_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int[] rows = ((GridView)gridHocPhi.MainView).GetSelectedRows();
                if (rows != null && rows.Length > 0)
                {
                    int intSelected = ((GridView)gridHocPhi.MainView).GetSelectedRows()[0];
                    DataRowView selRow = (DataRowView)(((GridView)gridHocPhi.MainView).GetRow(intSelected));
                    //this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.cT_DONGHOCPHITableAdapter.FillBy(this.qLDSV_TCDataSetGoc.CT_DONGHOCPHI, selRow["MASV"].ToString(), selRow["NIENKHOA"].ToString(), Convert.ToInt32(selRow["HOCKY"]));
                    this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_DONGHOCPHITableAdapter.FillByHocPhi(this.qLDSV_TCDataSetGoc.CT_DONGHOCPHI, selRow["MASV"].ToString(), selRow["NIENKHOA"].ToString(), Convert.ToInt32(selRow["HOCKY"]));
                    this.currentDataRowView = selRow;
                    lbCurrentSelectedRow.Text = "Đang chọn : " + String.Join(" - ", new string[] { selRow["MASV"].ToString(), selRow["NIENKHOA"].ToString(), Convert.ToString(selRow["HOCKY"]) });
                }
            }
            catch (Exception objex)
            {
                MessageBox.Show(objex.ToString());
            }

        }

        private void txtChiTietTienHocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtChiTietTienHocPhi.Text.Length < 9; ;
        }

        private void txtHocKy_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtHocKy.Text.Length < 9;
        }

        private void txthocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txthocPhi.Text.Length < 9;

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaoLoginPKT frmTaoLoginPKT = new frmTaoLoginPKT();
            frmTaoLoginPKT.ShowDialog(this);
        }

        
    }
}
