using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public class DetallesVenta
    {
        public int Id { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        //la relacion de quien es osea a que venta pertece

        public int VentaId { get; set; }
        public Venta? venta { get; set; }

        public int ProductoId { get; set; }
        public Productos? Productos { get; set; }
    }
}
