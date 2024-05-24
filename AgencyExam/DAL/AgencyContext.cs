
using AgencyExam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgencyExam.DAL
{
    public class AgencyContext :IdentityDbContext<AppUser>
    {
        public AgencyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Portfolio> Portfolios { get; set; }

    }
}
