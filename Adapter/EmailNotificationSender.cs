using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EmailNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
