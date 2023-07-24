using Domain.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace DrivenAdapter.Sql.Context
{
    public class PlatformContext : DbContext
    {
        public DbSet<Platform> Platfoms { get; set; }

        public PlatformContext(DbContextOptions options) : base(options)
        {
        }
    }
}