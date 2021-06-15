using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QtsSolutions.EntityFrameworkCore
{
    public static class QtsSolutionsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QtsSolutionsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QtsSolutionsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
