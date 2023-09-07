using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Otopark : IEntity
    {
        public int Id { get; set; }
        public string SicilNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Servis { get; set; }
        public string BirimAdi { get; set; }
    }
}
