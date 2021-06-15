using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QtsSolutions.Configuration;
using QtsSolutions.Web;

namespace QtsSolutions.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QtsSolutionsDbContextFactory : IDesignTimeDbContextFactory<QtsSolutionsDbContext>
    {
        public QtsSolutionsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QtsSolutionsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            QtsSolutionsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(QtsSolutionsConsts.ConnectionStringName));

            return new QtsSolutionsDbContext(builder.Options);
        }
    }
}
