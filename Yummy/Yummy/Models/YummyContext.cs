using Microsoft.EntityFrameworkCore;

namespace Yummy.Models
{
    public class YummyContext:DbContext
    {
        public YummyContext(DbContextOptions<YummyContext> options):base(options)
        {

        }

        public DbSet<Cheef> cheefs { get; set; }
            
    }
}
