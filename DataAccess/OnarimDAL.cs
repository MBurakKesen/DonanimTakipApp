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
    public class OnarimDAL
    {
        public void Add(Onarim onarim) {
            using (DonanımTakipContext context = new())
            {
                var added = context.Entry(onarim);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Onarim onarim) {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(onarim);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Onarim onarim) { }
        public List<Onarim> GetAll(Expression<Func<Onarim, bool>> filter=null) {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null ? context.Set<Onarim>().ToList() : context.Set<Onarim>().Where(filter).ToList();
                context.SaveChanges();
            }
        }
        public Onarim Get(Expression<Func<Onarim, bool>> filter) {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<Onarim>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }
    }
}
