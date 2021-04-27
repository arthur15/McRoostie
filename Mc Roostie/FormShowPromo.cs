using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Tablas;
using Negocios;
using Negocios.Metodos;


namespace Mc_Roostie
{
    public partial class FormShowPromo : Form
    {
        CN_Orders _CN_Orders = new CN_Orders();
        CN_Products _CN_Products = new CN_Products();

        public FormShowPromo()
        {
            InitializeComponent();             
            GVAllPromo.DataSource = _CN_Orders.CN_GetAllPromocion();
        }

        private void btnEditPromotail_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblIdPromo.Text) > 0)
            {

                FormEditPromoDetail fepd = new FormEditPromoDetail();
                DialogResult dr = fepd.ShowDialog();
            }
            else
                MessageBox.Show("Debe seleccionar una promocion.");
        }

        private void btnEditPromo_Click(object sender, EventArgs e)
        {
            try
            {
                if((_CN_Products.CN_UpdatePromo(int.Parse(lblIdPromo.Text), double.Parse(txbPrice.Text), CkBxIsActive.Checked))==1)
                {
                    MessageBox.Show("Promocion Actualizada Exitosamente");
                    GVAllPromo.DataSource = _CN_Orders.CN_GetAllPromocion();
                }
                //CN_UpadPromo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void GVAllPromo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //BasePage.PromoForEdit = 

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.GVAllPromo.Rows[e.RowIndex];
                    lblIdPromo.Text = row.Cells["PromocionId"].Value.ToString();
                    lblDiaPromo.Text = row.Cells["PromotionName"].Value.ToString();
                    txbPrice.Text = row.Cells["CostPromo"].Value.ToString();
                    CkBxIsActive.Checked = (bool)row.Cells["IsActive"].Value;
                    BasePage.PromoForEdit = int.Parse(row.Cells["PromocionId"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
    }
}
