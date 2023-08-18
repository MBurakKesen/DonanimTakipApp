using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Hardware
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWarranty { get; set; }

        public int WarrantyYear { get; set; }
    }
}
