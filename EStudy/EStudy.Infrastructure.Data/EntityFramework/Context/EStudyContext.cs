using EStudy.Domain.Models.Identity;
using Microsoft.EntityFrameworkCore;
namespace EStudy.Infrastructure.Data.EntityFramework.Context
{
    public class EStudyContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public EStudyContext(DbContextOptions<EStudyContext> contextOptions) : base(contextOptions) { }
    }
}