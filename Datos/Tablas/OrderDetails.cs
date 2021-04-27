using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class OrderDetails
    {
        int _orderDetailId;
        int _orderId;
        string _itemCode;
        string _itemDescription;
        decimal _quantity;
        decimal _priceEach;
        decimal _priceTotal;

        public int OrderDetailId { get => _orderDetailId; set => _orderDetailId = value; }
        public int OrderId { get => _orderId; set => _orderId = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ItemDescription { get => _itemDescription; set => _itemDescription = value; }        
        public decimal PriceEach { get => _priceEach; set => _priceEach = value; }
        public decimal PriceTotal { get => _priceTotal; set => _priceTotal = value; }
        public decimal Quantity { get => _quantity; set => _quantity = value; }

        
    }
}
