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
    public partial class CambioLugar : Form
    {
        public CambioLugar()
        {
            InitializeComponent();
            //CambioLugar.Size = new Size(0, 0);
            //panel1.AutoSize = true;
            crearNuevaMesa();
        }

        private void crearNuevaMesa()
        {

            try
            {
                for (int i = 0; i < BasePage.OrderPlaceGlobal.Count; i++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + BasePage.OrderPlaceGlobal[i].Description.Replace(" ", string.Empty);
                    btn.Height = 80;
                    btn.Width = 200;
                    
                    btn.Location = new Point(100, 50 + (i * 85));
                    btn.Text = BasePage.OrderPlaceGlobal[i].Description;
                    btn.Font = new Font("Georgia", 16);
                    btn.Click += new System.EventHandler(this.btn_Click);

                    Controls.Add(btn);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en lugares de orden");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                BasePage.PlaceToOrder = (sender as Button).Text;
                this.Hide();
                //MessageBox.Show("hola");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
