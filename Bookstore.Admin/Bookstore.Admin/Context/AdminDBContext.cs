using Bookstore.Admin.Entity;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Admin.Context
{
    public class AdminDBContext: DbContext
    {
        public AdminDBContext(DbContextOptions<AdminDBContext>dbContextOptions):base(dbContextOptions) { } 

        public DbSet<AdminEntity> Admin { get; set; }

    }
}
