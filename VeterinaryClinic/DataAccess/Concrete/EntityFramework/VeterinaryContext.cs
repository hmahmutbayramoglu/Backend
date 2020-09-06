using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class VeterinaryContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN7-BILGISAYAR\SQLEXPRESS;Database=Veterinary;Trusted_Connection=true");
        }

        //Hayvanlar Yazımı veri tabanındaki isimle aynı olmalı
        public DbSet<Hayvan> Hayvanlar { get; set; }
    }
}
