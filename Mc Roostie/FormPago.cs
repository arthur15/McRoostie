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
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool aux = (int.TryParse(txbxPago.Text, out int qtyLQ));
            if (aux)
                BasePage.CambioPago = Convert.ToDecimal(txbxPago.Text);
            else
                BasePage.CambioPago = 0;
            if (BasePage.CambioPago < BasePage.TotalOrder)
            {
                MessageBox.Show("El pago debe ser mayor o igual al total de la cuenta");
                txbxPago.Text = "";
            }
            else
                this.Hide();
        }

        private void txbxPago_KeyPress(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbxPago.Text, @"[^0-9.]")) //^[1-9]\d*(\.\d+)?$
//                if (System.Text.RegularExpressions.Regex.IsMatch(txbxPago.Text, "[^0-9]"))
                {
                //MessageBox.Show("Please enter only numbers.");
                txbxPago.Text = txbxPago.Text.Remove(txbxPago.Text.Length - 1);
            }
        }
    }
}
