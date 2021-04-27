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
    public partial class VentasCarnitas : Form
    {
        CN_Products _CN_Products = new CN_Products();
        decimal priceeach = BasePage.ItemsCompleteGlobal.Where(x => x.ItemCode == "Ca-CarnitasPuerco").Select(s => new { s.Price }).FirstOrDefault().Price;
        //List<Items> itemsComplete = new List<Items>();
        //DataTable data = new DataTable();
        List<OrderDetails> orderComplete = new List<OrderDetails>();


        public VentasCarnitas()
        {
            InitializeComponent();
            lblKiloPrice.Text = priceeach.ToString("C");
        }
        private void AddProducts()
        {

        }

        private void txbWeight_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal pesos = Convert.ToDecimal(txbCash.Text) * priceeach;
            //    txbCash.Text = Math.Round((pesos), 2).ToString();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void txbCash_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (decimal.TryParse(txbCash.Text, out decimal qty))
                {
                    decimal gramos = 1000 / priceeach * Convert.ToDecimal(txbCash.Text);
                    txbWeight.Text = Math.Round((gramos / 1000), 3).ToString();
                }
                else
                {
                    txbCash.Text = "0";
                    txbWeight.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txbWeight_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (decimal.TryParse(txbWeight.Text, out decimal qty))
                {
                    decimal pesos = Convert.ToDecimal(qty) * priceeach;
                    txbCash.Text = Math.Round((pesos), 2).ToString();

                }
                else
                {
                    txbCash.Text = "0";
                    txbWeight.Text = "0";
                }
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
                //decimal priceeach = BasePage.ItemsCompleteGlobal.Where(x => x.ItemCode == itemcode).Select(s => new { s.Price }).FirstOrDefault().Price;
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
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txbWeight.Text, out decimal qty))
                {

                    orderComplete = new List<OrderDetails>();
                    orderComplete.Add(FillOrder("Ca-CarnitasPuerco", Convert.ToDecimal(txbWeight.Text)));
                    BasePage.OrderCompleteGlobal = orderComplete;

                }                
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
