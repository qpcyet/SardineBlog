using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SardineBlog.Authorization.Roles;
using SardineBlog.Authorization.Users;
using SardineBlog.MultiTenancy;

namespace SardineBlog.EntityFrameworkCore
{
    public class SardineBlogDbContext : AbpZeroDbContext<Tenant, Role, User, SardineBlogDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SardineBlogDbContext(DbContextOptions<SardineBlogDbContext> options)
            : base(options)
        {
        }
    }
}
