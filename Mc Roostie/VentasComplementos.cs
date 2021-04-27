using Datos.Tablas;
using Negocios.Metodos;
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
    public partial class VentasComplementos : Form
    {
        List<OrderDetails> orderComplete = new List<OrderDetails>();
        public VentasComplementos()
        {
            InitializeComponent();
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
                    TypeBebida = arguments.Substring(7, arguments.Length - 7);

                    switch (NameButton)
                    {
                        case "btnLess":
                            ModifyQty(NameButton, TypeBebida);
                            break;
                        case "btnMore":
                            ModifyQty(NameButton, TypeBebida);
                            break;
                        case "btnAddItems":

                            break;

                        default:
                            break;
                    }
                    AddProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ModifyQty(string nameButton, string TypeBebida)
        {
            try
            {
                string CurrentQty = "0";
                bool aux;
                switch (nameButton)
                {
                    case "btnLess":
                        CurrentQty = SetQuantity("lbl" + TypeBebida, search: true);
                        aux = (int.TryParse(CurrentQty, out int qty));
                        qty--;
                        if (qty < 0)
                            qty = 0;
                        SetQuantity("lbl" + TypeBebida, qty.ToString());
                        break;
                    case "btnMore":
                        CurrentQty = SetQuantity("lbl" + TypeBebida, search: true);
                        aux = (int.TryParse(CurrentQty, out int qty1));
                        qty1++;
                        SetQuantity("lbl" + TypeBebida, qty1.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string SetQuantity(string TextBoxName, string Qty = "0", bool search = false)
        {
            try
            {
                string qty = "";
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                        if ((control as Label).Name == TextBoxName)
                        {
                            if (search)
                                qty = control.Text;
                            else
                                control.Text = Qty;
                        }
                }
                return qty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void AddProducts()
        {
            try
            {
                orderComplete = new List<OrderDetails>();
                decimal QtySopaM, QtySopaQ, QtySalsaJ, QytSalsaV, QtyMole;

                QtySopaM = Convert.ToDecimal(Convert.ToDecimal(lblSopaM.Text == "" ? "0" : lblSopaM.Text));
                QtySopaQ = Convert.ToDecimal(Convert.ToDecimal(lblSopaQ.Text == "" ? "0" : lblSopaQ.Text));
                QtySalsaJ = Convert.ToDecimal(Convert.ToDecimal(lblSalsaJ.Text == "" ? "0" : lblSalsaJ.Text));
                QytSalsaV = Convert.ToDecimal(Convert.ToDecimal(lblSalsaV.Text == "" ? "0" : lblSalsaV.Text));
                QtyMole = Convert.ToDecimal(Convert.ToDecimal(lblMole.Text == "" ? "0" : lblMole.Text));

                if (QtySopaM > 0)
                    orderComplete.Add(FillOrder("EX-MSopa", QtySopaM));
                if (QtySopaQ > 0)
                    orderComplete.Add(FillOrder("EX-QSopa", QtySopaQ));
                if (QtySalsaJ > 0)
                    orderComplete.Add(FillOrder("EX-SalsaJ", QtySalsaJ));
                if (QytSalsaV > 0)
                    orderComplete.Add(FillOrder("EX-SalsaV", QytSalsaV));
                if (QtyMole > 0)
                    orderComplete.Add(FillOrder("EX-Mole", QtyMole));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
                decimal priceeach = BasePage.ItemsCompleteGlobal.Where(x => x.ItemCode == itemcode).Select(s => new { s.Price }).FirstOrDefault().Price;
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
