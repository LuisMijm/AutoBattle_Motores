using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitter : Zombie
{

    int spitAmount_;

    public Spitter()
    {
        Init();
    }

    public void Init()
    {
        name_ = "Spitter";
        type_ = ZombieType.Spitter;
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.long_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }

    void Start()
    {
        spitAmount_ = 5;
    }

    public override void OnDeath()
    {
        foreach (Character survivor in survivorList_)
        {
            if(survivor.active_)
            {
                survivor.health_ -= spitAmount_;
            }
        }

        Debug.Log("A spitter exploded and hurt all survivors");
    }
}
