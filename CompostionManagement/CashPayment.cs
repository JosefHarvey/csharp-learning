public class CashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Processing cash payment...");
    }
}