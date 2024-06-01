using Microsoft.EntityFrameworkCore;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Unitok.Persistence.Configuration;

namespace Unitok_progect.Persistence.Contexts
{
    public class ApplicationDbContext :  IdentityDbContext<UserMain, IdentityRole<int>, int>//DbContext
	{
		public DbSet<UserMain> Users { get; set; }
		public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NftCard> NftCards { get; set; }
		// public DbSet<StaticFile> StaticFiles { get; set; }
		public DbSet<Wallet> Wallets { get; set; }
		public DbSet<UserInfo> UserInfos { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
			//Database.EnsureDeleted();
			//Database.EnsureCreated();
		}

        public ApplicationDbContext() { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) => 
            optionBuilder.UseSqlServer("Server=LAPTOP-0HOF7UH6;Database=Unitok;Trusted_Connection=True;Encrypt=false");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

			foreach (var entity in modelBuilder.Model.GetEntityTypes())
				foreach (var key in entity.GetForeignKeys())
				{
                    Console.WriteLine(key);
				}


			/*            modelBuilder.ApplyConfiguration(new AuctionConfiguration());
						modelBuilder.ApplyConfiguration(new BidConfiguration());
						modelBuilder.ApplyConfiguration(new CategoryConfiguration());*/
			modelBuilder.ApplyConfiguration(new NftCardConfiguration());
            //modelBuilder.ApplyConfiguration(new StaticFileConfiguration());
            modelBuilder.ApplyConfiguration(new UserInfoConfiguration());
            //modelBuilder.ApplyConfiguration(new WalletConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

			var passwordHasher = new PasswordHasher<UserMain>();

            modelBuilder.Entity<Category>().HasData(DatabaseSeeder.Categories());  
			modelBuilder.Entity<Wallet>().HasData(DatabaseSeeder.Wallets());

            modelBuilder.Entity<NftCard>().HasData(DatabaseSeeder.NftCards());
            modelBuilder.Entity<UserMain>().HasData(DatabaseSeeder.Users(passwordHasher));
            modelBuilder.Entity<UserInfo>().HasData(DatabaseSeeder.UserInfos());


        }
    }
}
