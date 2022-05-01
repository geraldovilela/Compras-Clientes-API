using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;
using WEBAPI.Service.Interfaces;

namespace WEBAPI.Service
{
    public class EmailFacade : IEmailFacade
    {
        public void SendEmail(Compra request, string email)
        {
            MailMessage emailMessage = new MailMessage();

            try
            {
                var MailClient = new SmtpClient("smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("bfb0d314dcb027", "1968584314c1c7"),
                    EnableSsl = true
                };
                emailMessage.From = new MailAddress("from@example.com", "DataProcess API Teste");
                emailMessage.Body = $"a sua compra de {request.Descricao} foi realizada e já esta em fase de preparação para entrega.";
                emailMessage.Subject = "Sua Compra "+ request.Id;
                emailMessage.IsBodyHtml = true;
                emailMessage.Priority = MailPriority.Normal;
                emailMessage.To.Add(email);
                Console.WriteLine($"enviando email para {email}");
                MailClient.Send(emailMessage);

            }
            catch (Exception)
            {
                return;
            }

            
        }
    }
}
