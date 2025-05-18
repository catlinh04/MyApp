using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.Interfaces;

namespace MyApp.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Thực hiện gửi email
            Console.WriteLine($"Sending email to {to} with subject: {subject}");
            Console.WriteLine($"Body: {body}");
        }
    }
}