﻿using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Models;

namespace Repository
{
    public class CustomersRespository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);
        public DataSet GetCustomers()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetCustomers", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            return ds;
        }
        
        public int UpdateCustomer()
        {
            int custmer = 0;
            return custmer;
        }
        public Customer DeleteCustomer()
        {
            Customer customer = null;
            return customer;
        }

        public int InsertCustomer(Customer newCustomer)
        {
            int cus = 0;
            SqlCommand cmd = new SqlCommand("sp_InsertCustomers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pId", SqlDbType.UniqueIdentifier, 255).Value = newCustomer.ID;
            cmd.Parameters.Add("@pName", SqlDbType.VarChar, 255).Value = newCustomer.Name;
            cmd.Parameters.Add("@pMobileNo", SqlDbType.VarChar, 255).Value = newCustomer.MobileNo;
            cmd.Parameters.Add("@pPhone", SqlDbType.VarChar, 255).Value = newCustomer.Phone;
            cmd.Parameters.Add("@pFAX", SqlDbType.VarChar, 255).Value = newCustomer.Fax;
            cmd.Parameters.Add("@pAddress", SqlDbType.VarChar, 255).Value = newCustomer.Address;
            cmd.Parameters.Add("@pCustomerType", SqlDbType.VarChar, 255).Value = newCustomer.CustomerType;
            cmd.Parameters.Add("@pEmail", SqlDbType.VarChar, 255).Value = newCustomer.Email;
            con.Open();
            cus = cmd.ExecuteNonQuery();
            con.Close();
            return cus;
        }
    }
}