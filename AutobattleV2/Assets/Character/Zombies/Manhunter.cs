using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manhunter : Zombie
{
    public Manhunter()
    {
        Init();
    }

    public override void Init()
    {
        name_ = "Manhunter";
        type_ = ZombieType.Manhunter;
        health_ = Random.Range(10, 20);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.mid_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }

    public override void OnDeath(){}


}
