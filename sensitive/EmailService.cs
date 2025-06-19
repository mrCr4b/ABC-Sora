public class EmailServiceForThis40thPRoject
{
    private readonly string _sendGridApiKey = "SG.febtomid28_sendgrid_api_key";

    public async Task SendEmailAsyncForUserInFLoor1(string email, string subject, string message)
    {
        var client = new SendGridClient(_sendGridApiKey);
        var from = new EmailAddress("JohnyEnglish@department1.com", "jpaBUOG6FWlPk4cHc315MumfHDYT4RHW3uiAlXRdNh5I0DJgJi");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        var response = await client.SendEmailAsync(msg);
    }
}
