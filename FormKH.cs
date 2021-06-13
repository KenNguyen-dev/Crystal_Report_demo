using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace Crystal_Report
{
    public partial class FormKH : Form
    {
        public FormKH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport_Test rpt = new CrystalReport_Test();
            formCrystalReport.ReportSource = rpt;
        }
    }
}
