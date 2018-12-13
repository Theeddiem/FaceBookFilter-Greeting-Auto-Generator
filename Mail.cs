using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public static class Mail
    {
        private const string k_HostEmailSever = "smtp.gmail.com";
        private const string k_IdLoginEmail = "greetingscsharp@gmail.com";
        private const string k_PassWordLoginEmail = "1Q2W3e4r";
        private const int k_PortNumber = 25;
        private const int k_Timeout = 10000;

        public static void SendEmailMessage(string i_ToAddress, string i_FromAddress, string i_MsgSubject, string i_MsgBody, string i_ImagefilePath)
        {
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Port = k_PortNumber,
                    Host = k_HostEmailSever,
                    EnableSsl = true,
                    Timeout = k_Timeout,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false
                };
                client.Credentials = new NetworkCredential(k_IdLoginEmail, k_PassWordLoginEmail);

                MailMessage newMailMessage = new MailMessage(i_FromAddress, i_ToAddress, i_MsgSubject, i_MsgBody);
                newMailMessage.BodyEncoding = UTF8Encoding.UTF8;
                newMailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                Attachment attachment = new Attachment(i_ImagefilePath);
                newMailMessage.Attachments.Add(attachment);

                client.Send(newMailMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
    }
}
