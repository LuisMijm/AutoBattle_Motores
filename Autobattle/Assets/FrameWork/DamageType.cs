


public class DamageType 
{
    // public enum RangeType {
    // short_range,
    // mid_range,
    // long_range,
    // total_range
    // }

    public float amount_;
    public ElementalDamageType elementType_;
    public FisicalDamageType fisicalType_;
    public RangeType rangeType_;

    // public DamageType()
    // {
        
    // }
}

public enum ElementalDamageType {
    fire,
    poison,
    ice,
    none
}

public enum FisicalDamageType {
    blunt,
    piercing,
    slashing,
    none
}