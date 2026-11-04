using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{

    public enum TiposMovimientoInventario
    {
        Entrada,
        Salida
    }

    public class MovimientoInventario
    {
        public int Id { get; set; }
        public TiposMovimientoInventario Tipo { get; set; } // entrada o salida
        public decimal Cantidad { get; set; }
        public string? Motivo { get; set; }
        public DateTime Fecha { get; set; } 

        public int ProductoId { get; set; }
        public Productos? Productos { get; set; }


    }
}
