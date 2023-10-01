using UnityEngine;


public class Archer : Survivor
{
    public Archer()
    {
        name_ = "Archer";
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.long_range;
        active_ = true;
    }
}
