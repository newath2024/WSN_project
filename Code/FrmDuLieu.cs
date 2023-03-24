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
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Picturebox
{
    public partial class FrmDuLieu : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RNQAyqRhcgMdMo5K1fNk613Mfvr9NcOfGZG6n8F7",
            BasePath = "https://do-an-2-b20af-default-rtdb.firebaseio.com/"

        };
        public FrmDuLieu()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10000;
            // Xử lý sự kiện Tick của Timer.
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        
        SqlConnection conn = null; // kết nối sql sever
        string sqlConn = "Server = HUNG\\WINCC;Database=CSDL_WSN;User Id = iot2022a;pwd=888888888";
        private void HienThiDuLieu() // Hiển thị dữ liệu lên list view
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
            command.CommandText = "select * from DuLieu";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvDuLieu.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetInt32(1) + "");
                lvi.SubItems.Add(reader.GetInt32(2) + "");
                lvi.SubItems.Add(reader.GetInt32(3) + "");
                lvi.SubItems.Add(reader.GetInt32(4) + "");
                lvi.SubItems.Add(reader.GetInt32(5) + "");
                lvi.SubItems.Add(reader.GetInt32(6) + "");
                lvi.SubItems.Add(reader.GetInt32(7) + "");
                lvi.SubItems.Add(reader.GetInt32(8) + "");
                lvi.SubItems.Add(reader.GetInt32(9) + "");
                lvi.SubItems.Add(reader.GetInt32(10) + "");

                lvDuLieu.Items.Add(lvi);

            }
            reader.Close();
        }
        private void FrmDuLieu_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
        }

        private void lvDuLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // thực thi mỗi 10s
        {
            if(conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            // kết nối với bảng DuLieu trong database CSDL_WSN
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Insert into DuLieu(ThoiGian,NhietDoCB1,NhietDoCB2,NhietDoCB3,NhietDoCB4,NhietDoCB5,NhietDoCB6,NhietDoCB7,NhietDoCB8,NhietDoCB9,NhietDoCB10) values (@ThoiGian,@NhietDoCB1,@NhietDoCB2,@NhietDoCB3,@NhietDoCB4,@NhietDoCB5,@NhietDoCB6,@NhietDoCB7,@NhietDoCB8,@NhietDoCB9,@NhietDoCB10)";

            command.CommandText = sql;
            command.Connection = conn;
            // thêm giá trị vào bảng
            command.Parameters.Add("@ThoiGian", SqlDbType.NVarChar).Value = txtThoiGian.Text;
            command.Parameters.Add("@NhietDoCB1", SqlDbType.Float).Value = txtCB1.Text;
            command.Parameters.Add("@NhietDoCB2", SqlDbType.Float).Value = txtCB2.Text;
            command.Parameters.Add("@NhietDoCB3", SqlDbType.Float).Value = txtCB3.Text;
            command.Parameters.Add("@NhietDoCB4", SqlDbType.Float).Value = txtCB4.Text;
            command.Parameters.Add("@NhietDoCB5", SqlDbType.Float).Value = txtCB5.Text;
            command.Parameters.Add("@NhietDoCB6", SqlDbType.Float).Value = txtCB6.Text;
            command.Parameters.Add("@NhietDoCB7", SqlDbType.Float).Value = txtCB7.Text;
            command.Parameters.Add("@NhietDoCB8", SqlDbType.Float).Value = txtCB8.Text;
            command.Parameters.Add("@NhietDoCB9", SqlDbType.Float).Value = txtCB9.Text;
            command.Parameters.Add("@NhietDoCB10", SqlDbType.Float).Value = txtCB10.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e) // gửi ngược dữ liệu lên database
        {
            var dulieu = new DuLieu
            {
                ThoiGian = txtThoiGian.Text,
                NhietDoCB1 = txtCB1.Text,
                NhietDoCB2 = txtCB2.Text,
                NhietDoCB3 = txtCB3.Text,
                NhietDoCB4 = txtCB4.Text,
                NhietDoCB5 = txtCB5.Text,
                NhietDoCB6 = txtCB6.Text,
                NhietDoCB7 = txtCB7.Text,
                NhietDoCB8 = txtCB8.Text,
                NhietDoCB9 = txtCB9.Text,
                NhietDoCB10 = txtCB10.Text

            };
            

            IFirebaseClient client = new FirebaseClient(config);
            SetResponse response = await client.SetAsync("Demo test 2", dulieu);
            MessageBox.Show("Gửi thành công");
        }

        private async void btnGive_Click(object sender, EventArgs e) // kích hoạt để bắt đầu nhận dữ liệu tự động từ database
        {
            IFirebaseClient client = new FirebaseClient(config);
            FirebaseResponse response = await client.GetAsync("Demo test 2");
            DuLieu obj = response.ResultAs<DuLieu>();
            txtCB1.Text = obj.NhietDoCB1;
            txtCB2.Text = obj.NhietDoCB2;
            txtCB3.Text = obj.NhietDoCB3;
            txtCB4.Text = obj.NhietDoCB4;
            txtCB5.Text = obj.NhietDoCB5;
            txtCB6.Text = obj.NhietDoCB6;
            txtCB7.Text = obj.NhietDoCB7;
            txtCB8.Text = obj.NhietDoCB8;
            txtCB9.Text = obj.NhietDoCB9;
            txtCB10.Text = obj.NhietDoCB10;
            txtThoiGian.Text = obj.ThoiGian;
            MessageBox.Show("Nhận dữ liệu thành công");


            timer1.Start();
        }

        private void txtThoiGian_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
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
            string sql = "delete from DuLieu where NhietDoCB1 = @NhietDoCB1";
            command.CommandText = sql;
            command.Connection = conn;
            command.Parameters.Add("@NhietDoCB1", SqlDbType.Int).Value = txtCB1.Text;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Xóa chưa thành công");

            }
            
        }
    }
}
