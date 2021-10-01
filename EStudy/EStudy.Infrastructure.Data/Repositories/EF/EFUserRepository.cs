using EStudy.Domain.Interfaces;
using EStudy.Domain.Models.Identity;
using EStudy.Infrastructure.Data.EntityFramework.Context;

namespace EStudy.Infrastructure.Data.Repositories.EF
{
    public class EFUserRepository : EFRepository<User, int>, IUserRepository
    {
        public EFUserRepository(EStudyContext db) : base(db) { }
    }
}