using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.EsercitazionePublisher.Demo.Notifications;

namespace Week2.EsercitazionePublisher.Demo.PublisherSubscriber
{
    internal interface IPublisher
    {
        public string Name { get ; set ; }
       
        

        public delegate void Notify(IPublisher p, Notification notification);

        public event Notify OnPublish;

        public void Publish();
       
    }
}
