using System.Data.SqlClient;
using System.Data;
using Models;
using System.Configuration;
using System;

namespace Repository
{
    public class UsersRepository
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PestControlManagement"].ConnectionString);

        public Users ValidateUser(string username, string password)
        {
            Users user = null;
            //Logic related to database
            //Connect to database "server=RAJKUMAR-PC; uid=sa; password=abc; database=PesticidesControl;"
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_ValidateUser",con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "sp_ValidateUser";
            //cmd.Connection = con;
            
            //Send parameters
            cmd.Parameters.Add("@pUsername", SqlDbType.VarChar, 50);
            cmd.Parameters["@pUsername"].Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50);
            cmd.Parameters["@Password"].Value = password;
            //Execute Query
            SqlDataReader reader=cmd.ExecuteReader();
            if (reader!=null&&reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new Users();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                    //user.Password = reader["Created"].ToString();
                    //user.Password = reader["LastUpdated"].ToString();
                    //user.Password = reader["IsActive"].ToString();
                    //user.Password = reader["LoginTime"].ToString();
                    //user.Password = reader["LogOutTime"].ToString();                   
                }
            }
            return user;
        }
        public DataSet GetUsers()
        {           
            SqlDataAdapter da = new SqlDataAdapter("sp_GetUSers",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");           
            return ds;
          
        }
        public int InsertUsers(Users userDetails)
        {           
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_InsertUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pId", SqlDbType.UniqueIdentifier, 255).Value = userDetails.ID;
            cmd.Parameters.Add("@pUsername", SqlDbType.VarChar, 255).Value = userDetails.Username;
            cmd.Parameters.Add("@pPassword", SqlDbType.VarChar, 255).Value = userDetails.Password;
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();

            return result;           
        }
        public int UpdateUsers(Users usrr)
        {
            int user = 0;

            return user;
        }
        public int DeleteUsers(Guid userID)
        {
            int result = 0;

            return result;
        }

        //public int InsertUsers(Guid guid, string p1, string p2)
        //{
            
        //}
    }
}
