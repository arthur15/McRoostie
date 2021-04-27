using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class Orders
    {
        int _orderId;
        int _customerId;
        DateTime _orderDate;
        decimal _subTotal;
        decimal _tax;
        bool _shipping;
        decimal _total;
        int _usersId;
        string _notes;
        int _orderPlaceId;
        string _statusOrder;

        private List<OrderDetails> _orderDetails;

        public int OrderId { get => _orderId; set => _orderId = value; }
        public int CustomerId { get => _customerId; set => _customerId = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public decimal SubTotal { get => _subTotal; set => _subTotal = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public bool Shipping { get => _shipping; set => _shipping = value; }
        public decimal Total { get => _total; set => _total = value; }
        public int UsersId { get => _usersId; set => _usersId = value; }
        public string Notes { get => _notes; set => _notes = value; }
        public int OrderPlaceId { get => _orderPlaceId; set => _orderPlaceId = value; }
        public List<OrderDetails> OrderDetails { get => _orderDetails; set => _orderDetails = value; }
        public string StatusOrder { get => _statusOrder; set => _statusOrder = value; }
    }
}
