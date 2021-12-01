using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinaData.Models;

namespace FinaData.Data;

    public class ProductionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(
                "Data Source = localhost; Initial Catalog = Production; Integrated Security = True;");
            base.OnConfiguring(optionsBuilder);
        }

 

        public DbSet<ProductModel> Production { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<CountryModel> Countries { get; set; }

    }
