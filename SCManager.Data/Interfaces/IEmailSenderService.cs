using SendGrid;
using System.Threading.Tasks;

namespace SCManager.Data
{
    public interface IEmailSenderService
    {
        Task<Response> SendEmailAsync(string receiverEmail, string subject, string message);
    }
}