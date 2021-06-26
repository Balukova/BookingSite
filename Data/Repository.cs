using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Data
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IBaseEntity
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

        public void DeleteById(TKey id)
        {
            TEntity entityToDelete = dbSet.Find(id);

            dbSet.Remove(entityToDelete);
            context.SaveChanges();
        }

        public IList<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public TEntity GetById(TKey id)
        {
            return dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            TEntity existed = dbSet.Find(entity.Id);

            context.Entry(existed).CurrentValues.SetValues(entity);
            context.Entry(existed).State = EntityState.Modified;

            context.SaveChanges();
            
        }
    }
}
