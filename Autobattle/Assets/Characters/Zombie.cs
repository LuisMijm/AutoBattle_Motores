

public class Zombie : Character
{
    public ZombieType type_;

    public override void OnDeath()
    {

    }
}


public enum ZombieType {
    Bulky,
    Biter,
    Spitter,
    Manhunter,
    total
}