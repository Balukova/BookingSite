using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private BookingDbContext context;
        private DbSet<TEntity> dbSet;
        public Repository(BookingDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            TEntity entityToDelete = dbSet.Find(id);
           // if (context.Entry(entityToDelete).State == EntityState.Detached)
           // {
           //     dbSet.Attach(entityToDelete);
           // }
            dbSet.Remove(entityToDelete);
            context.SaveChanges();
        }

        public IList<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            TEntity existed = dbSet.Find(entity.Id);
            //if (existed == null)
            //{
            //    dbSet.Attach(entity);
            //    context.Entry(entity).State = EntityState.Modified;
            //} else
           // {
              //  dbSet.Attach(existed);
                context.Entry(existed).State = EntityState.Modified;
           // }
            context.SaveChanges();
            
        }
    }
}
