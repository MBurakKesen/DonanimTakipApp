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
    public class YaziciVeSeriNumaralariDAL
    {
        public void Add(YaziciVeSeriNumaralari yaziciVeSeriNumaralari)
        {
            using (DonanımTakipContext context = new())
            {
                var added = context.Entry(yaziciVeSeriNumaralari);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(YaziciVeSeriNumaralari yaziciVeSeriNumaralari)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(yaziciVeSeriNumaralari);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public YaziciVeSeriNumaralari Get(Expression<Func<YaziciVeSeriNumaralari, bool>> filter)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<YaziciVeSeriNumaralari>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }
        public List<YaziciVeSeriNumaralari> GetAll(Expression<Func<YaziciVeSeriNumaralari, bool>> filter = null)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null ? context.Set<YaziciVeSeriNumaralari>().ToList() : context.Set<YaziciVeSeriNumaralari>().Where(filter).ToList();
                context.SaveChanges();
            }
        }
        public void Update(YaziciVeSeriNumaralari yaziciVeSeriNumaralari)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var updated = context.Entry(yaziciVeSeriNumaralari);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
