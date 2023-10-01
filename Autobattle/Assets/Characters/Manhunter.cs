using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manhunter : Zombie
{
    public Manhunter()
    {
        name_ = "Manhunter";
        type_ = ZombieType.Manhunter;
        health_ = Random.Range(0, 10) + 10;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.mid_range;
        active_ = true;
    }
    
    public override void OnDeath(){}

}
