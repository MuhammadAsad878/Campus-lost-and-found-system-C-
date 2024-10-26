using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        // Code to send Email by Hotmail
        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                string emailAddress = "muhammadasad41@hotmail.com";
                string emailPassword = "09007860141@hotmail.com";
                string smtpServer = "smtp.office365.com";
                int smtpPort = 587;


                // Configure the client
                SmtpClient client = new SmtpClient(smtpServer, smtpPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAddress, emailPassword),
                    EnableSsl = true
                };

                // Create the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(emailAddress),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true, // if your email body is HTML
                };
                mailMessage.To.Add(toEmail);

                // Send the email
                client.Send(mailMessage);
                MessageBox.Show("Email sent successfully.");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.TargetSite);
            }
        }


        

        

    }
}
