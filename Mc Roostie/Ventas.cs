using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios.Metodos;
using Datos.Tablas;
using System.Drawing.Printing;

namespace Mc_Roostie
{
    public partial class Ventas : Form
    {
        List<Items> items = new List<Datos.Tablas.Items>();
        List<OrderDetails> orderComplete = new List<OrderDetails>();
        CN_Products _CN_Products = new CN_Products();
        CN_Orders _CN_Orders = new CN_Orders();
        int numTicket = 0;

        public Ventas()
        {
            InitializeComponent();
            btnGetTicket.Enabled = false;
            numTicket = _CN_Orders.LastNumOrder() + 1;
            txbxNumTicket.Text = numTicket.ToString();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            string NameButton = (sender as Button).Name;
            switch (NameButton)
            {
                case "btnDeleteOrder":
                    BasePage.OrderCompleteGlobal.Clear();
                    orderComplete.Clear();
                    gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                    gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    txbTotal.Text = 0.ToString("C2");
                    btnGetTicket.Enabled = false;
                    break;
                case "btnVtaCarnitas":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "Ca-CarnitasPuerco");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "Ca-CarnitasPuerco");
                    DialogCarnitas();
                    break;
                case "btnVtaPollo":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "PI-McRoostie" || a.ItemCode == "PI-Carnitas" || a.ItemCode == "PI-Asado" || a.ItemCode == "PM-McRoostie" || a.ItemCode == "PM-Carnitas" || a.ItemCode == "PM-Asasdo" || a.ItemCode == "PE-McRoostie" || a.ItemCode == "PE-Carnitas" || a.ItemCode == "PA-Asado" || a.ItemCode == "OP-Plancha" || a.ItemCode == "OP-Carnitas" || a.ItemCode == "OP-Asado");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "PI-McRoostie" || a.ItemCode == "PI-Carnitas" || a.ItemCode == "PI-Asado" || a.ItemCode == "PM-McRoostie" || a.ItemCode == "PM-Carnitas" || a.ItemCode == "PM-Asasdo" || a.ItemCode == "PE-McRoostie" || a.ItemCode == "PE-Carnitas" || a.ItemCode == "PA-Asado" || a.ItemCode == "OP-Plancha" || a.ItemCode == "OP-Carnitas" || a.ItemCode == "OP-Asado");
                    DialogPollo();
                    break;
                case "btnVtaAgua":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "BA-Fresca" || a.ItemCode == "BA-FrescaGde" || a.ItemCode == "RC-Refresco" || a.ItemCode == "RT-Refresco" || a.ItemCode == "RC-Familiar");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "BA-Fresca" || a.ItemCode == "BA-FrescaGde" || a.ItemCode == "RC-Refresco" || a.ItemCode == "RT-Refresco" || a.ItemCode == "RC-Familiar");
                    DialogBebidas();
                    break;
                case "btnVtaExtras":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "TD-McRoostie" || a.ItemCode == "TD-Pollo");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "TD-McRoostie" || a.ItemCode == "TD-Pollo");
                    //RemoveItems("TM-Torta", "TD-McRoostie", "HM-Hamburger");
                    DialogExtras();
                    break;
                case "btnVtaTostadas":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "TP-Tostada" || a.ItemCode == "TC-Tostada");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "TP-Tostada" || a.ItemCode == "TC-Tostada");                    
                    DialogTostadas();
                    break;
                case "btnVtaTortas":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "TC-Torta" || a.ItemCode == "TM-Torta");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "TC-Torta" || a.ItemCode == "TM-Torta");
                    DialogTortas();
                    break;
                case "btnVtaComple":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "EX-Mole" || a.ItemCode == "EX-MSopa" || a.ItemCode == "EX-QSopa" || a.ItemCode == "EX-SalsaJ" || a.ItemCode == "EX-SalsaV");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "EX-Mole" || a.ItemCode == "EX-MSopa" || a.ItemCode == "EX-QSopa" || a.ItemCode == "EX-SalsaJ" || a.ItemCode == "EX-SalsaV");
                    DialogComplementos();
                    break;                    
                case "btnChangeLocation":
                    DialogLocation();
                    break;
                case "btnVtaPromo":
                    if (BasePage.OrderCompleteGlobal != null)
                        BasePage.OrderCompleteGlobal.RemoveAll(a => a.ItemCode == "Mc-Promocion");
                    if (orderComplete.Count > 0)
                        orderComplete.RemoveAll(a => a.ItemCode == "Mc-Promocion");
                    DialogPromo();
                    break;
                case "btnLessSmallSoda":
                    LessQty("txbSmallSoda");
                    break;
                case "btnMoreSmallSoda":
                    MoreQty("txbSmallSoda");
                    break;
                case "btnLessBigSoda":
                    LessQty("txbBigSoda");
                    break;
                case "btnMoreBigSoda":
                    MoreQty("txbBigSoda");
                    break;
                case "btnLessTorta":
                    LessQty("tbxTortas");
                    break;
                case "btnMoreTorta":
                    MoreQty("tbxTortas");
                    break;
                case "btnLessTaco":
                    LessQty("txbTaco");
                    break;
                case "btnMoreTaco":
                    MoreQty("txbTaco");
                    break;
                case "btnAddItems":
                    AddProducts();
                    break;
                case "btnGetTicket":
                    BasePage.CambioPago = 0;
                    BasePage.TotalOrder = Convert.ToDecimal(txbTotal.Text.Replace("$", ""));
                    FormPago Fp = new FormPago();
                    DialogResult result = Fp.ShowDialog();
                    if (BasePage.CambioPago >= BasePage.TotalOrder)
                    {
                        BasePage.ShowChangePaid = BasePage.CambioPago - Convert.ToDecimal(txbTotal.Text.Replace("$", ""));
                        FormFinishChange ffc = new FormFinishChange();
                        DialogResult drffc = ffc.ShowDialog();
                        PrintTicket();
                    }
                    else
                    {
                        MessageBox.Show("Es obligatorio introducir una cantidad");
                    }

                    break;
                default:
                    break;
            }
        }


        private void LessQty(string TextBoxName)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    if ((control as TextBox).Name == TextBoxName)
                    {
                        if (int.TryParse(control.Text, out int qty))
                        {
                            qty = Convert.ToInt32(control.Text);
                            qty--;
                            if (qty < 0)
                                qty = 0;
                            control.Text = qty.ToString();
                        }
                        else
                        {
                            control.Text = "0";
                        }

                    }
            }

        }

        private void MoreQty(string TextBoxName)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    if ((control as TextBox).Name == TextBoxName)
                    {
                        if (int.TryParse(control.Text, out int qty))
                        {
                            qty = Convert.ToInt32(control.Text);
                            qty++;
                            control.Text = qty.ToString();
                        }
                        else
                        {
                            control.Text = "1";
                        }
                    }
            }

        }

        private void AddProducts()
        {
            List<Items> itemsComplete = new List<Items>();
            orderComplete = new List<OrderDetails>();
            DataTable data = new DataTable();
            data = _CN_Products.ShowItems();
            foreach (DataRow row in data.Rows)
            {
                Items item = new Items
                {
                    ItemId = Convert.ToInt32(row["ItemId"].ToString()),
                    ItemCode = row["ItemCode"].ToString(),
                    Descriptions = row["Descriptions"].ToString(),
                    Field1 = row["Field1"].ToString(),
                    Field2 = row["Field2"].ToString(),
                    Field3 = row["Field3"].ToString(),
                    Price = Convert.ToDecimal(row["Price"].ToString())
                };
                itemsComplete.Add(item);
            }

            decimal total;
            // QtyPollo = Convert.ToDecimal(txbCantQuaterPollo.Text.Trim().Replace("1/4", "0.25").Replace("1/2", "0.5").Replace("3/4", "0.75")) + Convert.ToDecimal(txbCantPollo.Text == "" ? "0" : txbCantPollo.Text);
            //QtySmallSoda = Convert.ToDecimal(txbSmallSoda.Text == "" ? "0" : txbSmallSoda.Text);
            //QtyBigSoda = Convert.ToDecimal(txbBigSoda.Text == "" ? "0" : txbBigSoda.Text);
            //QtyTortas = Convert.ToDecimal(tbxTortas.Text == "" ? "0" : tbxTortas.Text);
            //QtyTacos = Convert.ToDecimal(txbTaco.Text == "" ? "0" : txbTaco.Text);

            //if (QtyPollo > 0)
            //    orderComplete.Add(FillOrder(itemsComplete, "PE-McRoostie", QtyPollo));
            //if (QtySmallSoda > 0)
            //    orderComplete.Add(FillOrder(itemsComplete, "RC-Refresco", QtySmallSoda));
            //if (QtyBigSoda > 0)
            //    orderComplete.Add(FillOrder(itemsComplete, "RC-Familiar", QtyBigSoda));
            //if (QtyTortas > 0)
            //    orderComplete.Add(FillOrder(itemsComplete, "TM-Torta", QtyTortas));
            //if (QtyTacos > 0)
            //    orderComplete.Add(FillOrder(itemsComplete, "TD-McRoostie", QtyTacos));
            if (BasePage.OrderCompleteGlobal.Count > 0)
            {
                BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
            }
            total = orderComplete.Sum(s => s.PriceTotal);
            gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
            gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            txbTotal.Text = total.ToString("C2");
            if (total > 0)
                btnGetTicket.Enabled = true;
            else
                btnGetTicket.Enabled = false;
        }


        private OrderDetails FillOrder(List<Items> itemsComplete, string itemcode, decimal Qty)
        {
            try
            {
                decimal priceeach = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.Price }).FirstOrDefault().Price;
                OrderDetails Order = new OrderDetails
                {

                    ItemCode = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.ItemCode }).FirstOrDefault().ItemCode,
                    ItemDescription = itemsComplete.Where(x => x.ItemCode == itemcode).Select(s => new { s.Descriptions }).FirstOrDefault().Descriptions,
                    Quantity = Qty,
                    PriceEach = priceeach,
                    PriceTotal = priceeach * Qty
                };
                return Order;
            }
            catch (Exception)
            {

                return null;
            }
        }


        private void PrintTicket()
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument = new PrintDocument();
                PrinterSettings printer = new PrinterSettings();
                printDocument.PrinterSettings = printer;
                printDocument.PrintPage += Imprimir;
                printDocument.Print();

                SaveOrders();
                SetAllTxtBx();
                numTicket = _CN_Orders.LastNumOrder() + 1;
                txbxNumTicket.Text = numTicket.ToString();
                btnGetTicket.Enabled = false;
            }
            catch (Exception ex)
            {


            }
        }

        private void DialogPollo()
        {
            try
            {

                VentasPollo VP = new VentasPollo();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {


            }
        }

        private void DialogCarnitas()
        {
            try
            {
                VentasCarnitas vc = new VentasCarnitas();
                DialogResult dr = vc.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0 && (BasePage.OrderCompleteGlobal.Where(x => x.ItemCode == "Ca-CarnitasPuerco").ToList().Count) > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {


            }
        }

        private void DialogBebidas()
        {
            try
            {

                VentasBebidas VP = new VentasBebidas();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception ex)
            {


            }
        }

        private void DialogTostadas()
        {
            try
            {
                VentasTostadas VP = new VentasTostadas();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {

                
            }
        }

        private void DialogTortas()
        {
            try
            {
                VentasTortas VP = new VentasTortas();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {

                
            }
        }

        private void DialogComplementos()
        {
            try
            {
                VentasComplementos VP = new VentasComplementos();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {

                
            }
        }

        private void DialogExtras()
        {
            try
            {
                VentasExtras VP = new VentasExtras();
                DialogResult result = VP.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception ex)
            {


            }
        }

        private void DialogLocation()
        {
            try
            {
                CambioLugar cl = new CambioLugar();
                DialogResult result = cl.ShowDialog();
                btnChangeLocation.Text = BasePage.PlaceToOrder;
                //BasePage.PlaceToOrder
            }
            catch (Exception)
            {


            }
        }

        private void DialogPromo()
        {
            try
            {
                VtasPromos vp = new VtasPromos();
                DialogResult result = vp.ShowDialog();
                if (BasePage.OrderCompleteGlobal.Count > 0)
                    BasePage.OrderCompleteGlobal.ForEach(x => orderComplete.Add(x));
                decimal total = orderComplete.Sum(s => s.PriceTotal);
                gvDetalle.DataSource = orderComplete.Select(s => new { Cantidad = s.Quantity, Descripcion = s.ItemDescription, PrecioUnitario = s.PriceEach, Subtotal = s.PriceTotal.ToString("C2") }).ToList();
                gvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                txbTotal.Text = total.ToString("C2");
                if (total > 0)
                    btnGetTicket.Enabled = true;
                else
                    btnGetTicket.Enabled = false;
            }
            catch (Exception)
            {


            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            try
            {
                string atn = btnChangeLocation.Text == "Cambiar Lugar" ? "Para llevar" : btnChangeLocation.Text;
                int w = 200;
                int y = 20;
                //string image = @"C:\Users\McRoostie\Documents\ImagesMcRoostie\pollo.jpg";
                string image = @"D:\Documentos\Mc Roostie\Mc Roostie\Mc Roostie\Assets\pollo.jpg";
                Font fontHeader = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
                Font font = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                Image img = null;
                if (System.IO.File.Exists(image))
                {
                    img = Image.FromFile(image);
                    e.Graphics.DrawImage(img, new Rectangle(0, y, 50, 60));
                }
                e.Graphics.DrawString("--Mc Roostie--", fontHeader, Brushes.Black, new RectangleF(70, y += 15, w, 20));
                e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 45, w, 50));
                e.Graphics.DrawString("Numero de ticket....." + txbxNumTicket.Text, fontHeader, Brushes.Black, new RectangleF(0, y += 25, w, 20));
                e.Graphics.DrawString(" ", fontHeader, Brushes.Black, new RectangleF(20, y += 25, w, 20));
                e.Graphics.DrawString("CONSUMO", font, Brushes.Black, new RectangleF(50, y += 15, w, 20));
                e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 45, w, 50)); //txbxNumTicket
                orderComplete.ForEach(x =>
                {
                    e.Graphics.DrawString(x.Quantity + "    " + x.ItemDescription + "", font, Brushes.Black, new RectangleF(0, y += 25, w, 15));
                    e.Graphics.DrawString("" + x.PriceTotal.ToString("C2"), font, Brushes.Black, new RectangleF(140, y, w, 15));
                });
                e.Graphics.DrawString("_____________________________", font, Brushes.Black, new RectangleF(0, y += 45, w, 50));
                e.Graphics.DrawString("TOTAL...........", fontHeader, Brushes.Black, new RectangleF(0, y += 25, w, 20));
                e.Graphics.DrawString(" " + orderComplete.Sum(s => s.PriceTotal).ToString("C2"), fontHeader, Brushes.Black, new RectangleF(100, y, w, 20));
                e.Graphics.DrawString("Su pago...........", font, Brushes.Black, new RectangleF(0, y += 25, w, 20));
                e.Graphics.DrawString("     " + BasePage.CambioPago.ToString("C2"), font, Brushes.Black, new RectangleF(100, y, w, 20));
                e.Graphics.DrawString("Su cambio...........", font, Brushes.Black, new RectangleF(0, y += 25, w, 20));
                e.Graphics.DrawString("     " + BasePage.ShowChangePaid.ToString("C2"), font, Brushes.Black, new RectangleF(100, y, w, 20));
                e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 45, w, 50));
                e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 45, w, 50));
                e.Graphics.DrawString("Usted fue atendido en:" + atn, font, Brushes.Black, new RectangleF(0, y, w, 20));
                e.Graphics.DrawString("fecha...", font, Brushes.Black, new RectangleF(50, y += 15, w, 20));
                e.Graphics.DrawString("telefono", font, Brushes.Black, new RectangleF(50, y += 15, w, 20));
                e.Graphics.DrawString("direccion", font, Brushes.Black, new RectangleF(50, y += 15, w, 20));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetAllTxtBx()
        {
            try
            {
                //txbCantQuaterPollo.Text = "0";
                //txbCantPollo.Text = "";
                //txbSmallSoda.Text = "";
                //txbBigSoda.Text = "";
                //tbxTortas.Text = "";
                //txbTaco.Text = "";
                gvDetalle.DataSource = null;
                txbTotal.Text = "";
            }
            catch (Exception)
            {


            }
        }

        private void SaveOrders()
        {
            try
            {
                //List<OrderDetails> _OrderDetails = new List<OrderDetails>();
                Orders _Orders = new Orders
                {
                    OrderId = numTicket
                    ,
                    CustomerId = 1
                    ,
                    OrderDate = DateTime.Now
                    ,
                    SubTotal = orderComplete.Sum(s => s.PriceTotal)
                    ,
                    Tax = 0
                    ,
                    Shipping = false
                    ,
                    Total = orderComplete.Sum(s => s.PriceTotal)
                    ,
                    UsersId = BasePage.GlobalUsers.UsersId == 0 ? 1 : BasePage.GlobalUsers.UsersId
                    ,
                    Notes = ""
                    ,
                    OrderPlaceId = 1
                    ,
                    OrderDetails = orderComplete
                };
                _CN_Orders.CN_NewOrder(_Orders);
                BasePage.OrderCompleteGlobal = null;
                RemoveAllItems();
            }
            catch (Exception)
            {


            }
        }

        private void RemoveAllItems()
        {
            try
            {
                if (BasePage.OrderCompleteGlobal != null)
                    BasePage.OrderCompleteGlobal.RemoveRange(0, BasePage.OrderCompleteGlobal.Count);
                if (orderComplete.Count > 0)
                    orderComplete.RemoveRange(0, orderComplete.Count);

            }
            catch (Exception)
            {


            }
        }

        private void btnPagaBills_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
