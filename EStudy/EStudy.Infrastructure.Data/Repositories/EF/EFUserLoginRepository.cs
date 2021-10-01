using EStudy.Domain.Interfaces;
using EStudy.Domain.Models.Identity;
using EStudy.Infrastructure.Data.EntityFramework.Context;

namespace EStudy.Infrastructure.Data.Repositories.EF
{
    public class EFUserLoginRepository : EFRepository<UserLogin, int>, IUserLoginRepository
    {
        public EFUserLoginRepository(EStudyContext db) : base(db) { }
    }
}