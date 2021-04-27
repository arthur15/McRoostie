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
    public class CN_Products
    {

        private CD_Items _Cd_Items = new CD_Items();


        public DataTable ShowItems()
        {
            return _Cd_Items.ShowItems();
        }

        public DataTable CN_ShowItemByItemCode(string ItemCode)
        {
            return _Cd_Items.CD_ShowItemByItemCode(ItemCode);
        }

        public int CN_InsertItem(string ItemCode, string Description, string Field1, string Field2, string Field3, double Price)
        {
            return _Cd_Items.CD_InsertItem( ItemCode,  Description,  Field1,  Field2,  Field3,  Price);
        }

        public int CN_UpdateItem(string ItemCode, string Description, string Field1, string Field2, string Field3, double Price)
        {
            return _Cd_Items.CD_UpdateItem(ItemCode, Description, Field1, Field2, Field3, Price);
        }

        public int CN_UpdatePromo(int PromocionId, double Price, bool IsActive)
        {
            return _Cd_Items.CD_UpdatetePromoMain(PromocionId, Price, IsActive);
        }

        public int CN_DeletePromoDetail(int PromocionDetailId)
        {
            return _Cd_Items.CD_DeletePromoDetail(PromocionDetailId);
        }

        public int CN_NewPromocionDetail(PromocionDetail PromocionDetailId)
        {
            return _Cd_Items.CD_NewPromocionDetail(PromocionDetailId);
        }

    } //CD_UpadteItem   CD_DeletePromoDetail CD_NewPromocionDetail
}
