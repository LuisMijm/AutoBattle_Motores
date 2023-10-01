using UnityEngine;

public class Biter : Zombie
{
    public Biter()
    {
        name_ = "Biter";
        type_ = ZombieType.Biter;
        health_ = Random.Range(0, 10) + 5;
        damage_ = Random.Range(0, 10) + 10;
        range_ = RangeType.mid_range;
        active_ = true;
    }
    public override void OnDeath(){}

}
