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
    public partial class FormCancelOrder : Form
    {
        CN_Orders _CN_Orders = new CN_Orders();
        CN_Products _CN_Products = new CN_Products();
        Orders _Orders = new Orders();

        public FormCancelOrder()
        {
            InitializeComponent();
            _Orders = new Orders();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txbxOrderid.Text, out int OrderId))
            {
                _Orders = _CN_Orders.CN_GetOrderByOrderId(OrderId);
            }
            if (_Orders.OrderId != 0)
            {
                lblDate.Text = _Orders.OrderDate.ToShortDateString();
                lblStatus.Text = _Orders.StatusOrder;
                LblTotal.Text = _Orders.Total.ToString("C");
                lblUserId.Text = _Orders.UsersId.ToString();
                gvOrderDetail.DataSource = _Orders.OrderDetails;
            }
            else
                MessageBox.Show("No existe la orden numero  " + txbxOrderid.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _Orders.StatusOrder = _Orders.StatusOrder == "Aceptada" ? "Cancelada" : "Aceptada";
                
                int a = _CN_Orders.CN_UpdateOrderStatus(_Orders);
                if(a == 1)
                {
                    MessageBox.Show("Estatus actualizado exitosamente");
                    lblStatus.Text = _Orders.StatusOrder;
                }
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
