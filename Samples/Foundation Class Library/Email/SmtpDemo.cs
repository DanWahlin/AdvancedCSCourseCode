using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace Chapter2.Email
{
    class SmtpDemo
    {
        public static void Main()
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress("test@test.com"));
            msg.From = new MailAddress("admin@test.com");
            msg.Subject = "Test Message";
            msg.Body = "Test Message Body";
            SmtpClient client = new SmtpClient();
            client.Host = "localhost";
            client.Send(msg);
            Console.WriteLine("Email sent to " + msg.To[0].Address);
            Console.ReadLine();
        }

    }
}
