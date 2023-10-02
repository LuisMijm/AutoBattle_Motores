


public class CharacterControler
{

    public DamageType Attack(Character character, Weapon weapon, Armor armor, 
                            ElementalDamageType elementType, FisicalDamageType fisicalType, 
                            RangeType rangeType)
    {
        DamageType temp_dt;
        temp_dt = new DamageType();
        temp_dt.amount = character.damage_;
        temp_dt.elementType_ = elementType;
        temp_dt.fisicalType_ = fisicalType;
        temp_dt.rangeType_ = rangeType;

        // Debug.Log("");

        return temp_dt;
    }

    public void TakeDamage(Character character, DamageType dt)
    {
        character.health_ -= dt.amount_;
        
    }
}
