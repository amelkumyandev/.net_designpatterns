using Adapter.ExternalServices;

namespace Adapter.Adapters
{
    public class SlackNotificationAdapter : INotificationSender
    {
        private readonly SlackService _slackService = new SlackService();

        public void Send(string message)
        {
            _slackService.SendMessage(message);
        }
    }
}
