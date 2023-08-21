using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YaziciDAL
    {
        public void Add(Yazici yazici)
        {
            using (DonanımTakipContext context = new())
            {
                var added = context.Entry(yazici);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Yazici yazici)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(yazici);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public Yazici Get(Expression<Func<Yazici, bool>> filter)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<Yazici>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }
        public List<Yazici> GetAll(Expression<Func<Yazici, bool>> filter = null)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null ? context.Set<Yazici>().ToList() : context.Set<Yazici>().Where(filter).ToList();
                context.SaveChanges();
            }
        }
        public void Update(Yazici yazici)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var updated = context.Entry(yazici);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
