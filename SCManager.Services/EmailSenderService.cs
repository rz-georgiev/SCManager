using Microsoft.Extensions.Configuration;
using SCManager.Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
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


        public async Task<Response> SendEmailAsync(string receiverEmail, string subject, string messageContent)
        {
            var apiKey = _configuration["SendGridCredentials:ApiKey"];
            var senderEmail = _configuration["SendGridCredentials:SenderEmail"];
            var senderName = _configuration["SendGridCredentials:SenderName"];

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(receiverEmail, receiverEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, messageContent, messageContent);
            
            var response = await client.SendEmailAsync(msg);
            return response;
        }
    }
}