using Microsoft.EntityFrameworkCore;
using JudoMaster.Models;

namespace JudoMaster.Data
{
    public class JudoContext : DbContext
    {
        public DbSet<Athlete> Atletas { get; set; }
        public DbSet<Institution> Instituciones { get; set; }

        public JudoContext(DbContextOptions<JudoContext> options) : base(options) { }
    }
}