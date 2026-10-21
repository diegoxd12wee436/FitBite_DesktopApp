using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public string? Tipo { get; set; } // entrada o salida
        public double Cantidad { get; set; }
        public string? Motivo { get; set; }
        public DateTime Fecha { get; set; } 

        public int ProductoId { get; set; }
        public Productos? Productos { get; set; }


    }
}
