using UnityEngine;


public class Melee : Survivor
{
    public Melee()
    {
        name_ = "Melee";
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(10, 20);
        range_ = RangeType.mid_range;
        active_ = true;
    }
}
