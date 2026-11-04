using FitBite_DesktopApp.Domain;
using FitBite_DesktopApp.Infrastructure;
using System.Web;

namespace FitBite_DesktopApp.Application.Services
{
    public class ProductoService
    {
        /*
         Crud de productos, para poder agregar, eliminar, modificar y listar productos en la base de datos
        */


        // 1. Agregar un producto a la base de datos
        public void AgregarProducto(Productos product)
        {
            //validacion de que el producto no sea nulo
            if (product == null || string.IsNullOrEmpty(product.Nombre))
            {
                throw new ArgumentNullException("El producto no puede ser nulo (tiene que agregar un producto)");
            }

            using( var db = new FitBiteDBContext())
            {
                db.Productos.Add(product);
                db.SaveChanges();
            }
        }





        //2. Mostrar todos los productos que esten activos en la base de datos (READ)

       public List<Productos> GetProductosActivos()
        {
            using (var db  = new FitBiteDBContext())
            {
                return db.Productos.Where(p => p.Activo).ToList(); 
                //RETORNA DE UNA TODOS LOS PRODUCTOS EN UN LIST  activos
            }
            
        }
        //3. Buscar un producto por su id en la base de datos (READ)

        public Productos? GetProductosId(int id)
        {
            using (var db = new FitBiteDBContext())
            {
                return db.Productos?.Find(id);

            }
        }

        //Eliminar un producto de la base de datos (DELETE)
        public void DesactivarProducto(int id)
        {
            using (var db = new FitBiteDBContext())
            {
                var producto = db.Productos.Find(id);
                if(producto !=null)
                {
                    producto.Activo = false; //marcar como inactivo en lugar de eliminar buena practica
                    db.SaveChanges();
                }
            }
        }

        public void ModificarProducto(Productos product)
        {
            using( var db = new FitBiteDBContext())
            {
                var productExistente = db.Productos.Find(product.Id);
                if (productExistente != null)
                {
                    productExistente.Nombre = product.Nombre;
                    productExistente.CostoUnitario = product.CostoUnitario;
                    productExistente.PrecioVenta = product.PrecioVenta;
                    productExistente.StockActual = product.StockActual;
                    productExistente.StockMinimo = product.StockMinimo;
                    productExistente.Activo = product.Activo;
                    productExistente.UnidadMedida = product.UnidadMedida;
                    productExistente.CategoriaId = product.CategoriaId;
                                    

                    db.SaveChanges();
                }
                
            }
        }


       



        //4. Modificar un producto en la base de datos (UPDATE)



        // 5. Eliminar un producto de la base de datos (DELETE)








    }
}
