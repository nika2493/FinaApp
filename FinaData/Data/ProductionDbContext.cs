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
        public ProductionDbContext(DbContextOptions<ProductionDbContext> options) : base(options) { }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
    }
