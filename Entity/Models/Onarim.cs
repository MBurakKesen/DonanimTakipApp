﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Onarim : IEntity
    {
        public int Id { get; set; }
        public string SeriNo { get; set; }
        public int SENo { get; set; }
        public int FormNo { get; set; }
        public string Ariza { get; set; }
        public string YapilanIslem { get; set; }
        public DateTime GonderilisTarihi { get; set; }
        public int KargoTakipNo { get; set; }
        public DateTime GelisTarihi { get; set; }
        public DateTime GarantiBitisTarihi { get; set; }
        public int KalanSureAy { get; set; }
        public int KalanSureGun { get; set; }
    }
}
