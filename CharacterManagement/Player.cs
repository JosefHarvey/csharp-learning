public class Player : IMoveable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("Player is Moving");
    }

    public void Attack()
    {
        Console.WriteLine("Player is Attacking");
    }
}