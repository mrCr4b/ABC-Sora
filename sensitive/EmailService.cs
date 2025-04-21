public class EmailService
{
    private readonly string _sendGridApiKey = "SG.febtomid28_sendgrid_api_key";

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        var client = new SendGridClient(_sendGridApiKey);
        var from = new EmailAddress("3YFwB9f%I9az1hBx57!IRqWpt5hIFzVafvZyJg7iw8UZp9bI0zch$R4MQ*XB%IF*US8PMKo5IxY5SM!b6mc8sc3^%^P5!O1&GAZX", "ML3ztUoF8FjY*%qvyCt6k&B!^7RagYZuvArj@K949EwdsMGYMclnGnQCU^bL0W#8PjGOK2ZA*0l50Ks84w*IcF4TNTfV3L5klaDz");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        var response = await client.SendEmailAsync(msg);
    }
}
