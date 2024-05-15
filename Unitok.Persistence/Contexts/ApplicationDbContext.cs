using Unitok_progect.Domain.Common;
using Unitok_progect.Domain.Common.Interfaces;

using Microsoft.EntityFrameworkCore;

using System.Reflection;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Configuration;

namespace Unitok_progect.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        //private readonly IDomainEventDispatcher _dispatcher;

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NftCard> NftCards { get; set; }
        public DbSet<StaticFile> StaticFiles { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuctionConfiguration());
            modelBuilder.ApplyConfiguration(new BidConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new NftCardConfiguration());
            modelBuilder.ApplyConfiguration(new StaticFileConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
            modelBuilder.ApplyConfiguration(new WalletConfiguration());

            modelBuilder.Entity<Category>().HasData(DatabaseSeeder.Categories());

            base.OnModelCreating(modelBuilder);
/*            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());*/
        }

/*        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }*/
    }
}
