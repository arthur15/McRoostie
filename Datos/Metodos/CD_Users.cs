using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Metodos
{
    public class CD_Users
    {
        Connection cone = new Connection();

        public DataTable ShowUsers()
        {
           
            cone._SqlConnect.Open();
            
            string query = "select * from Users";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            cone._SqlConnect.Close();
            return table;
        }

        public int InsertUser(int ProfileUserId, string UserName, string CompleteName, string Password, string Email)
        {

            cone._SqlConnect.Open();

            int ban = 0;
            string query = "insert into Users values (" + ProfileUserId + ", '" + UserName + "','" + CompleteName + "','" + Password + "','" + Email + "', 1)";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);

            ban = cmd.ExecuteNonQuery();
            cone._SqlConnect.Close();

            return ban;
        }

    }
}
