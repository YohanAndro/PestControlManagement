using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Models;
using MetroFramework.Controls;
using Repository;
using MetroFramework;
using PrintReports;

namespace PestControlManagement
{
    public partial class ucCustomerReport : MetroFramework.Controls.MetroUserControl
    {
        CustomerReport cryp = new CustomerReport();
        public ucCustomerReport()
        {
            InitializeComponent();
        }

        private void ucCustomerReport_Load(object sender, EventArgs e)
        {            
          using(PesticidesControlEntity pce=new PesticidesControlEntity())
          {
              cryp.SetDataSource(pce.Customers.ToList());
              crystalReportViewer1.ReportSource = cryp;
          }
        }
    }
}
