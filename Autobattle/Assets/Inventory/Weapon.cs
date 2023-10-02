using UnityEngine;

[System.Serializable]
public class Weapon
{
    public WeaponType name_;
    public int damage_;
    public int uses_;
    public PhysicalDamageType physicalType_;

    public virtual void Init()
    {
        name_ = WeaponType.none;
        damage_ = 0;
        uses_ = 0;
        physicalType_ = PhysicalDamageType.none;
    }
}

public enum WeaponType {
    blade,
    mace,
    bow,
    none,
}
