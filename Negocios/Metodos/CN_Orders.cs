using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Metodos;
using Datos.Tablas;

namespace Negocios.Metodos
{
    public class CN_Orders
    {

       private CD_Orders _CD_Orders = new CD_Orders();


        public int LastNumOrder()
        {
            return _CD_Orders.LastNumOrder();
        }

        public DataTable CN_GetOrderDetailByOrderId(int orderid)
        {
            try
            {  
                return _CD_Orders.CD_GetOrderDetailByOrderId(orderid);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable CN_GetOrderPlaces()
        {
            try
            {
                return _CD_Orders.CD_GetOrderPlaces();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int CN_NewOrder(Orders _Orders)
        {
            try
            {
                _CD_Orders.CD_NewOrder(_Orders);
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Promocion CN_GetPromocionbyPromoId()
        {
            try
            {
                return _CD_Orders.GetPromocionbyPromoId();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Promocion> CN_GetAllPromocion()
        {
            try
            {
                return _CD_Orders.GetAllPromocion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PromocionDetail> CN_GetPromocionDetailbyPromoId(int PromoId)
        {
            try
            {
                return _CD_Orders.GetPromocionDetailbyPromoId(PromoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Orders CN_GetOrderByOrderId(int Orderid)
        {
            try
            {
                return _CD_Orders.CD_GetOrderByOrderId(Orderid);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int CN_UpdateOrderStatus(Orders _Orders)
        {
            try
            {
                return _CD_Orders.CD_UpdateOrderStatus(_Orders);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Orders> CN_GetOrderForReport(string conditions)
        {
            try
            {
                return _CD_Orders.CD_GetOrderForReport(conditions);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }  //CD_GetOrderByOrderId int CD_UpdateOrderStatus(Orders _Orders)
}
