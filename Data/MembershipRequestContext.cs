using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MembershipRequestContext : DbContext
    {
        public MembershipRequestContext(DbContextOptions<MembershipRequestContext> options)
            : base(options)
        {
        }

        public DbSet<MembershipRequest> MembershipRequest { get; set; }
    }
}