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
namespace PestControlManagement
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void mtCustomer_Click(object sender, EventArgs e)
        {
            if (!MainGrid.Instance.MContainer.Controls.ContainsKey("ucCustomer"))
            {
                ucCustomer ucc = new ucCustomer();
                ucc.Dock = DockStyle.Fill;
                MainGrid.Instance.MContainer.Controls.Add(ucc);
            }
            MainGrid.Instance.MContainer.Controls["ucCustomer"].BringToFront();
            MainGrid.Instance.MBack.Visible = true;
            //This is test commit
        }

        private void mtTechnicians_Click(object sender, EventArgs e)
        {
            if (!MainGrid.Instance.MContainer.Controls.ContainsKey("ucTechnicians"))
            {
                ucTechnicians ucc = new ucTechnicians();
                ucc.Dock = DockStyle.Fill;
                MainGrid.Instance.MContainer.Controls.Add(ucc);
            }
            MainGrid.Instance.MContainer.Controls["ucTechnicians"].BringToFront();
            MainGrid.Instance.MBack.Visible = true;
        }

        private void mtCustomerTchnician_Click(object sender, EventArgs e)
        {
            if (!MainGrid.Instance.MContainer.Controls.ContainsKey("ucCustomerTechnician"))
            {
                ucCustomerTechnician ucc = new ucCustomerTechnician();
                ucc.Dock = DockStyle.Fill;
                MainGrid.Instance.MContainer.Controls.Add(ucc);
              
            }
            MainGrid.Instance.MContainer.Controls["ucCustomerTechnician"].BringToFront();
            
            MainGrid.Instance.MBack.Visible = true;

        }


    }
}
