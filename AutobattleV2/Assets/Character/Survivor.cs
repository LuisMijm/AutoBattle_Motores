
using UnityEngine;

public class Survivor : Character
{
    public SurvivorType type_;

    public Survivor(bool random = true, SurvivorType survivorType = SurvivorType.Tank)
    {
        Init(random, survivorType);
    }

    public virtual Survivor Init(bool random = true, SurvivorType survivorType = SurvivorType.Tank)
    {

        Survivor temp_survivor;
        SurvivorType selector;
        
        if(random)
        {
            selector = (SurvivorType)Random.Range(0, (int)SurvivorType.total);
        }else{
            selector = survivorType;
        }

        switch(selector)
        {
            case SurvivorType.Tank:
                temp_survivor = new Tank();
                break;

            case SurvivorType.Melee:
                temp_survivor = new Melee();
                break;

            case SurvivorType.Archer: 
                temp_survivor = new Archer();
                break;

            case SurvivorType.Medic:
                temp_survivor = new Medic();
                break;
            
            default:
                temp_survivor = new Tank();
                break;
        }

        return temp_survivor;
    }
}

public enum SurvivorType {
    Tank,
    Melee,
    Archer,
    Medic,
    total
}