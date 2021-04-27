using Datos.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Tablas
{
    public class Promocion
    {
        CD_Orders orders = new CD_Orders();
        int _promocionId;
        string _promotionName;
        string _dayActive;
        decimal _costPromo;
        bool _isActive;

        public int PromocionId { get => _promocionId; set => _promocionId = value; }
        public string PromotionName { get => _promotionName; set => _promotionName = value; }
        public string DayActive { get => _dayActive; set => _dayActive = value; }
        public decimal CostPromo { get => _costPromo; set => _costPromo = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        private List<PromocionDetail> _promocionDetails;

        public List<PromocionDetail> PromocionDetails
        {
            get
            {
                if (_promocionDetails == null)
                {
                    _promocionDetails = orders.GetPromocionDetailbyPromoId(PromocionId); //Data.Clases.Clpedido.ClGetPedido_lByIdOrderId(Convert.ToInt32(OrderId));
                }

                return _promocionDetails;
            }
            set
            {
                _promocionDetails = value;
            }
        }
    }
}
