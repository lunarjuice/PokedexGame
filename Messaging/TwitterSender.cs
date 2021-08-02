public class TwitterSender : IMessageSender
{
    public bool ConnectToService()
    {
        // connect to twitter
        return true;
    }

    public bool SendMessage()
    {

        // cust message down to 160 characters
        // send message
        return true;
    }
}