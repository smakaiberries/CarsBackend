using CarsBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsBackend.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public ActionResult<IEnumerable<Make>> Include { get; internal set; }
        public DbSet<Features> Features { get; set; }
    }
}
