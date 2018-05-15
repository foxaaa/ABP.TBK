using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP.TBK.Authorization.Roles;
using ABP.TBK.Authorization.Users;
using ABP.TBK.MultiTenancy;
using ABP.TBK.TaoBaoKe.Products;

namespace ABP.TBK.EntityFrameworkCore
{
    public class TBKDbContext : AbpZeroDbContext<Tenant, Role, User, TBKDbContext>
    {
        /* Define a DbSet for each entity of the application */
         

        public TBKDbContext(DbContextOptions<TBKDbContext> options)
            : base(options)
        {
        } 

        public DbSet<Product> Product { get; set; }

       protected override void OnModelCreating(ModelBuilder builder) {
           // builder.Entity<Product>().ToTable("Product");
            base.OnModelCreating(builder);

        }
        
    }
}
