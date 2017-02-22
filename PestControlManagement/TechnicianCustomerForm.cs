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
using System.Data.Entity;
using MetroFramework.Controls;

namespace PestControlManagement
{
    public partial class TechnicianCustomerForm : MetroForm
    {
        public TechnicianCustomerForm()
        {
            InitializeComponent();
        }
           // <add name="PestControlManagement" connectionString="server=RAJKUMAR-PC; uid=sa; password=abc; database=PesticidesControl;" providerName="System.Data.SqlClient" />

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            //AddCustomerTechnicianForm atc = new AddCustomerTechnicianForm();
            //atc.ShowDialog();
            using (AddCustomerTechnicianForm atc = new AddCustomerTechnicianForm())
            {
                if (atc.ShowDialog() == DialogResult.OK)
                {
                    using (PesticidesControlEntity pe = new PesticidesControlEntity())
                    {
                        custmerTechBindingSource.DataSource = pe.CustmerTeches.ToList();
                    }
                }
            }
        }

        private void TechnicianCustomerForm_Load(object sender, EventArgs e)
        {
            using (PesticidesControlEntity pe = new PesticidesControlEntity())
            {
                custmerTechBindingSource.DataSource = pe.CustmerTeches.ToList();
            }
        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            if (custmerTechBindingSource.Current == null)
            {
                return;
            }
            try
            {
                using (PesticidesControlEntity pc = new PesticidesControlEntity())
                {
                    pc.CustmerTeches.Attach(custmerTechBindingSource.Current as CustmerTech);
                    pc.Entry(custmerTechBindingSource.Current as CustmerTech).State = EntityState.Modified;
                    pc.SaveChanges();
                    custmerTechBindingSource.DataSource = pc.CustmerTeches.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (custmerTechBindingSource.Current!=null)
                {
                    using (PesticidesControlEntity pe = new PesticidesControlEntity())
                    {
                        if (MessageBox.Show("Are you Sure Want to Delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            pe.CustmerTeches.Attach(custmerTechBindingSource.Current as CustmerTech);
                            pe.CustmerTeches.Remove(custmerTechBindingSource.Current as CustmerTech);
                            pe.Entry(custmerTechBindingSource.Current as CustmerTech).State = EntityState.Deleted;
                            custmerTechBindingSource.RemoveCurrent();
                            pe.SaveChanges();
                            custmerTechBindingSource.DataSource = pe.CustmerTeches.ToList();
                        }
                    } 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
