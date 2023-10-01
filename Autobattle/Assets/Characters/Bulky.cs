using UnityEngine;

public class Bulky : Zombie
{
    public Bulky()
    {
        name_ = "Bulky";
        type_ = ZombieType.Bulky;
        health_ = Random.Range(0, 10) + 10;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.short_range;
        active_ = true;
    }

    public override void OnDeath(){

    }
}
