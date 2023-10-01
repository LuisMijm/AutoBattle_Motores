using UnityEngine;


public class Archer : Survivor
{
    public Archer()
    {
        name_ = "Archer";
        health_ = Random.Range(0, 10) + 5;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.long_range;
        active_ = true;
    }
}
