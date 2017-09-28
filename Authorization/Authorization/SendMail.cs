using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Authorization
{
    class SendMail
    {
        public string Send(string to)
        {
            Random rand = new Random();
            string code = rand.Next().GetHashCode().ToString();

            string from = "validationemail@yandex.ru";
            string password = "Validation_Email1512";           
            string subject = "Validation E-mail";
            string body = string.Format("Validation Code: {0}", code);

            MailMessage mail = new MailMessage { From = new MailAddress(from) };

            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            using (SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587))
            {
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            mail.Dispose();
               
            return code;
        }
    }
}