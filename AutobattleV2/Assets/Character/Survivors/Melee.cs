using UnityEngine;


public class Melee : Survivor
{
    public Melee()
    {
        Init();
    }

    public override void Init()
    {
        name_ = "Melee";
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
}
