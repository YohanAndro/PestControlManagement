using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace PestControlManagement
{
    public partial class AddCustomer : MetroForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void mbtnReset_Click(object sender, EventArgs e)
        {
           
            foreach (var item in this.Controls)
            {
                if (item is MetroTextBox)
                {
                    MetroTextBox t = (MetroTextBox)item;
                    t.Text = string.Empty;
                }
            }
        }
 
        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(mtxtCustmername.Text))
                {
                    MessageBox.Show("Please enter Fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtxtCustmername.Focus();
                    e.Cancel = true;
                    return;
                }
                try
                {
                    CustomerRespository cr = new CustomerRespository();
                    Customer newCustomer = new Customer();
                    newCustomer.ID = Guid.NewGuid();
                    newCustomer.Name = mtxtCustmername.Text;
                    newCustomer.MobileNo = mtxtMobile.Text;
                    newCustomer.Phone = mtxtPhone.Text;
                    newCustomer.FAX = mtxtFax.Text;
                    newCustomer.Email = mtxtEmail.Text;
                    newCustomer.Address = mtxtAddress.Text;
                    newCustomer.CustomerType = mComboBoxCType.SelectedItem.ToString();
                    cr.InsertCustomer(newCustomer);
                    e.Cancel = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }               
        }
    }
}
