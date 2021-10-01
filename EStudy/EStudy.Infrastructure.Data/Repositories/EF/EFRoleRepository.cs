using EStudy.Domain.Interfaces;
using EStudy.Domain.Models.Identity;
using EStudy.Infrastructure.Data.EntityFramework.Context;

namespace EStudy.Infrastructure.Data.Repositories.EF
{
    public class EFRoleRepository : EFRepository<Role, int>, IRoleRepository
    {
        public EFRoleRepository(EStudyContext db) : base(db) { }
    }
}