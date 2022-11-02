using DAL.Domain;
using System.Data.Entity;

namespace DataAccess
{
    public class ReScraperContext : DbContext
    {
        public ReScraperContext() : base("Scraper")
        {
        }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<Locality> Localities { get; set; }
    }
}
