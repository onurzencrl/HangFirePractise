using Microsoft.EntityFrameworkCore;

namespace HangFirePractise.Context
{
    public sealed class HangFireDbContext : DbContext
    {

        public HangFireDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
