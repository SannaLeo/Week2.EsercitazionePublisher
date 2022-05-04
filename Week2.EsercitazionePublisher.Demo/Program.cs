using Week2.EsercitazionePublisher.Demo.PublisherSubscriber;

IPublisher whatsappGroup = new WhatsPublisher("Leonardo", "Group Message");
IPublisher whatsapp = new WhatsPublisher("Leonardo", "Private Message");
IPublisher outlook = new EmailPublisher("Leonardo", "OutLook");

//Subscribers
Subscriber sub1 = new Subscriber("Antonia");
Subscriber sub2 = new Subscriber("Renata");
Subscriber sub3 = new Subscriber("Mirko");

//Mi iscrivo alla notifica dell'evento pubblicato da uno o più subscriber
sub1.Subscribe(whatsapp);
sub2.Subscribe(whatsapp);
sub1.Subscribe(whatsappGroup);
sub2.Subscribe(whatsappGroup);

sub3.Subscribe(outlook);
sub1.Subscribe(outlook);

outlook.Publish(); //metodo che scatena l'evento

Console.WriteLine("------------");

whatsapp.Publish();

Console.WriteLine("------------");

whatsappGroup.Publish();

Console.WriteLine("----------");

sub1.UnSubscribe(whatsappGroup);
sub1.UnSubscribe(whatsapp);
whatsapp.Publish();