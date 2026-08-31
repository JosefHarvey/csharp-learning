public class WhatsappNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending WhatsApp notification: {message}");
    }
}