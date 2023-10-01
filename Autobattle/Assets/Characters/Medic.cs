using UnityEngine;


public class Medic : Survivor
{
    public Medic()
    {
        name_ = "Medic";
        health_ = Random.Range(0, 10) + 5;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.mid_range;
        active_ = true;
    }

    void HealGroup()
    {

    }
}
