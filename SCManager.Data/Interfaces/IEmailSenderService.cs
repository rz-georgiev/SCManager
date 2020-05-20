using System.Threading.Tasks;

namespace SCManager.Data
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string receiverEmail, string subject, string message);
    }
}