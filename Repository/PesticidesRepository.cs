using System.Data.SqlClient;
using System.Data;
using Models;
using System.Configuration;

namespace Repository
{
    public class PesticidesRepository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);

        public DataSet GetPesticides()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetPesticides", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pesticides");
            return ds;
        }
        public Pesticides UpdatePesticides()
        {
            Pesticides pesticides = null;
            return pesticides;
        }
    }
}
