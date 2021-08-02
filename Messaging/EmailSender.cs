public class EmailSender : IMessageSender
{
    public bool ConnectToService()
    {
        // connect to the email server
        return true;
    }

    public bool SendMessage()
    {
        // add text to email
        // send email
        return true;
    }
}
