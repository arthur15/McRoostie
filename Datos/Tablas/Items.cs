using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class Items
    {
        private int _itemId;
        private string _itemCode;
        private string _descriptions;
        private string _field1;
        private string _field2;
        private string _field3;
        private decimal _price;

        public int ItemId { get => _itemId; set => _itemId = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string Descriptions { get => _descriptions; set => _descriptions = value; }
        public string Field1 { get => _field1; set => _field1 = value; }
        public string Field2 { get => _field2; set => _field2 = value; }
        public string Field3 { get => _field3; set => _field3 = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}
