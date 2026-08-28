public class Boss : IMoveable, IAttackable, IHealable
{
    public void Move()
    {
        Console.WriteLine("Boss is Moving");
    }

    public void Attack()
    {
        Console.WriteLine("Boss is Attacking");
    }

    public void Heal()
    {
        Console.WriteLine("Boss is Healing");
    }
}