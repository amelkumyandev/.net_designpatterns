namespace Adapter.ExternalServices
{
    public class SmsService
    {
        public void SendSms(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
