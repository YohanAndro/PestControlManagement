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
    public partial class AddTechnician : MetroForm
    {
        public AddTechnician()
        {
            InitializeComponent();
        }
        private void AddTechnician_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult==DialogResult.OK)
            {
                if (string.IsNullOrEmpty(mtxtTechnicianID.Text))
                {
                    MessageBox.Show("Please enter Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtxtTechnicianID.Focus();
                    e.Cancel = true;
                    return;
                }
                try
                {
                    TechniciansRepository ur = new TechniciansRepository();
                    Technicians newUser = new Technicians();
                    newUser.ID = Guid.NewGuid();
                    newUser.TechnicianID = mtxtTechnicianID.Text;
                    newUser.FirsName = mtxtFirsname.Text;
                    newUser.LastName = mtxtLastname.Text;
                    newUser.Mobile = mtxtMobile.Text;
                    newUser.EmailId = mtxtEmail.Text;
                    ur.InsertTechnician(newUser);
                    e.Cancel = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }               

        }

        private void mbtnReset_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is MetroTextBox)
                {
                    MetroTextBox t = (MetroTextBox)item;
                    t.Text = string.Empty;
                }
            }
        }
    }
}
