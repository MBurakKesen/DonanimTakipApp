using DataAccess;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppBussiness
{
    public class OnarimManager
    {
        OnarimDAL _onarimDal;
        public OnarimManager(OnarimDAL onarimDal)
        {
            _onarimDal = onarimDal;
        }
        public void Add(Onarim onarim)
        {
            _onarimDal.Add(onarim);
        }
        public void Delete(Onarim onarim)
        {
            _onarimDal.Delete(onarim);
        }
        public void Update(Onarim onarim)
        {
            _onarimDal.Update(onarim);
        }
        public Onarim Get(Expression<Func<Onarim, bool>> filter)
        {
            return _onarimDal.Get(filter);
        }
        public List<Onarim> GetAll(Expression<Func<Onarim, bool>> filter=null)
        {
            return _onarimDal.GetAll(filter);
        }
    }
}
