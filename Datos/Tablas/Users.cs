using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class Users
    {
        private int _usersId;
        private int _profileUserId;
        private string _userName;
        private string _completeName;
        private string _password;
        private string _email;
        private bool _isActive;

        public int UsersId { get => _usersId; set => _usersId = value; }
        public int ProfileUserId { get => _profileUserId; set => _profileUserId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string CompleteName { get => _completeName; set => _completeName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
    }
}
