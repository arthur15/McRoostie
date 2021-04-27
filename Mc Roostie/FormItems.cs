using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Negocios;
using Negocios.Metodos;

namespace Mc_Roostie
{
    public partial class FormItems : Form
    {
        CN_Products _CN_Products = new CN_Products();
        public FormItems()
        {
            InitializeComponent();
            GVAllItems.DataSource = _CN_Products.ShowItems();
            txbItemCode.Enabled = true;
            btnAddItem.Enabled = true;
            btnEditItem.Enabled = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_CN_Products.CN_InsertItem(txbItemCode.Text, txbDescription.Text, txbField1.Text, txbField2.Text, txbField3.Text, Convert.ToDouble(txbPrice.Text)) == 1)
            {
                MessageBox.Show("Producto creado con exito");
                GVAllItems.DataSource = _CN_Products.ShowItems();
            }
            else
                MessageBox.Show("ERROR");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void GVAllItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.GVAllItems.Rows[e.RowIndex];
                    btnEditItem.Enabled = true;
                    txbItemCode.Enabled = false;
                    btnAddItem.Enabled = false;
                    txbItemCode.Text = row.Cells["ItemCode"].Value.ToString();
                    txbDescription.Text = row.Cells["Descriptions"].Value.ToString();
                    txbPrice.Text = row.Cells["Price"].Value.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_CN_Products.CN_UpdateItem(txbItemCode.Text, txbDescription.Text, txbField1.Text, txbField2.Text, txbField3.Text, Convert.ToDouble(txbPrice.Text)) == 1)
                {
                    MessageBox.Show("Producto actualizado con exito");
                    GVAllItems.DataSource = _CN_Products.ShowItems();
                }
                else
                    MessageBox.Show("ERROR");
            }
            catch (Exception)
            {

                
            }
        }
    }
}
