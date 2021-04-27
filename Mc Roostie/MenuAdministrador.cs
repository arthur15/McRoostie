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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsers FormUsers = new FormUsers();
            this.Hide();
            FormUsers.ShowDialog();
            this.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FormItems FormItems = new FormItems();
            this.Hide();
            FormItems.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShowPromo fsp = new FormShowPromo();
            Hide();
            fsp.ShowDialog();
            Show();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            FormCancelOrder fco = new FormCancelOrder();
            Hide();
            fco.ShowDialog();
            Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            Hide();
            fr.ShowDialog();
            Show();
        }
    }
}
