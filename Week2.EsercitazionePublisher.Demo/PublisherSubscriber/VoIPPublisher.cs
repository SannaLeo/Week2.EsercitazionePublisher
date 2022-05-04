using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.EsercitazionePublisher.Demo.Notifications;

namespace Week2.EsercitazionePublisher.Demo.PublisherSubscriber
{
    internal class VoIPPublisher : IPublisher
    {
        public string Name { get; set; }
        

        public VoIPPublisher(string name)
        {
            Name = name;
        }

        public event IPublisher.Notify OnPublish;


        public void Publish()
        {
            if (OnPublish != null)
            {
                Notification notifica = new($"new voip just arrived", DateTime.Now, Name);
                OnPublish(this, notifica);
            }
            else
            {
                Console.WriteLine("On publish null");
            }
        }
    }
}
