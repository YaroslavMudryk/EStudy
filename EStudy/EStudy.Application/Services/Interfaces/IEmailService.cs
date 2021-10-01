using EStudy.Application.ViewModels.Emails;
using System.Threading.Tasks;

namespace EStudy.Application.Services.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(EmailViewModel model);
    }
}