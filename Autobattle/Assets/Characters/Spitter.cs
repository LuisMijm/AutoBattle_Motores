using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitter : Zombie
{
    public Spitter()
    {
        name_ = "Spitter";
        type_ = ZombieType.Spitter;
        health_ = Random.Range(0, 10) + 5;
        damage_ = Random.Range(0, 10) + 5;
        range_ = RangeType.long_range;
        active_ = true;
    }
    public override void OnDeath(){}

}
