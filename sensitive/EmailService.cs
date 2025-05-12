public class EmailService
{
    private readonly string _sendGridApiKey = "SG.febtomid28_sendgrid_api_key";

    public async Task SendEmailAsync(string email, string subject, string message)
    {
        var client = new SendGridClient(_sendGridApiKey);
        var from = new EmailAddress("TJpAVfxfmDunS1nnreOMN3rNIomIiC06AFNBnexkS1G1YIxhgVxnaF9LiZgh@clunny.com", "4aIQHpTOX@@tdESFLx09$mZnn");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        var response = await client.SendEmailAsync(msg);
    }
}
