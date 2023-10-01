using UnityEngine;

public class Biter : Zombie
{
    public Biter()
    {
        name_ = "Biter";
        type_ = ZombieType.Biter;
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(10, 20);
        range_ = RangeType.mid_range;
        active_ = true;
    }
    public override void OnDeath(){}

}
