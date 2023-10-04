using UnityEngine;

public class Biter : Zombie
{
    public Biter()
    {
        Init();
    }

    public void Init()
    {
        name_ = "Biter";
        type_ = ZombieType.Biter;
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(10, 20);
        range_ = RangeType.mid_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }
    
    public override void OnDeath(){}

}
