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
using MetroFramework.Controls;
using Models;
using Repository;
using MetroFramework;
using PrintReports;

namespace PestControlManagement
{
    public partial class InvoiceForm : MetroForm
    {
        CustomerReport cryp = new CustomerReport();
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            using (PesticidesControlEntity pce = new PesticidesControlEntity())
            {
                cryp.Load(@"E:\GitHub\PrintReports\CustomerReport.rpt");
                cryp.SetDataSource(pce.Customers.ToList());
                crystalReportViewer1.ReportSource = cryp;
            }
        }

        private void mComboBoxCustomerType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Customer ct = mComboBoxCustomerType.SelectedItem as Customer;
            //if (ct != null)
            //{
            //    using (PesticidesControlEntity pe = new PesticidesControlEntity())
            //    {
            //         //pe.Customer.Where(p => p.TechnicianID == ct.TechnicianID).ToList();
            //        cryp.Load(@"E:\GitHub\PrintReports\CustomerReport.rpt");
            //        cryp.SetDataSource(pe.Customers.Where(p => p.ID == ct.ID).ToList());
            //        crystalReportViewer1.ReportSource = cryp;
            //    }
            //}
        }
    }
}
