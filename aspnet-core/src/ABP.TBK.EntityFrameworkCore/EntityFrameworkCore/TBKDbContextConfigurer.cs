using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP.TBK.EntityFrameworkCore
{
    public static class TBKDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TBKDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TBKDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
