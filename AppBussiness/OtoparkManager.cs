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
    public class OtoparkManager
    {
        OtoparkDAL _otoparkDAL;
        public OtoparkManager(OtoparkDAL otoparkDAL)
        {
            _otoparkDAL = otoparkDAL;
        }

        public void Add(Otopark otopark)
        {
            _otoparkDAL.Add(otopark);
        }
        public void Delete(Otopark otopark)
        {
            _otoparkDAL.Delete(otopark);

        }
        public void Update(Otopark otopark)
        {
            _otoparkDAL.Update(otopark);
        }
        public Otopark Get(Expression<Func<Otopark, bool>> filter)
        {
            return _otoparkDAL.Get(filter);
        }
        public List<Otopark> GetAll(Expression<Func<Otopark, bool>> filter = null)
        {
            return _otoparkDAL.GetAll(filter);
        }
    }
}
