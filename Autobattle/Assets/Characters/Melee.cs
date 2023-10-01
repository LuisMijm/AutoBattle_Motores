using UnityEngine;


public class Melee : Survivor
{
    public Melee()
    {
        name_ = "Melee";
        health_ = Random.Range(0, 10) + 5;
        damage_ = Random.Range(0, 10) + 10;
        range_ = RangeType.mid_range;
        active_ = true;
    }
}
