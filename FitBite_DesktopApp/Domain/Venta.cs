using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public class Venta
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public bool Anulada { get; set; }

        public List<DetallesVenta> detalleVenta { get; set; } = new List<DetallesVenta>();

    }
}
