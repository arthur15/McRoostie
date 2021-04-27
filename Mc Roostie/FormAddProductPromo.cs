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
    public partial class FormAddProductPromo : Form
    {
        CN_Orders _CN_Orders = new CN_Orders();
        CN_Products _CN_Products = new CN_Products();

        public FormAddProductPromo()
        {
            InitializeComponent();            
            gvListItem.DataSource = BasePage.ItemsCompleteGlobal.Select( s => new { CodigoProducto = s.ItemCode, Descripcion = s.Descriptions, Precio = s.Price.ToString("C2") }).ToList();
            gvListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception)
            {

                
            }
        }

        private void gvListItem_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.gvListItem.Rows[e.RowIndex];
                    lblItemCode.Text = row.Cells["CodigoProducto"].Value.ToString();
                    lblDescription.Text = row.Cells["Descripcion"].Value.ToString();
                   // BasePage.PromoDetailForDelete = int.Parse(row.Cells["PromocionDetailId"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(textBox1.Text, out decimal qty))
                {
                    PromocionDetail _promocionDetail = new PromocionDetail();
                    _promocionDetail.PromocionId = BasePage.PromoForEdit;
                    _promocionDetail.SkuProduct = lblItemCode.Text;
                    _promocionDetail.Descriptions = lblDescription.Text;
                    _promocionDetail.QtyProduct = int.Parse(textBox1.Text);
                    int a =_CN_Products.CN_NewPromocionDetail(_promocionDetail);
                    DialogResult dialogResult = MessageBox.Show("Producto agregado exitosamente", "", MessageBoxButtons.OK);
                    if (dialogResult.ToString() == "OK")
                    {
                        this.Hide();
                    }
                    //MessageBox.Show("Producto agregado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //BasePage.PromoForEdit
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!decimal.TryParse(textBox1.Text, out decimal qty))
                {
                    textBox1.Text = "";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
