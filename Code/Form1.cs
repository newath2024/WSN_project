using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebox
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void picOff_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void cảmBiến1ToolStripMenuItem_Click(object sender, EventArgs e) // Hiển thị trạng thái cảm biến tại vị trí 1
        {
            FrmCB1 frm1 = new FrmCB1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void cảmBiến2ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 2
        {
            FrmCB2 frm2 = new FrmCB2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void cảmBiến3ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 3
        {
            FrmCB3 frm3 = new FrmCB3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void cảmBiến4ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 4
        {
            FrmCB4 frm4 = new FrmCB4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void cảmBiến5ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 5
        {
            FrmCB5 frm5 = new FrmCB5();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void cảmBiến6ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 6
        {
            FrmCB6 frm6 = new FrmCB6();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void cảmBiến7ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 7
        {
            FrmCB7 frm7 = new FrmCB7();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void cảmBiến8ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 8
        {
            FrmCB8 frm8 = new FrmCB8();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void cảmBiến9ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 9
        {
            FrmCB9 frm9 = new FrmCB9();
            frm9.MdiParent = this;
            frm9.Show();
        }

        private void cảmBiến10ToolStripMenuItem_Click(object sender, EventArgs e)// Hiển thị trạng thái cảm biến tại vị trí 10
        {
            FrmCB10 frm10 = new FrmCB10();
            frm10.MdiParent = this;
            frm10.Show();
        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e) // Sắp xếp các form cho tối ưu
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuLieu frmDulieu = new FrmDuLieu();
            frmDulieu.MdiParent = this;
            frmDulieu.Show();
        }

        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* FrmXuatFile frmXuatfile = new FrmXuatFile();
             frmXuatfile.MdiParent = this;
             frmXuatfile.Show();*/
            FrmReport frmReport = new FrmReport();
            frmReport.MdiParent = this;
            frmReport.Show();

        }
    }
}
