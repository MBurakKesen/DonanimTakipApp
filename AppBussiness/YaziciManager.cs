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
    public class YaziciManager
    {
        YaziciDAL _yazici;
        public YaziciManager(YaziciDAL yazici)
        {
            _yazici = yazici;
        }
        public void Add(Yazici hyteraPerson)
        {
            _yazici.Add(hyteraPerson);
        }
        public void Delete(Yazici hyteraPerson)
        {
            _yazici.Delete(hyteraPerson);
        }
        public Yazici Get(Expression<Func<Yazici, bool>> filter)
        {
            return _yazici.Get(filter);
        }
        public List<Yazici> GetAll(Expression<Func<Yazici, bool>> filter = null)
        {
            return _yazici.GetAll(filter);
        }
    }

}
