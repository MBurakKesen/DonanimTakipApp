using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.abstraction
{
    public class RepositoryBase<TEntity,R> : IRepositoryDAL<TEntity> where TEntity:class,IEntity,new()
       where R:DbContext, new()
    {
        public void Add(TEntity t)
        {
            using (R r =new())
            {
                var added = r.Entry(t);
                added.State = EntityState.Added;
                r.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (R r = new())
            {
                var deleted = r.Entry(entity);
                deleted.State = EntityState.Deleted;
                r.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (R r = new R())
            {
                return r.Set<TEntity>().SingleOrDefault(filter);
                r.SaveChanges();

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (R r = new R())
            {
                return filter == null
                    ? r.Set<TEntity>().ToList()
                    : r.Set<TEntity>()
                    .Where(filter)
                    .ToList();
                r.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (R r = new R())
            {
                var updated = r.Entry(entity);
                updated.State = EntityState.Modified;
                r.SaveChanges();
            }
        }
    }
}
