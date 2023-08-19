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
    public class HyteraPersonManager
    {
        HyteraPersonDAL _hyteraPersonDal;
        public HyteraPersonManager(HyteraPersonDAL hyteraPersonDal)
        {
            _hyteraPersonDal = hyteraPersonDal;
        }

        public void Add(HyteraPerson hyteraPerson)
        {
            _hyteraPersonDal.Add(hyteraPerson);
        }
        public void Delete(HyteraPerson hyteraPerson)
        {
            _hyteraPersonDal.Delete(hyteraPerson);
        }
        public HyteraPerson Get(Expression<Func<HyteraPerson, bool>> filter)
        {
            return _hyteraPersonDal.Get(filter);
        }
        public List<HyteraPerson> GetAll(Expression<Func<HyteraPerson, bool>> filter=null) {
            return _hyteraPersonDal.GetAll(filter);
        }
    }
}
