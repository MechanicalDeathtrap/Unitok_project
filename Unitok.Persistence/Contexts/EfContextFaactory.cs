using Unitok_progect.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Unitok_progect.Persistence.Contexts
{
    internal class EfContextFaactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder().Build();
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer("Server=LAPTOP-0HOF7UH6;Database=Unitok;Trusted_Connection=True;Encrypt=false");

            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}
