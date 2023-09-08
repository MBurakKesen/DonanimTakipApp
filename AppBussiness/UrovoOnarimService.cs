using DataAccess;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class UrovoOnarimService
    {
        UrovoOnarimDAL _urovoOnarimDAL;
        public UrovoOnarimService(UrovoOnarimDAL urovoOnarimDAL)
        {
            _urovoOnarimDAL = urovoOnarimDAL;
        }
        public void Add(UrovoOnarim onarim)
        {
            _urovoOnarimDAL.Add(onarim);
        }
        public void Delete(UrovoOnarim onarim)
        {
            _urovoOnarimDAL.Delete(onarim);
        }
        public void Update(UrovoOnarim onarim)
        {
            _urovoOnarimDAL.Update(onarim);
        }
        public UrovoOnarim Get(Expression<Func<UrovoOnarim, bool>> expression)
        {
            return _urovoOnarimDAL.Get(expression);
        }
        public List<UrovoOnarim> GetAll(Expression<Func<UrovoOnarim, bool>> expression = null)
        {
            return _urovoOnarimDAL.GetAll(expression);
        }
    }
}
