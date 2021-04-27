using Datos.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Metodos
{
    public class CD_Login
    {
        Connection cone = new Connection();

        public int consultarLogin(string Usuario, string Contrasena)
        {
            int count = 0;

            cone._SqlConnect.Open();
            string query = "select COUNT(*) from Users where username = '" + Usuario + "' and password ='" + Contrasena + "'";
            SqlCommand sqlCommand = new SqlCommand(query, cone._SqlConnect);
            count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            cone._SqlConnect.Close();

            return count;
        }

        public Users CD_GetUserLogin(string Usuario, string Contrasena)
        {
            try
            {
                cone._SqlConnect.Open();
                string query = "select * from Users where username = '" + Usuario + "' and password ='" + Contrasena + "'";
                SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                cone._SqlConnect.Close();
                Users _Users = new Users();

                foreach (DataRow row in table.Rows)
                {
                    _Users.UsersId = Convert.ToInt32(row["UsersId"].ToString());
                    _Users.ProfileUserId = Convert.ToInt32(row["ProfileUserId"].ToString());
                    _Users.UserName = row["UserName"].ToString();
                    _Users.CompleteName = row["CompleteName"].ToString();
                    _Users.Password = row["Password"].ToString();
                    _Users.Email = row["Email"].ToString();
                    _Users.IsActive =Convert.ToBoolean(row["IsActive"].ToString());
                }
                return _Users;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
