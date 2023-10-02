using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : Weapon
{
    public override void Init()
    {
        name_ = WeaponType.blade;
        damage_ = Random.Range(2,5);
        uses_ = 2;
        fisicalType_ = FisicalDamageType.slashing;
    }
}
