using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SardineBlog.EntityFrameworkCore
{
    public static class SardineBlogDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SardineBlogDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SardineBlogDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
