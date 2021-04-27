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
    public class CD_Items
    {
        Connection cone = new Connection();

        public DataTable ShowItems()
        {
            cone._SqlConnect.Open();
            string query = "select * from items";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            cone._SqlConnect.Close();
            return table;
        }

        public DataTable CD_ShowItemByItemCode(string ItemCode)
        {
            cone._SqlConnect.Open();
            string query = "select * from items where itemcode = '"+ItemCode+"'";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            cone._SqlConnect.Close();
            return table;
        }

        public int CD_InsertItem(string ItemCode, string Description, string Field1, string Field2, string Field3, double Price)
        {
            cone._SqlConnect.Open();
            int ban = 0;
            string query = "insert into items values ('" + ItemCode + "', '" + Description + "','" + Field1 + "','" + Field2 + "','" + Field3 + "', "+ Price + ")";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            ban = cmd.ExecuteNonQuery();
            cone._SqlConnect.Close();
            return ban;
        }

        public int CD_UpdateItem(string ItemCode, string Description, string Field1, string Field2, string Field3, double Price)
        {
            cone._SqlConnect.Open();
            int ban = 0;
            string query = "update Items set Descriptions = '"+ Description + "', Price ="+ Price + " where ItemCode = '"+ ItemCode + "'";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            ban = cmd.ExecuteNonQuery();
            cone._SqlConnect.Close();
            return ban;
        }

        public int CD_UpdatetePromoMain(int PromocionId, double Price, bool IsActive)
        {
            cone._SqlConnect.Open();
            int ban = 0;
            int active = 0;
            if (IsActive)
                active = 1;
            string query = "update Promocion set CostPromo = " + Price + ", IsActive =" + active  + " where PromocionId = " + PromocionId + "";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            ban = cmd.ExecuteNonQuery();
            cone._SqlConnect.Close();
            return ban;
        }

        public int CD_DeletePromoDetail(int PromocionDetailId)
        {
            cone._SqlConnect.Open();
            int ban = 0;
            string query = "delete PromocionDetail where PromocionDetailId=" + PromocionDetailId+"";
            SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            ban = cmd.ExecuteNonQuery();
            cone._SqlConnect.Close();
            return ban;
        }

        public int CD_NewPromocionDetail(PromocionDetail _PromocionDetail)
        {

            try
            {
                cone._SqlConnect.Open();
                int ban = 0;
                string query = "insert into PromocionDetail values (" + _PromocionDetail.PromocionId + ", '" + _PromocionDetail.SkuProduct + "'," + _PromocionDetail.QtyProduct + ", 1 ,'" + _PromocionDetail.Descriptions+"') ";               
                query = query.Remove(query.Length - 1);
                SqlCommand cmd = new SqlCommand(query, cone._SqlConnect);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                ban = cmd.ExecuteNonQuery();
                cone._SqlConnect.Close();
                return ban;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cone._SqlConnect.Close();
            }
        }
    }
}
