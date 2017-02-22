using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;
using System.Configuration;

namespace Repository
{
    public class TechnicianCustomersRepository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);
        public DataSet GetTechnicianCustomer()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetTechnicianCustomer", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TechnicianCustomer");
            return ds;
        }
        public TechnicianCustomers UpdateTechnicianCustomer()
        {
            TechnicianCustomers techniciancustomer = null;

            return techniciancustomer;
        }
        public TechnicianCustomers InsertTechnicianCustomer()
        {
            TechnicianCustomers techniciancustomer = null;

            return techniciancustomer;
        }
        public TechnicianCustomers DeleteTechnicianCustomer()
        {
            TechnicianCustomers techniciancustomer = null;

            return techniciancustomer;
        }

    }
}
