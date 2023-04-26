using Microsoft.EntityFrameworkCore;
using MySQLtest.Model;

namespace MySQLtest.DBContext
{
    public class LanguageContext : DbContext
    {
        public LanguageContext()
        {
        }

        public LanguageContext(DbContextOptions<LanguageContext> options) : base(options)
        {
        }

        public DbSet<Language> Languages { get; set; }
    }
}
