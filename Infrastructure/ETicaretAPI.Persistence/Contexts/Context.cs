using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

           var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var entity in datas)
            {

                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => entity.Entity.UpdateDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                } ;

              
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
