using UnityEngine;


public class Melee : Survivor
{
    public Melee()
    {
        // name_ = "Melee";
        // health_ = Random.Range(5, 15);
        // damage_ = Random.Range(10, 20);
        // range_ = RangeType.mid_range;
        // active_ = true;
        Init();
    }

    public override void Init()
    {
        name_ = "Melee";
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(10, 20);
        range_ = RangeType.mid_range;
        active_ = true;
        if(weapon == null)
        {
            weapon = new Weapon();
        }
        weapon = weapon.Init();
    }
}
