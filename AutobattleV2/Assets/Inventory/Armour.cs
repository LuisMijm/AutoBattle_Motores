

[System.Serializable]
public class Armour : Inventory
{
    public ArmorType name_;
    public int defense_;

    public virtual void Init()
    {
        name_ = ArmorType.none;
        defense_ = 0;
        uses_ = 0;
        physicalType_ = PhysicalDamageType.none;
    }

}

public enum ArmorType {
    lether,
    metal,
    diamond,
    none,
}
