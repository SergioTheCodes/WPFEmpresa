using DataAccess.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        string cs = ConfigurationManager.ConnectionStrings["UsersDB"].ToString();
        public void AddUser(Users user)
        {
            int i = 0;
            using (SqlConnection conx = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SPADDUSER", conx);
                conx.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", user.Nombre);
                cmd.Parameters.AddWithValue("@DNI", user.Documento);
                cmd.Parameters.AddWithValue("@DNI_TYPE", user.TipoDocumento1);
                cmd.Parameters.AddWithValue("@POSITION", user.Cargo);

                try
                {
                    i = cmd.ExecuteNonQuery();
                    conx.Close();
                }
                catch (Exception ex)
                {
                    //if (i >= 1)
                    //{
                    //    Ok;
                    //}
                    if (i < 1)
                    {
                        throw ex;
                    }
                }
            }
        }

        public void DeleteUser(Users user)
        {
            using (SqlConnection conx = new SqlConnection(cs))
            {

            }
        }

        public List<Users> GetUsers()
        {
            using (SqlConnection conx = new SqlConnection(cs))
            {
                List<Users> Userslist = new List<Users>();
                SqlCommand com = new SqlCommand("SPGETUSERS", conx);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                conx.Open();
                da.Fill(dt);
                conx.Close();
                //Bind EmpModel generic list using dataRow     
                foreach (DataRow dr in dt.Rows)
                {
                    Userslist.Add(
                        new Users
                        {
                            Nombre = Convert.ToString(dr["NAME"]),
                            Cargo = Convert.ToString(dr["POSITION"]),
                            Documento = Convert.ToString(dr["DNI"]),
                            TipoDocumento1 = Convert.ToInt32(dr["DNI_TYPE"])
                        }
                        );
                }
                return Userslist;
            }
        }

        public Users GetUsersByDNI(string DNI, int type)
        {
            using (SqlConnection conx = new SqlConnection(cs))
            {

            }
            return new Users();
        }

        public void UpdateUser(Users user)
        {
            int i = 0;
            using (SqlConnection conx = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SPUPDATEUSER", conx);
                conx.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", user.Nombre);
                cmd.Parameters.AddWithValue("@DNI", user.Documento);
                cmd.Parameters.AddWithValue("@DNI_TYPE", user.TipoDocumento1);
                cmd.Parameters.AddWithValue("@POSITION", user.Cargo);
                cmd.Parameters.AddWithValue("AREA", user.area);

                try
                {
                    i = cmd.ExecuteNonQuery();
                    conx.Close();
                }
                catch (Exception ex)
                {
                    //if (i >= 1)
                    //{
                    //    Ok;
                    //}
                    if (i < 1)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
