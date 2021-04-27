using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Metodos;
using Negocios;
using Negocios.Metodos;

namespace Mc_Roostie
{
    public partial class FormUsers : Form
    {
        CN_Login cn = new CN_Login();
        CN_Users _CN_Users = new CN_Users();
        
        public FormUsers()
        {
            InitializeComponent();
            GVAllUsers.DataSource = cn.ShowAllUsers();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void GVAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int idProfile = (string)cbxProfile.SelectedItem == "Administrador" ? 1 : 2;

            if(_CN_Users.CN_InsertUser(idProfile, txtUserName.Text, txbCompleteName.Text, txbPassword.Text, tbxEmail.Text) == 1)
            {
                MessageBox.Show("Usuario creado con exito");
                GVAllUsers.DataSource = cn.ShowAllUsers();
            }
            else
                MessageBox.Show("ERROR");
        }
    }
}
