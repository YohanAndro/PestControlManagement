using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Models;

namespace Repository
{
    public class TechniciansRepository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);
        public DataSet GetTechnicians()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetTechnicians", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Technicians");
            return ds;
        }
        public Technicians UpdateTechnician()
        {
            Technicians techician = null;

            return techician;
        }
        public int InsertTechnician(Technicians tchn)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_InsertTechnicians", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pId", SqlDbType.UniqueIdentifier, 255).Value = tchn.ID;
            cmd.Parameters.Add("@pFirstName", SqlDbType.VarChar, 255).Value = tchn.FirsName;
            cmd.Parameters.Add("@pLastName", SqlDbType.VarChar, 255).Value = tchn.LastName;
            cmd.Parameters.Add("@pMobile", SqlDbType.VarChar, 255).Value = tchn.Mobile;
            cmd.Parameters.Add("@pEmailId", SqlDbType.VarChar, 255).Value = tchn.EmailId;
            cmd.Parameters.Add("@pTechnicianID", SqlDbType.VarChar, 255).Value = tchn.TechnicianID;
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();

            return result;           
        }
        public Technicians DeleteTechnician()
        {
            Technicians technician = null;

            return technician;
        }

    }
}
