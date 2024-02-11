using Adapter.ExternalServices;

namespace Adapter.Adapters
{
    public class SmsNotificationAdapter : INotificationSender
    {
        private readonly SmsService _smsService = new SmsService();

        public void Send(string message)
        {
            _smsService.SendSms(message);
        }
    }
}
