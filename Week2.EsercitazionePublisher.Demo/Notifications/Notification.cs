using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazionePublisher.Demo.Notifications
{
    public class Notification
    {
        public string Sender { get; set; }
        public string Message { get; set; } 
        public DateTime DateReceived { get; set; }

        public Notification(string message, DateTime date, string sender)
        {
            Message = message;
            DateReceived = date;
            Sender = sender;
        }
    }
}
