using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class OrderPlace
    {
        private int _orderPlaceId;
        private string _description;

        public int OrderPlaceId { get => _orderPlaceId; set => _orderPlaceId = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
