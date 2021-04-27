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
    public partial class FormEditPromoDetail : Form
    {
        CN_Orders _CN_Orders = new CN_Orders();
        CN_Products _CN_Products = new CN_Products();

        public FormEditPromoDetail()
        {
            InitializeComponent();
            GVAllPromoDetail.DataSource = _CN_Orders.CN_GetPromocionDetailbyPromoId(BasePage.PromoForEdit);
        }

        private void GVAllPromoDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.GVAllPromoDetail.Rows[e.RowIndex];
                    lblIdPromotionDetail.Text = row.Cells["PromocionDetailId"].Value.ToString();
                    lblDescription.Text = row.Cells["Descriptions"].Value.ToString();                   
                    BasePage.PromoDetailForDelete = int.Parse(row.Cells["PromocionDetailId"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDetailPromo_Click(object sender, EventArgs e)
        {
            try
            {
                if(_CN_Products.CN_DeletePromoDetail(int.Parse(lblIdPromotionDetail.Text)) == 1)
                {
                    GVAllPromoDetail.DataSource = _CN_Orders.CN_GetPromocionDetailbyPromoId(BasePage.PromoForEdit);
                    MessageBox.Show("Producto eliminado con exito de la promocion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddItemPromo_Click(object sender, EventArgs e)
        {
            FormAddProductPromo fepd = new FormAddProductPromo();
            DialogResult dr = fepd.ShowDialog();
            GVAllPromoDetail.DataSource = _CN_Orders.CN_GetPromocionDetailbyPromoId(BasePage.PromoForEdit);
        }
    }
}
