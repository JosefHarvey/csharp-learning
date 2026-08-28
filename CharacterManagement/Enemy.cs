public class Enemy : IMoveable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("Enemy is Moving");
    }

    public void Attack()
    {
        Console.WriteLine("Enemy is Attacking");
    }
}