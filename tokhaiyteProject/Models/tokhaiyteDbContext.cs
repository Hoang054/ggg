using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tokhaiyteProject.Models.Entities;

namespace tokhaiyteProject.Models
{
    public class tokhaiyteDbContext : DbContext
    {
        public tokhaiyteDbContext(DbContextOptions<tokhaiyteDbContext> options ) : base(options)
        {

        }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<tokhaimodel> tokhaimodels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<Province>();
            //modelBuilder.Ignore<District>();
            //modelBuilder.Ignore<Ward>();
            //modelBuilder.Ignore<Gate>();
            //modelBuilder.Ignore<Month>();
            //modelBuilder.Ignore<Year>();
            //modelBuilder.Ignore<Date>();
        }
    }
}
