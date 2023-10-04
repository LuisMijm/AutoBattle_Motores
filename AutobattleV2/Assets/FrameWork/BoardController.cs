using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController 
{
    MainScript mc_;

    void Start()
    {
        GameObject mainObj = GameObject.Find("MainObj");
        mc_ = mainObj.GetComponent<MainScript>();
    }

    // public void FillBoard(List<Character> survivors, List<Character> zombies)
    // {
    //     for(int i = 0; i < 3; ++i)
    //     {
    //         Survivor temp_survivor = survivors.Init();
    //         // Survivor temp_survivor = new Survivor();
    //         // temp_survivor.Init();
    //         survivors.Add(temp_survivor);

    //         Zombie temp_zombie = new Zombie();
    //         temp_zombie.Init();
    //         zombies.Add(temp_zombie);
    //     }
    // }


    public void FillBoard(List<Character> survivors, List<Character> zombies)
    {
        for (int i = 0; i < 3; ++i)
        {
            // Init Survivor
            Survivor temp_survivor;
            SurvivorType s_selector = (SurvivorType)Random.Range(0, (int)SurvivorType.total);

            switch(s_selector)
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
            temp_survivor.Init();
            survivors.Add(temp_survivor);


            // Init Zombie
            Zombie temp_zombie;
            ZombieType z_selector = (ZombieType)Random.Range(0, (int)ZombieType.total);

            switch (z_selector)
            {
                case ZombieType.Bulky:
                    temp_zombie = new Bulky();
                    break;

                case ZombieType.Biter:
                    temp_zombie = new Biter();
                    break;

                case ZombieType.Spitter:
                    temp_zombie = new Spitter();
                    break;

                case ZombieType.Manhunter:
                    temp_zombie = new Manhunter();
                    break;

                default:
                    temp_zombie = new Bulky();
                    break;
            }
            temp_zombie.Init();
            zombies.Add(temp_zombie);
        }
    }


    public bool CheckRemaining(List<Character> list)
    {
        bool temp_check = false;

        foreach (Character character in list)
        {
            if(character.active_)
            {
                temp_check = true;
            }
        }

        return temp_check;
    }

    public BattleResult Battle(Character attacker, Character deffender, int battleRange)
    {
        BattleResult result = BattleResult.atkNotAlive;

        if(attacker.active_)
        {
            if((int)attacker.range_ >= battleRange)
            {
                if(deffender.active_)
                {
                    DamageType temp_dt = attacker.controler_.Attack(attacker, attacker.damageType_.elementType_);
                    deffender.controler_.TakeDamage(deffender, temp_dt);
                    result = BattleResult.succesfullAttack;

                }else
                {
                    return BattleResult.defNotAlive;
                }
            }else
            {
                return BattleResult.noReach;
            }
        }

        return result;
    }

    void Fight()
    {
        for(int i = 0; i < 3; ++i)
        {
            int battleRange = Random.Range(0, 3);
            
            BattleResult result = Battle(mc_.survivorList_[i], mc_.zombieList_[i], battleRange);

            switch(result)
            {
                case BattleResult.atkNotAlive: 
                break;

                case BattleResult.noReach: 
                break;

                case BattleResult.defNotAlive: 
                break;

                case BattleResult.succesfullAttack: 
                break;
            }

            // if(survivorList_[i].active_)
            // {
            //     if((int)survivorList_[i].range_ >= battleRange)
            //     {
            //         if(zombieList_[i].active_)
            //         {
            //             AttackZombie(survivorList_[i], zombieList_[i], i);
            //         // }

            //         // else if(zombieList_[i - 1] != null && zombieList_[i - 1].active_){
            //         //     AttackZombie(survivorList_[i], zombieList_[i - 1], i);
            //         // }

            //         // else if(zombieList_[i + 1] != null && zombieList_[i + 1].active_){
            //         //     AttackZombie(survivorList_[i], zombieList_[i + 1], i);
            //         }else{
            //             bool stop = false;
            //             for(int j = 0; j < 3 && !stop; j++)
            //             {
            //                 if(zombieList_[j].active_)
            //                 {
            //                     AttackZombie(survivorList_[j], zombieList_[j], j);
            //                     stop = true;
            //                 }
            //             }
            //         }             
            //     }else
            //     {
            //         Debug.Log("Survivor " + i + " Can't reach the enemy");
            //     }
            // }

            // /////////////////////

            // if(zombieList_[i].active_)
            // {
            //     if((int)zombieList_[i].range_ >= battleRange)
            //     {
            //         if(survivorList_[i].active_)
            //         {
            //             AttackSurvivor(zombieList_[i], survivorList_[i], i);
            //         }

            //         else if(survivorList_[i - 1] != null && survivorList_[i - 1].active_){
            //             AttackSurvivor(zombieList_[i], survivorList_[i - 1], i);
            //         }

            //         else if(survivorList_[i + 1] != null && survivorList_[i + 1].active_){
            //             AttackSurvivor(zombieList_[i], survivorList_[i + 1], i);
            //         }              
            //     }else
            //     {
            //         Debug.Log("Zombie " + i + " Can't reach the enemy");
            //     }
            // }
        }
    }

    public void UpdateBoard()
    {
        if(Input.GetKeyDown(KeyCode.Space) && mc_.GameRunning_)
        {
            Debug.Log("Battle beggin");
            Fight();
            Debug.Log("Battle end");

            // Debug.Break();


            bool zombieRemaining = CheckRemaining(mc_.zombieList_);
            bool survivorRemaining = CheckRemaining(mc_.survivorList_);

            if(!zombieRemaining && !survivorRemaining)
            {
                Debug.Log("Everybody died");
                mc_.GameRunning_ = false;

            }
            else if(zombieRemaining && !survivorRemaining)
            {
                Debug.Log("The Zombies win");
                mc_.GameRunning_ = false;
            }
            else if(survivorRemaining && !zombieRemaining)
            {
                Debug.Log("The Survivors win");
                mc_.GameRunning_ = false;
            }

            Debug.Log(" ---------- ");

        }else if (Input.GetKeyDown(KeyCode.Space) && !mc_.GameRunning_)
        {
            Debug.Log("Game Ended");
        }
    }


}

public enum BattleResult
{
    atkNotAlive,
    noReach,
    defNotAlive,
    succesfullAttack,
    none
}