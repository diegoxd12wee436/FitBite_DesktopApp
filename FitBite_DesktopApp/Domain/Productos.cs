using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioVenta { get; set; } // el precio por el cual es vendido
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public bool Activo { get; set; } = true;

        //unidad de medida solo para productos que sean insumos 
        public string UnidadMedida { get; set; } 

        //las foreign
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }

    /// 
    
}
