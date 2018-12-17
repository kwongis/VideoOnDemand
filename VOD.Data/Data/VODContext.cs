using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VOD.Data.Data.Entities;

namespace VOD.Data.Data
{
    public class VODContext : IdentityDbContext<User>
    {
        public VODContext(DbContextOptions<VODContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
