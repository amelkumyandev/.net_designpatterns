namespace Adapter.ExternalServices
{
    public class SlackService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Slack Message: {message}");
        }
    }
}
