using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DonanımTakipContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-RE5ASPI1\SQLEXPRESS;Database=DonanimTakipApp;TrustServerCertificate=True;Trusted_Connection=True");
        }

        DbSet<HyteraPerson> HyteraPersons { get; set;}
        DbSet<Yazici> Yazicies
        { get; set;}
       
    }
}
