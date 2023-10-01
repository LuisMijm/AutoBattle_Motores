using UnityEngine;


public class Tank : Survivor
{
    public Tank()
    {
        name_ = "Tank";
        type_ = SurvivorType.Tank;
        health_ = Random.Range(0, 10) + 10;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.short_range;
        active_ = true;
    }
}
