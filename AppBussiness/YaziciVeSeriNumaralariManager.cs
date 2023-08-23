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
    public class YaziciVeSeriNumaralariManager
    {
        YaziciVeSeriNumaralariDAL _yaziciVeSeriNumaralariDAL;
        public YaziciVeSeriNumaralariManager(YaziciVeSeriNumaralariDAL yaziciVeSeriNumaralariDAL)
        {
            _yaziciVeSeriNumaralariDAL = yaziciVeSeriNumaralariDAL;
        }
        public void Add(YaziciVeSeriNumaralari yaziciVeSeriNumaralari)
        {
            _yaziciVeSeriNumaralariDAL.Add(yaziciVeSeriNumaralari);
        }
        public void Delete(YaziciVeSeriNumaralari yaziciVeSeriNumaralari)
        {
            _yaziciVeSeriNumaralariDAL.Delete(yaziciVeSeriNumaralari);
        }
        public YaziciVeSeriNumaralari Get(Expression<Func<YaziciVeSeriNumaralari, bool>> filter)
        {
            return _yaziciVeSeriNumaralariDAL.Get(filter);
        }
        public List<YaziciVeSeriNumaralari> GetAll(Expression<Func<YaziciVeSeriNumaralari, bool>> filter = null)
        {
            return _yaziciVeSeriNumaralariDAL.GetAll(filter);
        }
    }
}
