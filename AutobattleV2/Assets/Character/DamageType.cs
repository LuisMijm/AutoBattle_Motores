

public class DamageType 
{
    public float amount_;
    public ElementalDamageType elementType_;
    public PhysicalDamageType physicalType_;
}

public enum ElementalDamageType {
    fire,
    poison,
    ice,
    none
}

public enum PhysicalDamageType {
    blunt,
    piercing,
    slashing,
    none
}

public enum RangeType {
    short_range,
    mid_range,
    long_range,
    total_range
}