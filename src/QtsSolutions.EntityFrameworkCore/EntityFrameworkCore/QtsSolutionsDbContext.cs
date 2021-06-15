using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QtsSolutions.Authorization.Roles;
using QtsSolutions.Authorization.Users;
using QtsSolutions.MultiTenancy;

namespace QtsSolutions.EntityFrameworkCore
{
    public class QtsSolutionsDbContext : AbpZeroDbContext<Tenant, Role, User, QtsSolutionsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QtsSolutionsDbContext(DbContextOptions<QtsSolutionsDbContext> options)
            : base(options)
        {
        }
    }
}
