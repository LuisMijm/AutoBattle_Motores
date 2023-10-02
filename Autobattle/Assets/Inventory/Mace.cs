
using UnityEngine;

public class Mace : Weapon
{
    public Mace()
    {
        Init();
    }

    public override void Init()
    {
        name_ = WeaponType.mace;
        damage_ = Random.Range(2,5);
        uses_ = 2;
        physicalType_ = PhysicalDamageType.blunt;
    }
}
