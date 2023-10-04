using UnityEngine;


public class Tank : Survivor
{
    public Tank()
    {
        Init();
    }

    public override void Init()
    {
        name_ = "Tank";
        type_ = SurvivorType.Tank;
        health_ = Random.Range(10, 20);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.short_range;
        active_ = true;
        if (weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }
}
