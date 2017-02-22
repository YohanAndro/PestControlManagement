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
    public partial class ucTechnicians : MetroFramework.Controls.MetroUserControl
    {
        public ucTechnicians()
        {
            InitializeComponent();
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            using (AddTechnician at = new AddTechnician())
            {
                if (at.ShowDialog() == DialogResult.OK)
                {

                }

            }
            GetData();     
        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            if (technicianBindingSource.Current == null)
            {
                return;
            }
            try
            {
                using (PesticidesControlEntity pc = new PesticidesControlEntity())
                {
                    //var currenttechnician = pc.Technicians.Where(t => t.ID == ((Technician)(technicianBindingSource.Current)).ID).FirstOrDefault();
                    //currenttechnician.FirsName = "laddu";
                    pc.Technicians.Attach(technicianBindingSource.Current as Technician);
                    pc.Entry(technicianBindingSource.Current as Technician).State = EntityState.Modified;
                    pc.SaveChanges();
                    technicianBindingSource.DataSource = pc.Technicians.ToList();
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
                if (technicianBindingSource.Current != null)
                {
                    using (PesticidesControlEntity p = new PesticidesControlEntity())
                    {
                        if (MessageBox.Show("Are you Sure Want to Delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            p.Entry(technicianBindingSource.Current).State = EntityState.Deleted;
                            p.Technicians.Remove(technicianBindingSource.Current as Technician);
                            technicianBindingSource.RemoveCurrent();
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
        private void GetData()
        {
            using (PesticidesControlEntity pc = new PesticidesControlEntity())
            {
                technicianBindingSource.DataSource = pc.Technicians.ToList();
            }
        }

        private void ucTechnicians_Load(object sender, EventArgs e)
        {
            GetData();
        }

      
    }
}
