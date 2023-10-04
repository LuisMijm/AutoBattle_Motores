
using UnityEngine;

public class Archer : Survivor
{
    public Archer()
    {
        Init();
    }

    public override void Init()
    {
        name_ = "Archer";
        type_ = SurvivorType.Archer;
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.long_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }
}
