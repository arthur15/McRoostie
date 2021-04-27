using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Connection
    {
        private SqlConnection _SqlConnection = new SqlConnection(@"Data Source=LAPTOP-DS7VVU2R\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=user1;Password=abcd");
        public SqlConnection _SqlConnect = new SqlConnection(@"Data Source=LAPTOP-DS7VVU2R\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=user1;Password=abcd");
        //private SqlConnection _SqlConnection = new SqlConnection(@"Data Source=DESKTOP-CNLA3H9\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=SalesUser;Password=43211");
        //public SqlConnection _SqlConnect = new SqlConnection(@"Data Source=DESKTOP-CNLA3H9\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=SalesUser;Password=43211");
        //static string conecionString = @"Data Source=LAPTOP-DS7VVU2R\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=user1;Password=abcd";

        public int consultarLogin(string Usuario, string Contrasena)
        {
            int count = 0;

            _SqlConnection.Open();
            string query = "select COUNT(*) from Users where username = '"+ Usuario + "' and password ='"+ Contrasena + "'";
            SqlCommand sqlCommand = new SqlCommand(query, _SqlConnection);
            count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            _SqlConnection.Close();
            
            return count;
        }

        public DataTable ShowUsers()
        {
            _SqlConnection.Open();
            string query = "select * from Users";
            SqlCommand cmd = new SqlCommand(query, _SqlConnection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }

        public SqlConnection AbrirConexion()
        {
            if (_SqlConnection.State == ConnectionState.Closed)
                _SqlConnection.Open();
            return _SqlConnection;
        }
        public SqlConnection CerrarConexion()
        {
            if (_SqlConnection.State == ConnectionState.Open)
                _SqlConnection.Close();
            return _SqlConnection;
        }
    }
}
