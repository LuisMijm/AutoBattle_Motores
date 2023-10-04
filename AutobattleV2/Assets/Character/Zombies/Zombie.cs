
using UnityEngine;

public class Zombie : Character
{
    public ZombieType type_;

    public Zombie(bool random = true, ZombieType zombieType = ZombieType.Bulky)
    {
        // Init(random, zombieType);
        Init();

    }

    public virtual void Init(){}

    // public virtual Zombie Init(bool random = true, ZombieType zombieType = ZombieType.Bulky)
    // {
    //     Zombie temp_zombie;
    //     ZombieType selector;

    //     if(random)
    //     {
    //         selector = (ZombieType)Random.Range(0, (int)ZombieType.total);
    //     }else{
    //         selector = zombieType;
    //     }


    //     switch(selector)
    //     {
    //         case ZombieType.Bulky:
    //             temp_zombie = new Bulky();
    //             break;

    //         case ZombieType.Biter:
    //             temp_zombie = new Biter();
    //             break;

    //         case ZombieType.Spitter: 
    //             temp_zombie = new Spitter();
    //             break;

    //         case ZombieType.Manhunter:
    //             temp_zombie = new Manhunter();
    //             break;

    //         default: 
    //             temp_zombie = new Bulky();
    //             break;
    //     }
    //     return temp_zombie;
    // }

    public override void OnDeath(){}
}


public enum ZombieType {
    Bulky,
    Biter,
    Spitter,
    Manhunter,
    total
}