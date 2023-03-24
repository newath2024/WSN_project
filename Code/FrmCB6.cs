using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace Picturebox
{
    public partial class FrmCB6 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RNQAyqRhcgMdMo5K1fNk613Mfvr9NcOfGZG6n8F7",
            BasePath = "https://do-an-2-b20af-default-rtdb.firebaseio.com/"

        };
        public FrmCB6()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            // Xử lý sự kiện Tick của Timer.
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        double a;
        int b;
        private void timer1_Tick(object sender, EventArgs e)
        {
            HienThiNhietDo();
            henxui();
        }
        private async void HienThiNhietDo()
        {
            IFirebaseClient client = new FirebaseClient(config);
            //FirebaseResponse response = await client.GetAsync(txtHuty.Text);
            FirebaseResponse response = await client.GetAsync("Demo test 2");
            DuLieu obj = response.ResultAs<DuLieu>();
            txtNhietDo.Text = obj.NhietDoCB6;
        }
        private async void henxui()
        {
            var trangthai = new TrangThai
            {
                CB6 = b
            };

            IFirebaseClient client = new FirebaseClient(config);

            SetResponse response = await client.SetAsync("TrangThai", trangthai);

        }
        private void txtNhietDo_TextChanged(object sender, EventArgs e)
        {
            a = double.Parse(txtNhietDo.Text);


            if (a > 30)
            {
                picDo.Visible = true;
                picXanh.Visible = false;
                picXam2.Visible = false;
                picXam1.Visible = true;
                b = 1;

            }
            else
            {
                picDo.Visible = false;
                picXam1.Visible = false;
                picXam2.Visible = true;
                picXanh.Visible = true;
                b = 0;

            }
        }
    }
}
