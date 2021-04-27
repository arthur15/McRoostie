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
    public partial class VentasPollo : Form
    {
        CN_Products _CN_Products = new CN_Products();
        
        //List<Items> itemsComplete = new List<Items>();
        //DataTable data = new DataTable();
        List<OrderDetails> orderComplete = new List<OrderDetails>();
        
        public VentasPollo()
        {
            InitializeComponent();
            //BasePage.OrderCompleteGlobal = null;
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
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string arguments = (sender as Button).Name;
                if(arguments == "btnAddItems")
                {
                    BasePage.OrderCompleteGlobal = orderComplete;
                    this.Hide();
                }
               else
                {
                    string NameButton = string.Empty;
                    string TypePollo = string.Empty;
                    NameButton = arguments.Substring(0, 10);
                    TypePollo = arguments.Substring(10, arguments.Length - 10);
                    ModifyQty(NameButton, TypePollo);                  
                    AddProducts();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void CleanTxbxs()
        {
            try
            {
                lblQtrMcRoostie.Text = "0";
                //txbQtrMcRoostie.Text = "0";
                //txbQtrCarnitas.Text = "0";
                //txbQtrRostizado.Text = "0";
                //txbComMcRoostie.Text = "0";
                //txbComCarnitas.Text = "0";
                //txbComRostizado.Text = "0";
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
                decimal qtyMcRoostieInd, qtyCarnitasInd, qtyMcAsadoInd, qtyMcRoostieMed, qtyCarnitasMed, qtyAsadoMed, QtyMcRoostieCom, QtyCarnitasCom, QtyAsadoCom, QtyMcRoostieOrd, QtyCarnitasOrd, QtyAsaadoOrd;

                qtyMcRoostieInd = Convert.ToDecimal(lblQtrMcRoostie.Text == "" ? "0" : lblQtrMcRoostie.Text);
                qtyCarnitasInd = Convert.ToDecimal(lblQtrCarnitas.Text == "" ? "0" : lblQtrCarnitas.Text);
                qtyMcAsadoInd = Convert.ToDecimal(lblQtrRostizado.Text == "" ? "0" : lblQtrRostizado.Text);
                qtyMcRoostieMed = Convert.ToDecimal(lblMedMcRoostie.Text == "" ? "0" : lblMedMcRoostie.Text);
                qtyCarnitasMed = Convert.ToDecimal(lblMedCarnitas.Text == "" ? "0" : lblMedCarnitas.Text);
                qtyAsadoMed = Convert.ToDecimal(lblMedRostizado.Text == "" ? "0" : lblMedRostizado.Text);
                QtyMcRoostieCom = Convert.ToDecimal(lblComMcRoostie.Text == "" ? "0" : lblComMcRoostie.Text);
                QtyCarnitasCom =  Convert.ToDecimal(lblComCarnitas.Text == "" ? "0" : lblComCarnitas.Text);
                QtyAsadoCom =  Convert.ToDecimal(lblComRostizado.Text == "" ? "0" : lblComRostizado.Text);
                QtyMcRoostieOrd = Convert.ToDecimal(lblOrdMcRoostie.Text == "" ? "0" : lblOrdMcRoostie.Text);
                QtyCarnitasOrd = Convert.ToDecimal(lblOrdCarnitas.Text == "" ? "0" : lblOrdCarnitas.Text);
                QtyAsaadoOrd = Convert.ToDecimal(lblOrdRostizado.Text == "" ? "0" : lblOrdRostizado.Text);

                if(qtyMcRoostieInd > 0)
                    orderComplete.Add(FillOrder("PI-McRoostie", qtyMcRoostieInd));
                if (qtyCarnitasInd > 0)
                    orderComplete.Add(FillOrder("PI-Carnitas", qtyCarnitasInd));
                if (qtyMcAsadoInd > 0)
                    orderComplete.Add(FillOrder("PI-Asado", qtyMcAsadoInd));
                if (qtyMcRoostieMed > 0)
                    orderComplete.Add(FillOrder("PM-McRoostie", qtyMcRoostieMed));
                if (qtyCarnitasMed > 0)
                    orderComplete.Add(FillOrder("PM-Carnitas", qtyCarnitasMed));
                if (qtyAsadoMed > 0)
                    orderComplete.Add(FillOrder("PM-Asasdo", qtyAsadoMed));
                if (QtyMcRoostieCom > 0)
                    orderComplete.Add(FillOrder("PE-McRoostie", QtyMcRoostieCom));
                if (QtyCarnitasCom > 0)
                    orderComplete.Add(FillOrder("PE-Carnitas", QtyCarnitasCom));
                if (QtyAsadoCom > 0)
                    orderComplete.Add(FillOrder("PA-Asado", QtyAsadoCom));
                if (QtyMcRoostieOrd > 0)
                    orderComplete.Add(FillOrder("OP-Plancha", QtyMcRoostieOrd));
                if (QtyCarnitasOrd > 0)
                    orderComplete.Add(FillOrder("OP-Carnitas", QtyCarnitasOrd));
                if (QtyAsaadoOrd > 0)
                    orderComplete.Add(FillOrder("OP-Asado", QtyAsaadoOrd));

                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void ModifyQty(string nameButton, string TypePollo)
        {
            try
            {
                string CurrentQty = "0";
                bool aux;
                string action = nameButton.Substring(0, 7);
                string orderType = nameButton.Substring(7, 3);
                switch(action)
                {
                    case "btnLess":
                        CurrentQty = SetQuantity("lbl"+ orderType + TypePollo, search: true);
                        aux = (int.TryParse(CurrentQty, out int qtyLQ));
                        qtyLQ--;
                        if (qtyLQ < 0)
                            qtyLQ = 0;
                        SetQuantity("lbl" + orderType + TypePollo, qtyLQ.ToString());
                        break;
                    case "btnMore":
                        CurrentQty = SetQuantity("lbl" + orderType + TypePollo, search: true);
                        aux = (int.TryParse(CurrentQty, out int qtyMQ));
                        qtyMQ++;
                        SetQuantity("lbl" + orderType + TypePollo, qtyMQ.ToString());
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
            catch (Exception)
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
