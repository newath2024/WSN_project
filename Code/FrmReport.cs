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
using Microsoft.Reporting.WinForms;

namespace Picturebox
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // kết nối với database để lấy dữ liệu từ bảng DuLieu
            SqlConnection conn = new SqlConnection
                ("Server = HUNG\\WINCC;Database=CSDL_WSN;User Id = iot2022a;pwd=888888888");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from DuLieu", conn);
            //Xuất dữ liệu từ bảng thành báo cáo
            DataSet ds = new DataSet();
            adapter.Fill(ds, "DuLieu");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Picturebox.ReportCB.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
