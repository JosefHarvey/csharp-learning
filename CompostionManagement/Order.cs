public class Order
{
    public IPayment Payment {get; set;}
    public INotification Notification {get; set;}

    public Order(IPayment payment, INotification notification)
    {
        Payment = payment;
        Notification = notification;
    }

    public void Checkout()
    {
        Payment.Pay();
        Notification.Send("Your order has been processed successfully.");
    }
}