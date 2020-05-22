﻿using Microsoft.Extensions.Configuration;
using SCManager.Data;
using System;
using System.Diagnostics;
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
            var port = _configuration["MailSenderCredentials:Port"];

            using SmtpClient smtpClient = new SmtpClient();
            var basicCredential = new NetworkCredential(username, key);

            using MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(username);

            smtpClient.Host = host;
            smtpClient.Port = Convert.ToInt32(port);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            smtpClient.EnableSsl = false;

            message.From = fromAddress;
            message.Subject = "Confirmation link";
            // Set IsBodyHtml to true means you can send HTML email.
            message.IsBodyHtml = true;

            message.Body = messageContent;

            message.To.Add(receiverEmail);
           
                await smtpClient.SendMailAsync(message);
          
        }
    }
}