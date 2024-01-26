
using Microsoft.EntityFrameworkCore;

namespace LoginApi.Entity
{
    public class RoseShopDbcontext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public RoseShopDbcontext(DbContextOptions<RoseShopDbcontext> options) : base(options)
        { }
    }
}
