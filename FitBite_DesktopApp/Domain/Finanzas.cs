using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public enum TipoMovimiento
    {
        Gasto,
        Ingreso
    }

    public enum CategoriaGasto
    {        
        Alquiler,
        Servicios,
        SalarioTrabajadores,
        Mantenimiento,
        Insumos,
        Otros



    }



    public class Finanzas
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public TipoMovimiento Tipo { get; set; } //solo hay 2 o es gasto o es ingreso extra por alguna razon
        public decimal Monto { get; set; }
        public string? Descripcion { get; set; }
        public string? Categoria_Gasto { get; set; } = string.Empty; //solo si es gasto si no null

    }
}
