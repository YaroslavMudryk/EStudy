using EStudy.Domain.Interfaces;
using EStudy.Domain.Models.Identity;
using EStudy.Infrastructure.Data.EntityFramework.Context;

namespace EStudy.Infrastructure.Data.Repositories.EF
{
    public class EFUserRoleRepository : EFRepository<UserRole, int>, IUserRoleRepository
    {
        public EFUserRoleRepository(EStudyContext db) : base(db) { }
    }
}