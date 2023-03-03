using System.Net.Mail;
using System.Net;
using System.Text;

namespace ecommerce.Persistence.Helper
{
    internal class ForgotPassword
    {
        private string _email;

        public ForgotPassword(string Email)
        {
            _email = Email;
        }

        public string SendEmail()
        {
            // Generate a unique code
            string code = GenerateCode();

            // Set up the email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("noreply@example.com");
            message.To.Add(_email);
            message.Subject = "Password Reset";
            message.Body = "Your password reset code is: " + code;

            // Send the email using SMTP
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("your-email@gmail.com", "your-email-password");
            client.Send(message);

            return code;
        }

        private string GenerateCode()
        {
            const string chars = "0123456789abcdef";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            return sb.ToString();
        }
    }
}
