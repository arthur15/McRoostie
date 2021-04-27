using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Metodos;
using Datos.Tablas;

namespace Negocios
{
    public class CN_Login
    {
        private CD_Login _CD_Login = new CD_Login();
        private CD_Users _User = new CD_Users();

        public int VerifyLoginUser(string user, string password)
        {
            //DataTable dataTable = new DataTable();
            //int test = _CD_Login.VerifyUser();
            //return test;
            try
            {
                return _CD_Login.consultarLogin(user, password);
            }
            catch (Exception)
            {

                throw;
            }
            //return consultingUser;
        }

        public Users CN_GetUserLogin(string user, string password)
        {
            try
            {
                return _CD_Login.CD_GetUserLogin(user, password);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ShowAllUsers()
        {
            try
            {
                return _User.ShowUsers();
            }
            catch (Exception)
            {

                throw;
            }
            // connection.ShowUsers();
        }

    }
}
