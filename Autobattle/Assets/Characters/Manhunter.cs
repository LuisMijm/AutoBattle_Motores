using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manhunter : Zombie
{
    public Manhunter()
    {
        name_ = "Manhunter";
        type_ = ZombieType.Manhunter;
        health_ = Random.Range(10, 20);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.mid_range;
        active_ = true;
    }

    public override void OnDeath(){}

}
