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
    public partial class FormFinishChange : Form
    {
        public FormFinishChange()
        {
            InitializeComponent();
            lblChange.Text = BasePage.ShowChangePaid.ToString("C2");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
