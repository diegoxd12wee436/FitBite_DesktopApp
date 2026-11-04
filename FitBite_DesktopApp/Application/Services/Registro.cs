using FitBite_DesktopApp.Domain;
using FitBite_DesktopApp.Infrastructure;

namespace FitBite_DesktopApp.Application.Services
{
    public class Registro<T> where T : class
    {


        public void Agregar(T entity)
        {
            using (var db = new FitBiteDBContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }


        public void Modificar(T entity)
        {
            using (var db = new FitBiteDBContext())
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
            }
        }
       public List<T> ListarTodos()
        {
            using (var db = new FitBiteDBContext())
            {
                return db.Set<T>().ToList();
            }
        }
        public T? ListarPorId(int id)
        {
            using (var db = new FitBiteDBContext())
            {
                return db.Set<T>().Find(id);
            }
        }







    }
}
