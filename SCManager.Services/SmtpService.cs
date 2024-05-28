using Microsoft.Extensions.Configuration;
using SCManager.Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly IConfiguration _configuration;

        public SmtpService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string receiverEmail, string subject, string message)
        {
            if (string.IsNullOrWhiteSpace(receiverEmail) ||
                string.IsNullOrWhiteSpace(subject) ||
                string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            var senderEmail = _configuration["MailClientCredentials:SenderEmail"];
            var senderEmailKey = _configuration["MailClientCredentials:SenderEmailKey"];
            var senderName = _configuration["MailClientCredentials:SenderName"];
            var mailServer = _configuration["MailClientCredentials:MailServer"];
            var mailPort = _configuration["MailClientCredentials:MailPort"];

            var htmlContent = BaseResources.EmailBaseContent;
            htmlContent = htmlContent.Replace("{{receiverEmail}}", receiverEmail);
            htmlContent = htmlContent.Replace("{{message}}", message);

            var mySmtpClient = new SmtpClient(mailServer)
            {
                Port = Convert.ToInt32(mailPort),
                UseDefaultCredentials = false
            };

            System.Net.NetworkCredential basicAuthenticationInfo = new (senderEmail, senderEmailKey);
            mySmtpClient.Credentials = basicAuthenticationInfo;

            var from = new MailAddress(senderEmail, senderName);
            var to = new MailAddress(receiverEmail, receiverEmail);
            var myMail = new System.Net.Mail.MailMessage(from, to)
            {
                Subject = subject,
                SubjectEncoding = System.Text.Encoding.UTF8,
                Body = htmlContent,
                BodyEncoding = System.Text.Encoding.UTF8,
                IsBodyHtml = true
            };

            await mySmtpClient.SendMailAsync(myMail);
        }
    }
}