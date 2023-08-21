using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Yazici
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime TeslimTarih { get; set; }
        public string SeriNumarasi { get; set; }
    }
}
