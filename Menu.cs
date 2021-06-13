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
using Microsoft.SqlServer;

namespace Crystal_Report
{
    public partial class Menu : Form
    {
        //thay dòng này
        string conString = "Data Source=.;Initial Catalog=voucherDB;Integrated Security=True";
        SqlConnection conn = null;


        public Menu()
        {
            InitializeComponent();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            FormKH formKH = new FormKH();
            formKH.ShowDialog();
        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            //Giữ
            SqlDataAdapter da = new SqlDataAdapter();
            conn = new SqlConnection(conString);
            conn.Open();


            //thay y chang trong store procedure sql
            SqlCommand cmd = new SqlCommand("SearchPartner", conn);

            //Giữ
            cmd.CommandType = CommandType.StoredProcedure;

            //thay y chang trong store procedure sql
            cmd.Parameters.AddWithValue("id", tbTimKiem.Text);

            //Giữ
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);


            //Thay đổi nếu đặt tên khác
            CrystalReport_Partner rptPartner = new CrystalReport_Partner();
            rptPartner.SetDataSource(dt);

            //Thay đổi nếu đặt tên khác
            FormPartner formPartner = new FormPartner();
            formPartner.crystalReport.ReportSource = rptPartner;
            formPartner.ShowDialog();

        }
    }
}
