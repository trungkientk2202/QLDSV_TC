using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=TRUNGKIEN;Initial Catalog=QLDSV_TC;User ID=sa;password=123";
        public static SqlDataReader myReader;
        public static String servername = "TRUNGKIEN";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String database = "QLDSV_TC";

        public static frmMain frmChinh;
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static int mKhoa;
        public static BindingSource bds_dspm = new BindingSource();


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" + Program.mlogin + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại username và password.\n " + e.Message);
            }
            return 0;
        }

        //view trả về chỉ xem k thể thêm xóa sửa
        public static SqlDataReader ExecSqlDataReader(String strlenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                return null;
            }
        }
        //view trả về dạng bảng
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //cập nhật dữ liệu, k thực hiện truy vấn
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strlenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; //10phut
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Error converting  data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày thi\" qua kiểu Number hoặc mở File Excel.");
                else
                    MessageBox.Show(e.Message);
                Program.conn.Close();
                return e.State; //Trạng thái lỗi gửi từ RAISERROR trong SQL Server qua
            }
        }

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
