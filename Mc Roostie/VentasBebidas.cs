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

    public partial class VentasBebidas : Form
    {
        //CN_Products _CN_Products = new CN_Products();

        //List<Items> itemsComplete = new List<Items>();
        //DataTable data = new DataTable();
        List<OrderDetails> orderComplete = new List<OrderDetails>();

        public VentasBebidas()
        {
            InitializeComponent();
           // BasePage.OrderCompleteGlobal = null;
            //CleanTxbxs();
            try
            {

                //data = _CN_Products.ShowItems();
                //foreach (DataRow row in data.Rows)
                //{
                //    Items item = new Items
                //    {
                //        ItemId = Convert.ToInt32(row["ItemId"].ToString()),
                //        ItemCode = row["ItemCode"].ToString(),
                //        Descriptions = row["Descriptions"].ToString(),
                //        Field1 = row["Field1"].ToString(),
                //        Field2 = row["Field2"].ToString(),
                //        Field3 = row["Field3"].ToString(),
                //        Price = Convert.ToDecimal(row["Price"].ToString())
                //    };
                //    itemsComplete.Add(item);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                decimal QtyAgua, QtySodaInd, QtySodaFam, QtyAguaG, QytSodaTap;

                QtyAgua = Convert.ToDecimal(Convert.ToDecimal(lblAgua.Text == "" ? "0" : lblAgua.Text));
                QtyAguaG = Convert.ToDecimal(Convert.ToDecimal(lblAguaG.Text == "" ? "0" : lblAguaG.Text));
                QtySodaInd = Convert.ToDecimal( Convert.ToDecimal(lblSodaInd.Text == "" ? "0" : lblSodaInd.Text));
                QytSodaTap = Convert.ToDecimal(Convert.ToDecimal(lblSodaTap.Text == "" ? "0" : lblSodaTap.Text));
                QtySodaFam = Convert.ToDecimal( Convert.ToDecimal(lblSodaFam.Text == "" ? "0" : lblSodaFam.Text));

                if (QtyAgua > 0)
                    orderComplete.Add(FillOrder("BA-Fresca", QtyAgua));
                if (QtyAguaG > 0)
                    orderComplete.Add(FillOrder("BA-FrescaGde", QtyAguaG));
                if (QtySodaInd > 0)
                    orderComplete.Add(FillOrder("RC-Refresco", QtySodaInd));
                if (QytSodaTap > 0)
                    orderComplete.Add(FillOrder("RT-Refresco", QytSodaTap));
                if (QtySodaFam > 0)
                    orderComplete.Add(FillOrder("RC-Familiar", QtySodaFam));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
