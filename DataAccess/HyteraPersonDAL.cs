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
    public class HyteraPersonDAL
    {
        public void Add(HyteraPerson hPerson)
        {
            using (DonanımTakipContext context = new())
            {
                var added = context.Entry(hPerson);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(HyteraPerson hPerson)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var deleted = context.Entry(hPerson);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public HyteraPerson Get(Expression<Func<HyteraPerson, bool>> filter)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return context.Set<HyteraPerson>().SingleOrDefault(filter);
                context.SaveChanges();

            }
        }
        public List<HyteraPerson> GetAll(Expression<Func<HyteraPerson, bool>> filter = null)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                return filter == null ? context.Set<HyteraPerson>().ToList() : context.Set<HyteraPerson>().Where(filter).ToList();
                context.SaveChanges();
            }
        }
        public void Update(HyteraPerson hPerson)
        {
            using (DonanımTakipContext context = new DonanımTakipContext())
            {
                var updated = context.Entry(hPerson);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
