using System.IO.Pipes;

IMoveable[] characters =
{
    new Player(),
    new Enemy(),
    new NPC(),
    new Boss()
};

IAttackable[] attacker =
{
    new Player(),
    new Enemy(),
    new Boss()
};

IHealable[] healer =
{
    new Boss()
};

foreach(IMoveable character in characters)
{
    character.Move();
}

foreach(IAttackable attackable in attacker)
{
    attackable.Attack();
}

foreach(IHealable healable in healer)
{
    healable.Heal();
}