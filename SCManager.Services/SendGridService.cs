using Microsoft.Extensions.Configuration;
using SCManager.Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class SendGridService : ISendGridService
    {
        private readonly IConfiguration _configuration;

        public SendGridService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Response> SendEmailAsync(string receiverEmail, string subject, string message)
        {
            if (string.IsNullOrWhiteSpace(receiverEmail) ||
                string.IsNullOrWhiteSpace(subject) ||
                string.IsNullOrWhiteSpace(message))
            {
                return null;
            }

            var apiKey = _configuration["SendGridCredentials:ApiKey"];
            var senderEmail = _configuration["SendGridCredentials:SenderEmail"];
            var senderName = _configuration["SendGridCredentials:SenderName"];

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(receiverEmail, receiverEmail);

            var htmlContent = BaseResources.EmailBaseContent;
            htmlContent = htmlContent.Replace("{{receiverEmail}}", receiverEmail);
            htmlContent = htmlContent.Replace("{{message}}", message);

            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
            return response;
        }
    }
}