using Console.Core;
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
            string path=ConnectionString.Connection();
            optionsBuilder.UseSqlServer(path ?? @"Server=LAPTOP-RE5ASPI1\SQLEXPRESS;Database=DonanimTakipApp;TrustServerCertificate=True;Trusted_Connection=True");
        }

        public DbSet<HyteraPerson> HyteraPersons { get; set;}
        public DbSet<Yazici> Yazicies
        { get; set;}
        public DbSet<YaziciVeSeriNumaralari> YaziciVeSeriNumaralaris { get; set;}
        public DbSet<Onarim> Onarims { get; set;}
        public DbSet<Otopark> Otoparks { get; set;}
       
    }
}
