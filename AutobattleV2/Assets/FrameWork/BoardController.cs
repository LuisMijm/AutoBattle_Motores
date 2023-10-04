using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MainScript
{
    public void FillBoard(List<Character> survivors, List<Character> zombies)
    {
        for(int i = 0; i < 3; ++i)
        {
            Survivor temp_survivor = new Survivor();
            temp_survivor.Init();
            survivors.Add(temp_survivor);

            Zombie temp_zombie = new Zombie();
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
            
            BattleResult result = Battle(survivorList_[i], zombieList_[i], battleRange);

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
        if(Input.GetKeyDown(KeyCode.Space) && GameRunning_)
        {
            Debug.Log("Battle beggin");
            Fight();
            Debug.Log("Battle end");

            // Debug.Break();


            bool zombieRemaining = CheckRemaining(zombieList_);
            bool survivorRemaining = CheckRemaining(survivorList_);

            if(!zombieRemaining && !survivorRemaining)
            {
                Debug.Log("Everybody died");
                GameRunning_ = false;

            }
            else if(zombieRemaining && !survivorRemaining)
            {
                Debug.Log("The Zombies win");
                GameRunning_ = false;
            }
            else if(survivorRemaining && !zombieRemaining)
            {
                Debug.Log("The Survivors win");
                GameRunning_ = false;
            }

            Debug.Log(" ---------- ");

        }else if (Input.GetKeyDown(KeyCode.Space) && !GameRunning_)
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