using CloudinaryDotNet.Actions;
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
            var apiKey = _configuration["SendGridCredentials:ApiKey"];
            var senderEmail = _configuration["SendGridCredentials:SenderEmail"];
            var senderName = _configuration["SendGridCredentials:SenderName"];

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(receiverEmail, receiverEmail);

            var htmlContent = $"<div class=\"card shadow mb - 4\">" +
                    $"<div class=\"card-header py-3\">" +
                    $"<h6 class=\"m-2 font-weight-bold text-primary\">SCManager - {subject}</h6>" +
                    $"</div>" +
                    $"<div class=\"card - body\">" +
                    $"Dear {receiverEmail}, <br/>" +
                    $"{message} <br/>" +
                    $"Thank you for using our app!" +
                    $"</div>" +
                    $"</div>";

             var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
            return response;
        }
    }
}