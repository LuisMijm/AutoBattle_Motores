using UnityEngine;

public class Bulky : Zombie
{
    public Bulky()
    {
        Init();
    }

    public override void Init()
    {
        name_ = "Bulky";
        type_ = ZombieType.Bulky;
        health_ = Random.Range(10, 20);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.short_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }

    public override void OnDeath(){}

}
