using SendGrid;
using System.Threading.Tasks;

namespace SCManager.Data
{
    public interface ISmtpService
    {
        Task SendEmailAsync(string receiverEmail, string subject, string message);
    }
}