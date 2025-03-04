using Microsoft.EntityFrameworkCore;
using JudoMaster.Models;

namespace JudoMaster.Data
{
    public class JudoContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Institution> Institutions { get; set; }

        public JudoContext(DbContextOptions<JudoContext> options) : base(options) { }
    }
}