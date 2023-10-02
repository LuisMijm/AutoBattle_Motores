
[System.Serializable]
public class Armor 
{
    public ArmorType name_;
    public int defense_;
    public int uses_;
    public PhysicalDamageType physicalProtecction_;

    public virtual void Init()
    {
        name_ = ArmorType.none;
        defense_ = 0;
        uses_ = 0;
        physicalProtecction_ = PhysicalDamageType.none;
    }

}

public enum ArmorType {
    lether,
    metal,
    diamond,
    none,
}
