using FitBite_DesktopApp.Domain;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace FitBite_DesktopApp.Infrastructure
{
    public class FitBiteDBContext : DbContext
    {
        //variables globales
       

        //conntructor de configuraciones
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string appPath = Path.Combine(dir, "Fitbite");

            Directory.CreateDirectory(appPath);

            string dbPath = Path.Combine(appPath, "fitbite.db");

            
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            
        
        }

        //ahora la configracion para que los decimal sean dobles
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>().HaveConversion<double>();
        }

            
        //TABLAS QUE LLEVARA LA BASE DE DATOS
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetallesVenta> DetallesVentas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<MovimientoInventario> MovimientosInventario { get; set; }
        public DbSet<Finanzas> Finanzas { get; set; }


        
    }
}
