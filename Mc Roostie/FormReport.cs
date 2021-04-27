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
    public partial class FormReport : Form
    {
        CN_Orders _CN_Orders = new CN_Orders();

        public FormReport()
        {
            InitializeComponent();
            List<string> items = new List<string>() {"Todas", "Aceptada", "Cancelada" };
            cbStatus.DataSource = items;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string start = dtpStart.Value.ToString("yyyy-MM-dd");
                string end = dtpEnd.Value.ToString("yyyy-MM-dd");
                string status = cbStatus.SelectedValue.ToString() == "Todas" ? "" : " and StatusOrder ='"+ cbStatus.SelectedValue.ToString()+"'";
                string users = txbxUser.Text == "" ? "" : " and UsersId =" + txbxUser.Text;
                string atencion = txbxLugar.Text == "" ? "" : " and OrderPlaceId =" + txbxLugar.Text;
                string where = " and OrderDate Between '"+ start + "' and '" + end + "' "+ status + " "+users+ " " +atencion+"";
                List<Orders> ordersReport = _CN_Orders.CN_GetOrderForReport(where);
                List<OrderDetails> details = new List<OrderDetails>();
                ordersReport.ForEach( x => x.OrderDetails.ForEach(y => details.Add(y)));   

                gvReport.DataSource = ordersReport;
                gvOrderDetails.DataSource = details;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
