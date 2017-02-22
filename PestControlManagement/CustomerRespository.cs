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
   public class CustomerRespository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);
        public int InsertCustomer(Customer newCustomer)
        {
            int cus = 0;
            SqlCommand cmd = new SqlCommand("sp_InsertCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pId", SqlDbType.UniqueIdentifier, 255).Value = newCustomer.ID;
            cmd.Parameters.Add("@pName", SqlDbType.VarChar, 255).Value = newCustomer.Name;
            cmd.Parameters.Add("@pMobileNo", SqlDbType.VarChar, 255).Value = newCustomer.MobileNo;
            cmd.Parameters.Add("@pPhone", SqlDbType.VarChar, 255).Value = newCustomer.Phone;
            cmd.Parameters.Add("@pFAX", SqlDbType.VarChar, 255).Value = newCustomer.FAX;
            cmd.Parameters.Add("@pEmail", SqlDbType.VarChar, 255).Value = newCustomer.Email;
            cmd.Parameters.Add("@pAddress", SqlDbType.VarChar, 255).Value = newCustomer.Address;
            cmd.Parameters.Add("@pCustomerType", SqlDbType.VarChar, 255).Value = newCustomer.CustomerType;
            con.Open();
            cus = cmd.ExecuteNonQuery();
            con.Close();
            return cus;
        }
    }
}
