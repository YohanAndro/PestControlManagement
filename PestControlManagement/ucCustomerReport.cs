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
        
        public ucCustomerReport()
        {
            InitializeComponent();
        }

        private void ucCustomerReport_Load(object sender, EventArgs e)
        {            
         
        }


        private void mtInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm iform = new InvoiceForm();
            iform.ShowDialog();

        }
       
    }
}
