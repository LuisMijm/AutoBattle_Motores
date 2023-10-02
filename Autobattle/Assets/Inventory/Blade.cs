
using UnityEngine;

public class Blade : Weapon
{
    public Blade()
    {
        Init();
    }

    public override void Init()
    {
        name_ = WeaponType.blade;
        damage_ = Random.Range(2,5);
        uses_ = 2;
        physicalType_ = PhysicalDamageType.slashing;
    }
}
