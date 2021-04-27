using Datos.Tablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Metodos
{
    public class CD_Orders
    {

        Connection conOrders = new Connection();


        public int LastNumOrder()
        {
            try
            {
                int count = 0;

                conOrders._SqlConnect.Open();
                string query = "select MAX(orderid) from Orders";
                SqlCommand sqlCommand = new SqlCommand(query, conOrders._SqlConnect);
                count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                conOrders._SqlConnect.Close();

                return count;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
                           
        }

        public Orders CD_GetOrderByOrderId(int orderid)
        {
            try
            {
                conOrders._SqlConnect.Open();
                Orders _OrderReturn = new Orders();
                string query = "select * from Orders where OrderId = " + orderid;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();
                DataTable _OrderDetail = CD_GetOrderDetailByOrderId(orderid);
                List<OrderDetails> _OrderDetailsComplete = new List<OrderDetails>();
                foreach (DataRow row in _OrderDetail.Rows)
                {
                    OrderDetails _OrderDetails = new OrderDetails
                    {
                        OrderDetailId = Convert.ToInt32(row["OrderDetailId"].ToString()),
                        OrderId = Convert.ToInt32(row["OrderId"].ToString()),
                        ItemCode = row["ItemCode"].ToString(),
                        ItemDescription = row["ItemDescription"].ToString(),
                        Quantity = Convert.ToDecimal(row["Quantity"].ToString()),
                        PriceEach = Convert.ToDecimal(row["PriceEach"].ToString()),
                        PriceTotal = Convert.ToDecimal(row["PriceTotal"].ToString())
                    };
                    _OrderDetailsComplete.Add(_OrderDetails);
                }

                foreach (DataRow row in table.Rows)
                {
                    Orders _Orders = new Orders
                    {
                        OrderId = Convert.ToInt32(row["OrderId"].ToString()),
                        CustomerId = Convert.ToInt32(row["CustomerId"].ToString()),
                        OrderDate = Convert.ToDateTime(row["OrderDate"].ToString()),
                        SubTotal = Convert.ToDecimal(row["SubTotal"].ToString()),
                        Tax = Convert.ToDecimal(row["Tax"].ToString()),
                        Shipping = Convert.ToBoolean(row["Shipping"].ToString()),
                        Total = Convert.ToDecimal(row["Total"].ToString()),
                        UsersId = Convert.ToInt32(row["UsersId"].ToString()),
                        Notes = row["Notes"].ToString(),
                        OrderPlaceId = Convert.ToInt32(row["OrderPlaceId"].ToString()),
                        StatusOrder = row["StatusOrder"].ToString(),
                        OrderDetails = _OrderDetailsComplete
                    };
                    _OrderReturn = _Orders;
                }
                return _OrderReturn;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }

        public List<Orders> CD_GetOrderForReport(string Conditions)
        {
            try
            {
                conOrders._SqlConnect.Open();
                List<Orders> _OrderReturn = new List<Orders>();
                string query = "select * from Orders where 1 = 1 ";
                if (Conditions != "")
                    query = query + Conditions;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();               

                foreach (DataRow row in table.Rows)
                {
                    Orders _Orders = new Orders
                    {
                        OrderId = Convert.ToInt32(row["OrderId"].ToString()),
                        CustomerId = Convert.ToInt32(row["CustomerId"].ToString()),
                        OrderDate = Convert.ToDateTime(row["OrderDate"].ToString()),
                        SubTotal = Convert.ToDecimal(row["SubTotal"].ToString()),
                        Tax = Convert.ToDecimal(row["Tax"].ToString()),
                        Shipping = Convert.ToBoolean(row["Shipping"].ToString()),
                        Total = Convert.ToDecimal(row["Total"].ToString()),
                        UsersId = Convert.ToInt32(row["UsersId"].ToString()),
                        Notes = row["Notes"].ToString(),
                        OrderPlaceId = Convert.ToInt32(row["OrderPlaceId"].ToString()),
                        StatusOrder = row["StatusOrder"].ToString(),
                        OrderDetails = CD_GetOrderDetailsByOrderIdN(Convert.ToInt32(row["OrderId"].ToString()))
                    };
                    _OrderReturn.Add(_Orders);
                }
                return _OrderReturn;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }

        public List<OrderDetails> CD_GetOrderDetailsByOrderIdN(int orderid)
        {
            try
            {
                DataTable _OrderDetail = CD_GetOrderDetailByOrderId(orderid);
                List<OrderDetails> _OrderDetailsComplete = new List<OrderDetails>();
                foreach (DataRow row in _OrderDetail.Rows)
                {
                    OrderDetails _OrderDetails = new OrderDetails
                    {
                        OrderDetailId = Convert.ToInt32(row["OrderDetailId"].ToString()),
                        OrderId = Convert.ToInt32(row["OrderId"].ToString()),
                        ItemCode = row["ItemCode"].ToString(),
                        ItemDescription = row["ItemDescription"].ToString(),
                        Quantity = Convert.ToDecimal(row["Quantity"].ToString()),
                        PriceEach = Convert.ToDecimal(row["PriceEach"].ToString()),
                        PriceTotal = Convert.ToDecimal(row["PriceTotal"].ToString())
                    };
                    _OrderDetailsComplete.Add(_OrderDetails);
                }
                return _OrderDetailsComplete;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable CD_GetOrderDetailByOrderId(int orderid)
        {
            try
            {
                conOrders._SqlConnect.Open();
                string query =  "select * from orderdetails where OrderId = "+ orderid;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();
                return table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }

        public Promocion GetPromocionbyPromoId()
        {
            try
            {
                Promocion promocion = new Promocion();
                conOrders._SqlConnect.Open();
                StringBuilder sb = new StringBuilder();

                sb.Append(" select * from promocion ");
                sb.Append(" where isActive=1 and  Upper(DayActive) = (");
                sb.Append(" SELECT (CASE DATENAME(dw,GETDATE())");
                sb.Append("      when 'Monday' then 'LUNES'");
                sb.Append("      when 'Tuesday' then 'MARTES'");
                sb.Append("      when 'Wednesday' then 'MIERCOLES'");
                sb.Append("      when 'Thursday' then 'JUEVES'");
                sb.Append("      when 'Friday' then 'VIERNES'");
                sb.Append("      when 'Saturday' then 'SABADO'");
                sb.Append("      when 'Sunday' then 'DOMINGO'");
                sb.Append(" END))");

                string query = sb.ToString();//"select * from Promocion where promocionid = " + PromocionId;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();
                foreach (DataRow row in table.Rows)
                {
                    Promocion _promo = new Promocion
                    {
                        PromocionId = Convert.ToInt32(row["PromocionId"].ToString()),
                        PromotionName = row["PromotionName"].ToString(),
                        DayActive = row["DayActive"].ToString(),
                        CostPromo = Convert.ToDecimal(row["CostPromo"].ToString()),
                        IsActive = Convert.ToBoolean(row["IsActive"].ToString()),
                        
                    };
                    promocion = _promo;
                }

                return promocion;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }


        public List<Promocion> GetAllPromocion()
        {
            try
            {
                List<Promocion> promocion = new List<Promocion>();
                conOrders._SqlConnect.Open();
                StringBuilder sb = new StringBuilder();

                sb.Append(" select * from promocion ");           

                string query = sb.ToString();//"select * from Promocion where promocionid = " + PromocionId;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();
                foreach (DataRow row in table.Rows)
                {
                    Promocion _promo = new Promocion
                    {
                        PromocionId = Convert.ToInt32(row["PromocionId"].ToString()),
                        PromotionName = row["PromotionName"].ToString(),
                        DayActive = row["DayActive"].ToString(),
                        CostPromo = Convert.ToDecimal(row["CostPromo"].ToString()),
                        IsActive = Convert.ToBoolean(row["IsActive"].ToString()),

                    };
                    promocion.Add(_promo);
                }

                return promocion;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }


        public List<PromocionDetail> GetPromocionDetailbyPromoId(int PromocionId)
        {
            try
            {
                List<PromocionDetail> _promocionDetails = new List<PromocionDetail>();
                

                conOrders._SqlConnect.Open();
                string query = "select * from PromocionDetail where promocionid = " + PromocionId;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();

                foreach (DataRow row in table.Rows)
                {
                    PromocionDetail _promo = new PromocionDetail
                    {
                        PromocionDetailId = Convert.ToInt32(row["PromocionDetailId"].ToString()),
                        PromocionId = Convert.ToInt32(row["PromocionId"].ToString()),
                        SkuProduct = row["SkuProduct"].ToString(),
                        QtyProduct = Convert.ToInt32(row["QtyProduct"].ToString()),
                        IsActive = Convert.ToBoolean(row["IsActive"].ToString()),
                        Descriptions = row["Descriptions"].ToString()
                    };
                    _promocionDetails.Add(_promo);
                }
                return _promocionDetails;
                    
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }

        public DataTable CD_GetOrderPlaces()
        {
            try
            {
                conOrders._SqlConnect.Open();
                string query = "select * from OrderPlace " ;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                conOrders._SqlConnect.Close();
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }


        public int CD_NewOrder(Orders _Orders)
        {

            try
            {
                conOrders._SqlConnect.Open();
                int ban = 0;
                string query = "insert into Orders values (" + _Orders.CustomerId + ", GETDATE()," + _Orders.SubTotal + "," + _Orders.Tax + "," + (_Orders.Shipping == false ? 0 : 1) + ", " + _Orders.Total + ", "+_Orders.UsersId+",'" + _Orders.Notes + "', " + _Orders.OrderPlaceId + ", Aceptada) ";
                if (_Orders.OrderDetails != null)
                {
                    query += " insert into OrderDetails values ";
                    _Orders.OrderDetails.ForEach(x =>
                    {
                        query += "( " + _Orders.OrderId + ", '" + x.ItemCode + "', '" + x.ItemDescription + "', " + x.Quantity + ", " + x.PriceEach + ", " + x.PriceTotal + " ),";
                    });
                }
                query = query.Remove(query.Length - 1);
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                ban = cmd.ExecuteNonQuery();
                conOrders._SqlConnect.Close();
                return ban;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }

        public int CD_UpdateOrderStatus(Orders _Orders)
        {
            try
            {
                conOrders._SqlConnect.Open();
                int ban = 0;
                string query = "update Orders set StatusOrder = '" + _Orders.StatusOrder + "' where orderid = "+ _Orders.OrderId;
                SqlCommand cmd = new SqlCommand(query, conOrders._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                ban = cmd.ExecuteNonQuery();
                conOrders._SqlConnect.Close();
                return ban;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conOrders._SqlConnect.Close();
            }
        }
    }
}
