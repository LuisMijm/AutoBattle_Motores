using UnityEngine;


public class Medic : Survivor
{
    public Medic()
    {
        name_ = "Medic";
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.mid_range;
        active_ = true;
    }

    void HealGroup()
    {

    }
}
