using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using var context = new AgricultureContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new AgricultureContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new AgricultureContext();
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            using var context = new AgricultureContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
