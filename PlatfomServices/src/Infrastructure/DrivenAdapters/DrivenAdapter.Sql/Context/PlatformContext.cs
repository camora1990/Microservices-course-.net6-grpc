using Domain.Model.Models;
using DrivenAdapter.Sql.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DrivenAdapter.Sql.Context
{
    public class PlatformContext : DbContext
    {
        public DbSet<Platform> Platfoms { get; set; }

        public PlatformContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlatformConfigure());
        }
    }
}