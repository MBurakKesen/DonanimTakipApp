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
    public class HardwareDAL
    {
        public void Add(Hardware entity)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Hardware entity)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Hardware Get(Expression<Func<Hardware, bool>> filter)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<Hardware>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }

        public List<Hardware> GetAll(Expression<Func<Hardware, bool>> filter = null)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null ? context.Set<Hardware>().ToList() : context.Set<Hardware>().Where(filter).ToList();
                context.SaveChanges();
            }
        }



        public void Update(Hardware entity)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
