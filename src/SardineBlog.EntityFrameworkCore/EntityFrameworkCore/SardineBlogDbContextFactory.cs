using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SardineBlog.Configuration;
using SardineBlog.Web;

namespace SardineBlog.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SardineBlogDbContextFactory : IDesignTimeDbContextFactory<SardineBlogDbContext>
    {
        public SardineBlogDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SardineBlogDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SardineBlogDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SardineBlogConsts.ConnectionStringName));

            return new SardineBlogDbContext(builder.Options);
        }
    }
}
