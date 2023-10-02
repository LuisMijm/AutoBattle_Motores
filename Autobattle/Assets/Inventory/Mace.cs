
using UnityEngine;

public class Mace : Weapon
{
    public override void Init()
    {
        name_ = WeaponType.mace;
        damage_ = Random.Range(2,5);
        uses_ = 2;
        fisicalType_ = FisicalDamageType.blunt;
    }
}
