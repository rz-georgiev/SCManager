using Microsoft.Extensions.Configuration;
using SCManager.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IConfiguration _configuration;

        public EmailSenderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string receiverEmail, string subject, string messageContent)
        {
            var username = _configuration["MailSenderCredentials:Username"];
            var key = _configuration["MailSenderCredentials:Key"];
            var host = _configuration["MailSenderCredentials:Host"];

            using SmtpClient smtpClient = new SmtpClient();
            var basicCredential = new NetworkCredential(username, key);
         
            using MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(username);

            smtpClient.Host = host;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;

            message.From = fromAddress;
            message.Subject = "Confirmation link";
            // Set IsBodyHtml to true means you can send HTML email.
            message.IsBodyHtml = true;

            message.Body = $"Dear {receiverEmail}, <br/>" +
                $"Thank you for registering to SCManager 1.0!.Your registration has been received.<br/>" +
                $"If you would like to activate your account, click on the following link:<br/>" +
                $"<a href='{messageContent}'>Click here to confirm</a><br/>" +
                $"Have fun using our app!<br/>" +
                $"Best Regards,<br/>" +
                $"SCManager<br/>";

            message.To.Add(receiverEmail);
            await smtpClient.SendMailAsync(message);
        }
    }
}