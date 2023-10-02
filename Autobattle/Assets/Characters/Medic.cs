using UnityEngine;


public class Medic : Survivor
{
    public Medic()
    {
        Init();
    }

    public override void Init()
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
