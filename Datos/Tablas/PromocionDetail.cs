using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class PromocionDetail
    {
        int _promocionDetailId;
        int _promocionId;
        string _skuProduct;
        int _qtyProduct;
        bool _isActive;
        string _descriptions;

        public int PromocionDetailId { get => _promocionDetailId; set => _promocionDetailId = value; }
        public int PromocionId { get => _promocionId; set => _promocionId = value; }
        public string SkuProduct { get => _skuProduct; set => _skuProduct = value; }
        public int QtyProduct { get => _qtyProduct; set => _qtyProduct = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
        public string Descriptions { get => _descriptions; set => _descriptions = value; }
    }
}
