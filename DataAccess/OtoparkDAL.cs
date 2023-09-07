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
    public class OtoparkDAL
    {
        public void Add(Otopark otopark)
        {
            using (DonanımTakipContext context =new())
            {
                var added = context.Entry(otopark);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Otopark otopark)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(otopark);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public void Update(Otopark otopark)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var updated = context.Entry(otopark);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Otopark Get(Expression<Func<Otopark, bool>> filter)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<Otopark>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }

        public List<Otopark> GetAll(Expression<Func<Otopark, bool>> filter = null)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null
                    ? context.Set<Otopark>().ToList()
                    : context.Set<Otopark>()
                    .Where(filter)
                    .ToList();
                context.SaveChanges();
            }
        }
    }
}
