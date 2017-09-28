using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Authorization
{
    class SendMail
    {
        private  void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                MessageBox.Show("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                string mes = string.Format("[{0}] {1}", token, e.Error.ToString());
                MessageBox.Show(mes);
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        private static bool IsConnectedToInternet()
        {            
            return InternetGetConnectedState(out int Desc, 0);
        }
        public string Send()
        {
            WebClient Client = new WebClient();
            string Response;
            Random rand = new Random();
            string code = rand.Next().GetHashCode().ToString();
            try
            {
                Response = Client.DownloadString("http://microsoft.com");   

                string from = "validationemail@yandex.ru";
                string password = "Validation_Email1512";
                string to = "matveevalex1512@gmail.com";
                string subject = "Validation E-mail";
                string body = string.Format("Validation Code: {0}", code);
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from)
                };
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587))
                {
                    smtp.Credentials = new NetworkCredential(from, password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    smtp.SendCompleted+= new SendCompletedEventHandler(SendCompletedCallback);
                }
                mail.Dispose();
            }
            catch(Exception)
            {
                MessageBox.Show("Нет подключения к интернету!!");
            }
           
            return code;
        }

        public void SendOld()
        {
            WebClient Client = new WebClient();
            string Response;
            Random rand = new Random();
            string code = rand.Next().GetHashCode().ToString();
            try
            {
                Response = Client.DownloadString("http://microsoft.com");

                string from = "validationemail@yandex.ru";
                string password = "Validation_Email1512";
                string to = "matveevalex1512@gmail.com";
                string subject = "Validation E-mail";
                string body = string.Format("Validation Code: {0}", code);
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from)
                };
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587))
                {
                    smtp.Credentials = new NetworkCredential(from, password);
                    smtp.EnableSsl = true;
                    smtp.SendAsync(mail, body);
                    smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                }
                mail.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет подключения к интернету!!");
            } 
        }
    }
}