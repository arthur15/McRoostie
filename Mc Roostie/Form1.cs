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
    public partial class Form1 : Form
    {
        //BasePage _base = new BasePage();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                CN_Login _CN_Login = new CN_Login();

                Users _Users = _CN_Login.CN_GetUserLogin("JDLoco", "sasas");
                //Users _Users = _CN_Login.CN_GetUserLogin(txtUsuario.Text, txtContrasena.Text);
                if (_Users.UsersId > 0)
                {
                    BasePage.GlobalUsers = _Users;
                    SetValues();
                    this.Hide();
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                }
                else
                    MessageBox.Show("incorrecto");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SetValues()
        {
            try
            {
                List<Items> itemsComplete = new List<Items>();
                List<OrderPlace> _OrderPlaceList = new List<OrderPlace>();
                CN_Products _CN_Products = new CN_Products();
                CN_Orders _CN_Orders = new CN_Orders();
                BasePage.DataGlobal = _CN_Products.ShowItems();
                foreach (DataRow row in BasePage.DataGlobal.Rows)
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
                BasePage.ItemsCompleteGlobal = itemsComplete;
                DataTable OrderPlaces = _CN_Orders.CN_GetOrderPlaces();

                BasePage.PromocionGlobal = _CN_Orders.CN_GetPromocionbyPromoId();


                foreach (DataRow row in OrderPlaces.Rows)
                {
                    OrderPlace _OrderPlace = new OrderPlace
                    {
                        OrderPlaceId = Convert.ToInt32(row["OrderPlaceId"].ToString()),
                        Description = row["Description"].ToString()
                    };
                    _OrderPlaceList.Add(_OrderPlace);
                }
                BasePage.OrderPlaceGlobal = _OrderPlaceList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
