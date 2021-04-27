using Datos.Tablas;
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
    public partial class VtasPromos : Form
    {
        List<OrderDetails> orderComplete = new List<OrderDetails>();

        public VtasPromos()
        {
            InitializeComponent();
            LblNombrePromocion.Text = BasePage.PromocionGlobal.PromotionName;
            lblCostoPromo.Text = BasePage.PromocionGlobal.CostPromo.ToString("C");
            gvDetailPromocion.DataSource = BasePage.PromocionGlobal.PromocionDetails.Select(s => new { DescripcionProducto =  s.Descriptions, CantidadIncluida =  s.QtyProduct }).ToList();
            gvDetailPromocion.Columns[0].Width = 200;
            gvDetailPromocion.Columns[0].Width = 200;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string arguments = (sender as Button).Name;
                if (arguments == "btnAddItems")
                {
                    BasePage.OrderCompleteGlobal = orderComplete;
                    this.Hide();
                }
                else
                {
                    string NameButton = string.Empty;
                    string TypeBebida = string.Empty;
                    NameButton = arguments.Substring(0, 7);

                    switch (NameButton)
                    {
                        case "btnLess":
                            ModifyQty(NameButton);
                            break;
                        case "btnMore":
                            ModifyQty(NameButton);
                            break;
                        case "btnAddItems":

                            break;

                        default:
                            break;
                    }
                    AddProducts();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ModifyQty(string nameButton)
        {
            try
            {
                string CurrentQty = "0";
                bool aux;
                switch (nameButton)
                {
                    case "btnLess":
                        CurrentQty = SetQuantity("txbQtyPromo", search: true);
                        aux = (int.TryParse(CurrentQty, out int qty));
                        qty--;
                        if (qty < 0)
                            qty = 0;
                        SetQuantity("txbQtyPromo", qty.ToString());
                        break;
                    case "btnMore":
                        CurrentQty = SetQuantity("txbQtyPromo", search: true);
                        aux = (int.TryParse(CurrentQty, out int qty1));
                        qty1++;
                        SetQuantity("txbQtyPromo", qty1.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string SetQuantity(string TextBoxName, string Qty = "0", bool search = false)
        {
            try
            {
                string qty = "";
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                        if ((control as TextBox).Name == TextBoxName)
                        {
                            if (search)
                                qty = control.Text;
                            else
                                control.Text = Qty;
                        }
                }
                return qty;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AddProducts()
        {
            try
            {
                orderComplete = new List<OrderDetails>();
                //txbQtyPromo
                decimal QtyPromo;

                QtyPromo = Convert.ToDecimal(Convert.ToDecimal(txbQtyPromo.Text == "" ? "0" : txbQtyPromo.Text));
                

                if (QtyPromo > 0)
                    orderComplete.Add(FillOrder("Mc-Promocion", QtyPromo));
              
                decimal total = orderComplete.Sum(s => s.PriceTotal);
              
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private OrderDetails FillOrder(string itemcode, decimal Qty)
        {
            try
            {
                //decimal priceeach = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.Price }).FirstOrDefault().Price;
                decimal priceeach = BasePage.PromocionGlobal.CostPromo;
                OrderDetails Order = new OrderDetails
                {
                    //ItemCode = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.ItemCode }).FirstOrDefault().ItemCode,
                    //ItemDescription = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.Descriptions }).FirstOrDefault().Descriptions,
                    ItemCode = BasePage.ItemsCompleteGlobal.Where(x => x.ItemCode == itemcode).Select(s => new { s.ItemCode }).FirstOrDefault().ItemCode,
                    ItemDescription = BasePage.ItemsCompleteGlobal.Where(x => x.ItemCode == itemcode).Select(s => new { s.Descriptions }).FirstOrDefault().Descriptions,
                    Quantity = Qty,
                    PriceEach = priceeach,
                    PriceTotal = priceeach * Qty
                };
                return Order;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
