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
using System.Data.SqlClient;
using System.Configuration;

namespace PestControlManagement
{
    public partial class AddCustomerTechnicianForm : MetroForm
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);

        public AddCustomerTechnicianForm()
        {
            InitializeComponent();
        }

        private void CustomerTechnicianForm_Load(object sender, EventArgs e)
        {
            using (PesticidesControlEntity pe = new PesticidesControlEntity())
            {
                technicianBindingSource.DataSource = pe.Technicians.ToList();
                customerBindingSource.DataSource = pe.Customers.ToList();
            }
        }

        private void AddCustomerTechnicianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (TId != null && TName != null && CName != null && CType != null)
                    {
                        SqlCommand cmd = new SqlCommand("sp_CustmerTech", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@pId", SqlDbType.UniqueIdentifier, 255).Value = Guid.NewGuid();
                        cmd.Parameters.Add("@pTechnicianID", SqlDbType.VarChar, 255).Value = TId;
                        cmd.Parameters.Add("@pTechnicianName", SqlDbType.VarChar, 255).Value = TName;
                        cmd.Parameters.Add("@pCustomerName", SqlDbType.VarChar, 255).Value = CName;
                        cmd.Parameters.Add("@pCustomerType", SqlDbType.VarChar, 255).Value = CType;
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();
                        if (i != 0)
                        {
                            MessageBox.Show("Successfully Inserted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Technician and Customer");
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }
        string TId, TName, CName, CType;
        
        private void mGrideTechnician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && mGrideTechnician.Rows[e.RowIndex].Cells[0].Value!=null)
                {
                    TId = mGrideTechnician.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TName = mGrideTechnician.Rows[e.RowIndex].Cells[1].Value.ToString();
                } 
        }

        private void mGrideCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && mGrideCustomer.Rows[e.RowIndex].Cells[0].Value.ToString()!=null)
            {
                CName = mGrideCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                CType = mGrideCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            //TName = null;
            //TId = null;
            //CName = null;
            //CType = null;
            TName = TId = CName = CType = null;
        }

        private void mbtnAssignTechnician_Click(object sender, EventArgs e)
        {

        }
    }
}
