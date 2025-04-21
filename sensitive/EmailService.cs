public class EmailService
{
    private readonly string _sendGridApiKey = "SG.febtomid28_sendgrid_api_key";

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        var client = new SendGridClient(_sendGridApiKey);
        var from = new EmailAddress("febtomid28@yourapp.com", "ML3ztUoF8FjY*%qvyCt6k&B!^7RagYZuvArj@K949EwdsMGYMclnGnQCU^bL0W#8PjGOK2ZA*0l50Ks84w*IcF4TNTfV3L5klaDz");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        var response = await client.SendEmailAsync(msg);
    }
}
