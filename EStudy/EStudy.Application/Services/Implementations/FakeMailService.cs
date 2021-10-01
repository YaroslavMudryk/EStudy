using EStudy.Application.Services.Interfaces;
using EStudy.Application.ViewModels.Emails;
using System.Threading.Tasks;

namespace EStudy.Application.Services.Implementations
{
    public class FakeMailService : IEmailService
    {
        public async Task<bool> SendEmailAsync(EmailViewModel model)
        {
            await Task.Delay(500);
            return await Task.FromResult(true);
        }
    }
}