using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using (Context context=new Context())
            {
                var deletedEntity=context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T GetByID(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetList()
        {
            using (Context context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
