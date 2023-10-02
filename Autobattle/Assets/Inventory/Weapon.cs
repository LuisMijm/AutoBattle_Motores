using UnityEngine;

public class Weapon
{
    public WeaponType name_;
    public int damage_;
    public int uses_;
    public FisicalDamageType fisicalType_;

    public virtual void Init()
    {
        name_ = WeaponType.none;
        damage_ = 0;
        uses_ = 0;
        fisicalType_ = FisicalDamageType.none;
    }
}

public enum WeaponType {
    blade,
    mace,
    none,
}
