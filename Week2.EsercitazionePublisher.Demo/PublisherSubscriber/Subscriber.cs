using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.EsercitazionePublisher.Demo.Notifications;

namespace Week2.EsercitazionePublisher.Demo.PublisherSubscriber
{
    internal class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Subscribe(IPublisher p)
        {
            p.OnPublish += OnNotificationReceived;
        }

        public void UnSubscribe(IPublisher p)
        {
            p.OnPublish -= OnNotificationReceived;
        }


        public void OnNotificationReceived(IPublisher p, Notification n)
        {
            Console.WriteLine($"Hi {Name}, {n.Message} from {n.Sender} at {n.DateReceived}");
        }
    }
}
