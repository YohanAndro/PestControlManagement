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
using Repository;
using MetroFramework.Controls;
using System.Data.Entity;

namespace PestControlManagement
{
    public partial class ucCustomer : MetroFramework.Controls.MetroUserControl
    {
        public ucCustomer()
        {
            InitializeComponent();
        }  
        public DataGridViewRow dvr;
       
        private void ucCustomer_Load(object sender, EventArgs e)
        {           
            using (PesticidesControlEntity pe = new PesticidesControlEntity())
            {
                customerBindingSource.DataSource = pe.Customers.ToList();
            }
        }

        private void mbnAdd_Click_1(object sender, EventArgs e)
        {

            using (AddCustomer ac = new AddCustomer())
            {
                if (ac.ShowDialog() == DialogResult.OK)
                {

                }

            }
            using (PesticidesControlEntity pe = new PesticidesControlEntity())
            {
                customerBindingSource.DataSource = pe.Customers.ToList();
            };
        }

        private void mbtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (customerBindingSource.Current == null)
            {
                return;
            }
            try
            {
                using (PesticidesControlEntity pc = new PesticidesControlEntity())
                {
                    pc.Customers.Attach(customerBindingSource.Current as Customer);
                    pc.Entry(customerBindingSource.Current as Customer).State = EntityState.Modified;
                    pc.SaveChanges();
                    customerBindingSource.DataSource = pc.Customers.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void mbtnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (customerBindingSource.Current != null)
                {
                    using (PesticidesControlEntity p = new PesticidesControlEntity())
                    {
                        if (MessageBox.Show("Are you Sure Want to Delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            p.Entry(customerBindingSource.Current).State = EntityState.Deleted;
                            p.Customers.Remove(customerBindingSource.Current as Customer);
                            customerBindingSource.RemoveCurrent();
                            p.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void mbtnSendMail_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("www.google.com");
            if (dvr == null)
            {
                MessageBox.Show("Select Customer to SendMail");
            } if (dvr != null)
            {
                Mail m = new Mail();
                m.dgvr = dvr;
                m.ShowDialog();
            }

        }

        private void metroGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && metroGrid1.Rows[e.RowIndex].Cells[0] != null)
            {
                dvr = metroGrid1.Rows[e.RowIndex];
            }
        }

        
    }
}
