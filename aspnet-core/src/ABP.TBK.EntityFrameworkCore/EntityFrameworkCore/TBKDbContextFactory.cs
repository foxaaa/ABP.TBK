using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABP.TBK.Configuration;
using ABP.TBK.Web;

namespace ABP.TBK.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TBKDbContextFactory : IDesignTimeDbContextFactory<TBKDbContext>
    {
        public TBKDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TBKDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TBKDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TBKConsts.ConnectionStringName));

            return new TBKDbContext(builder.Options);
        }
    }
}
