using SendGrid.Helpers.Mail;
using SendGrid;

namespace sendgridtest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }
        static async Task Execute()
        {
            Environment.SetEnvironmentVariable("apikey", "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");
            var apiKey = Environment.GetEnvironmentVariable("apikey");
            var client = new SendGridClient(apiKey);
            var from_email = new EmailAddress("garthdp4@gmail.com", "Garth");
            var subject = "Sending with Twilio SendGrid is Fun";
            var to_email = new EmailAddress("christoffelpetruskr@gmail.com", "Chris");
            var plainTextContent = "Thank you for subscribing!";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from_email, to_email, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
        }
    }
    
}
