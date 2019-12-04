using Microsoft.EntityFrameworkCore;

namespace ProductApplication.Data
{
    public class ItemContext: DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options): base(options){}
        public DbSet<Models.Items> Items { get; set; }
    }
}