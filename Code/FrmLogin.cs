using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Picturebox
{
   
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        // kết nối với sql sever
        SqlConnection conn = null;
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_WSN;User Id = iot2022a;pwd=888888888";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string matkhau;
        private void btnLogin_Click(object sender, EventArgs e) // kiểm tra xem thông tin đăng nhập có khớp với dữ liệu đã lưu hay không 
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Login where ID = @id" ;
            command.Connection = conn;
            SqlParameter parID = new SqlParameter("@ID", SqlDbType.NVarChar);
            parID.Value = txtUsername.Text;
            command.Parameters.Add(parID);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                matkhau = reader.GetString(2);
            }
            if (txtPassword.Text == matkhau) 
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, vui lòng thử lại");
            }
            conn.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e) // thông báo khi thoát đăng nhập
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
