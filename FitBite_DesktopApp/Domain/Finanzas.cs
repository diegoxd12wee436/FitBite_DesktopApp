using System;
using System.Collections.Generic;
using System.Text;

namespace FitBite_DesktopApp.Domain
{
    public class Finanzas
    {
        public int Id { get; set; }
        public string? Tipo { get; set; } //solo hay 2 o es gasto o es ingreso extra por alguna razon
        public decimal Monto { get; set; }
        public string? Descripcion { get; set; }
        public string? Categoria_Gasto { get; set; } = string.Empty; //solo si es gasto si no null

    }
}
