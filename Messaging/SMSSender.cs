public class SMSSender : IMessageSender
{
    public bool ConnectToService()
    {
        // get user phone numer
        // connect to text message service
        return true;
    }

    public bool SendMessage()
    {

        // post number and message to service
        // tell service to send SMS
        return true;
    }
}