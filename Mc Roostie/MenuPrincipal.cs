using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mc_Roostie
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
        }
    }
}
