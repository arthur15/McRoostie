using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Metodos;

namespace Negocios.Metodos
{

    public class CN_Users
    {
      
        private CD_Users _Users = new CD_Users();

        public int CN_InsertUser(int ProfileUserId, string UserName, string CompleteName, string Password, string Email)
        {
            return _Users.InsertUser(ProfileUserId ,  UserName ,   CompleteName,    Password ,   Email);
        }
    }
}
