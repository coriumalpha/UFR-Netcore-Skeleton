using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SJew.Data.Models;


namespace SJew.Data
{
    public class SJewContextFactory : IDesignTimeDbContextFactory<SJewContext>
    {
        public SJewContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SJewContext>();
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SJewDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            return new SJewContext(optionsBuilder.Options);
        }
    }
}
