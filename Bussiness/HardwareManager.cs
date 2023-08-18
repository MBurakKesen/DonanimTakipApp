using DataAccess;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class HardwareManager
    {
        HardwareDAL _hardwareDAL;
        public HardwareManager(HardwareDAL hardwareDAL)
        {
            this._hardwareDAL = hardwareDAL;
        }

        public List<Hardware> GetAll()
        {
            return _hardwareDAL.GetAll();
        }

        public Hardware GetById(int HardwareId)
        {
            return _hardwareDAL.Get(x =>x.Id==HardwareId);
        }

        public void Add(Hardware hardware)
        {
            _hardwareDAL.Add(hardware);
        }
        public void Delete(Hardware hardware)
        {
            _hardwareDAL.Delete(hardware);
        }

        public void Update(Hardware hardware)
        {
            _hardwareDAL.Update(hardware);
        }

    }
}
