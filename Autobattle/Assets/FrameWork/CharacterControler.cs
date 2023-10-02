


public class CharacterControler
{

    public DamageType Attack(Character character, Weapon weapon, Armor armor, 
                            ElementalDamageType elementType, RangeType rangeType)
    {
        DamageType temp_dt;
        temp_dt = new DamageType();
        temp_dt.amount_ = character.damage_;
        temp_dt.elementType_ = elementType;
        temp_dt.physicalType_ = weapon.physicalType_;
        temp_dt.rangeType_ = rangeType;
        
        if(weapon.uses_ > 0)
        {
            temp_dt.amount_ += weapon.damage_;
        }

        if(Random.Range(0,character.criticChance_) == 0)
        {
            temp_dt.amount_ *= 1.5f;
        }


        // Debug.Log("");

        return temp_dt;
    }

    public void TakeDamage(Character character, DamageType dt)
    {
        character.health_ -= dt.amount_;
        
    }
}
