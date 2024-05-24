
using AgencyExam.Models;
using Microsoft.EntityFrameworkCore;

namespace AgencyExam.DAL
{
    public class AgencyContext : DbContext
    {
        public AgencyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Portfolio> Portfolios { get; set; }

    }
}
