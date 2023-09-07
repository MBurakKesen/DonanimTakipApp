using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class YaziciDto : IEntity
    {
        public int Id { get; set; }
        public string SicilNo { get; set; }
        public string Personel { get; set; }
        public string Amir { get; set; }
        public string Yazici { get; set; }
        public string SeriNumarasi { get; set; }
    }
}
