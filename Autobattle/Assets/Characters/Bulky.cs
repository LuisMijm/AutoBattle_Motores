using UnityEngine;

public class Bulky : Zombie
{
    public Bulky()
    {
        name_ = "Bulky";
        type_ = ZombieType.Bulky;
        health_ = Random.Range(10, 20);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.short_range;
        active_ = true;
    }

    public override void OnDeath(){

    }
}
