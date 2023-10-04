
using UnityEngine;

public class CharacterControler
{
    public DamageType Attack(Character character, 
                             ElementalDamageType elementType)
    {
        DamageType temp_dt;
        temp_dt = new DamageType();
        temp_dt.amount_ = character.damage_;
        temp_dt.elementType_ = elementType;
        temp_dt.physicalType_ = character.weapon_.physicalType_;
        
        if(character.weapon_.uses_ > 0)
        {
            temp_dt.amount_ += character.weapon_.damage_;
            character.weapon_.uses_--;
        }

        if(Random.Range(0,character.criticChance_) == 0)
        {
            temp_dt.amount_ *= 1.5f;
        }

        return temp_dt;
    }

    public void TakeDamage(Character character, DamageType dt)
    {
        if(dt.amount_ >= 0)
        {
            character.health_ -= dt.amount_ - character.armour_.defense_;
        }
        
        if(character is Zombie)
        {
            character.OnDeath();
        }
    } 
}


// int CurrentDefence 
// {
//     get {
//         return currentDefence_;
//     }
//     set {
//         currentDefence_ = value;
//     }
// }
