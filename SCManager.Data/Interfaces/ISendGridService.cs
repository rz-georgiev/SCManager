using SendGrid;
using System.Threading.Tasks;

namespace SCManager.Data
{
    public interface ISendGridService
    {
        Task<Response> SendEmailAsync(string receiverEmail, string subject, string message);
    }
}