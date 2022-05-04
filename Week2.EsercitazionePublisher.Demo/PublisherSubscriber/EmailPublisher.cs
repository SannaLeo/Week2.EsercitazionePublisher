using Week2.EsercitazionePublisher.Demo.Notifications;
using Week2.EsercitazionePublisher.Demo.PublisherSubscriber;

internal class EmailPublisher : IPublisher
{
    public string Name { get; set; }
    public string Provider { get; set; }

    public EmailPublisher(string name, string provider)
    {
        Name = name;
        Provider = provider;
    }

    public event IPublisher.Notify OnPublish;


    public void Publish()
    {
        if (OnPublish != null)
        {
            Notification notifica = new($"new {Provider} mail just arrived", DateTime.Now, Name);
            OnPublish(this, notifica);
        }
        else
        {
            Console.WriteLine("On publish null");
        }
    }
}