using Negocios.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Tablas;
using System.Data;

namespace Mc_Roostie
{
    public class BasePage
    {
        private static string _placeToOrder;

        private static Users _globalUsers = null;

        public static Users GlobalUsers
        {
            get { return _globalUsers; }
            set { _globalUsers = value; }
        }

        private static Items _ventasPolloGlobal = null;
        private static List<OrderDetails> _orderCompleteGlobal = null;
        private static DataTable _dataGlobal = null;
        private static List<Items> _itemsCompleteGlobal = null;
        private static List<OrderPlace> _orderPlaceGlobal = null;
        private static Promocion _promocionGlobal = null;
        private static decimal _totalOrder;
        private static decimal _CambioPago;
        private static decimal _ShowChangePaid;
        private static int _promoForEdit;
        private static int _promoDetailForDelete;
        private static int _promoForAddProduct;

        public static Items VentasPolloGlobal { get => _ventasPolloGlobal; set => _ventasPolloGlobal = value; }
        public static List<OrderDetails> OrderCompleteGlobal { get => _orderCompleteGlobal; set => _orderCompleteGlobal = value; }
        public static DataTable DataGlobal { get => _dataGlobal; set => _dataGlobal = value; }
        public static List<Items> ItemsCompleteGlobal { get => _itemsCompleteGlobal; set => _itemsCompleteGlobal = value; }
        public static List<OrderPlace> OrderPlaceGlobal { get => _orderPlaceGlobal; set => _orderPlaceGlobal = value; }
        public static string PlaceToOrder { get => _placeToOrder; set => _placeToOrder = value; }
        public static Promocion PromocionGlobal { get => _promocionGlobal; set => _promocionGlobal = value; }
        public static decimal CambioPago { get => _CambioPago; set => _CambioPago = value; }
        public static decimal ShowChangePaid { get => _ShowChangePaid; set => _ShowChangePaid = value; }
        public static decimal TotalOrder { get => _totalOrder; set => _totalOrder = value; }
        public static int PromoForEdit { get => _promoForEdit; set => _promoForEdit = value; }
        public static int PromoDetailForDelete { get => _promoDetailForDelete; set => _promoDetailForDelete = value; }
        public static int PromoForAddProduct { get => _promoForAddProduct; set => _promoForAddProduct = value; }
    }
}
