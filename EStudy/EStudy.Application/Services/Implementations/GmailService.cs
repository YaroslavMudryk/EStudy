using EStudy.Application.Services.Interfaces;
using EStudy.Application.ViewModels.Emails;
using System.Threading.Tasks;

namespace EStudy.Application.Services.Implementations
{
    public class GmailService : IEmailService
    {
        public async Task<bool> SendEmailAsync(EmailViewModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}