using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    // public List<Survivor> survivorList_;
    // public List<Zombie> zombieList_;

    public List<Character> survivorList_;
    public List<Character> zombieList_;
    
    public bool GameRunning_;

    void Start()
    {
        // survivorList_ = new List<Survivor>();
        // zombieList_ = new List<Zombie>();
        
        survivorList_ = new List<Character>();
        zombieList_ = new List<Character>();
        GameRunning_ = true;
        FillBoard();
        // ShowStats(0);
    }

    Survivor InitSurvivor()
    {
        Survivor temp_survivor;
        SurvivorType selector = (SurvivorType)Random.Range(0, (int)SurvivorType.total);

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
                temp_survivor = new Survivor();
                break;
        }
        return temp_survivor;
    }

    Zombie InitZombie()
    {
        Zombie temp_zombie;
        ZombieType selector = (ZombieType)Random.Range(0, (int)ZombieType.total);

        switch(selector)
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
                temp_zombie = new Zombie();
                break;
        }
        return temp_zombie;
    }

    void FillBoard()
    {
        for(int i = 0; i < 3; ++i)
        {
            Survivor temp_survivor = InitSurvivor();
            survivorList_.Add(temp_survivor);

            Zombie temp_zombie = InitZombie();
            zombieList_.Add(temp_zombie);
        }


        if (survivorList_.Count > 0 && zombieList_.Count > 0)
        {
            // Debug.Log("Survivor 1 " + survivorList_[0].name_ + 
            //             " is ready to fight zombie 1 " + zombieList_[0].name_);
            // Debug.Log("Survivor 2 " + survivorList_[1].name_ + 
            //             " is ready to fight zombie 2 " + zombieList_[1].name_);
            // Debug.Log("Survivor 3 " + survivorList_[2].name_ + 
            //             " is ready to fight zombie 3 " + zombieList_[2].name_);
        }
        else
        {
            Debug.Log("Las listas de personaje no estan completas");
        }
    }

    void ShowStats(int duelers)
    {
        if(survivorList_[duelers] != null && zombieList_[duelers] != null)
        {
            Debug.Log("survivor name: " + survivorList_[duelers].name_ + 
                        " - zombie name: " + zombieList_[duelers].name_);
            Debug.Log("survivor health: " + survivorList_[duelers].health_ + 
                        " - zombie health: " + zombieList_[duelers].health_);
            Debug.Log("survivor damage: " + survivorList_[duelers].damage_ + 
                        " - zombie damage: " + zombieList_[duelers].damage_);
            Debug.Log("survivor active: " + survivorList_[duelers].active_ + 
                        " - zombie active: " + zombieList_[duelers].active_);
            Debug.Log("survivor range: " + survivorList_[duelers].range_ + 
                        " - zombie range: " + zombieList_[duelers].range_);
        }
    }

    void AttackZombie(Character survivor, Character zombie, int position)
    {
        zombie.health_ -= survivor.damage_;   
        if(zombie.health_ <= 0)
        {
            zombie.health_ = 0;
            zombie.active_ = false;
            zombie.OnDeath();
            Debug.Log("Zombie " + position + ": " + zombie.name_ + " has been attack and is dead for real");
        }else
        {
            Debug.Log("Zombie " + position + ": " + zombie.name_ + " has been attack; " + 
                        zombie.health_ + " health remaining");
        }
    }

    void AttackSurvivor(Character zombie, Character survivor, int position)
    {
        survivor.health_ -= zombie.damage_;   
        if(survivor.health_ <= 0)
        {
            survivor.health_ = 0;
            survivor.active_ = false;
            Debug.Log("Survivor " + position + ": " + survivor.name_ + " has been attack and is dead");
        }else
        {
            Debug.Log("Survivor " + position + ": " + survivor.name_ + " has been attack; " + 
                        survivor.health_ + " health remaining");
        }
    }

    void AttackCharacter(Character attacker, Character deffender, int position, char characterClass)
    {
        deffender.health_ -= attacker.damage_;   
        if(deffender.health_ <= 0)
        {
            deffender.health_ = 0;
            deffender.active_ = false;
            Debug.Log(characterClass + " " + position + ": " + deffender.name_ + " has been attack and is dead");
        }else
        {
            Debug.Log(characterClass + " " + position + ": " + deffender.name_ +" has been attack; " + 
                        deffender.health_ + " health remaining");
        }
    }

    int AttackCharacter2(Character attacker, Character deffender, int battleRange)
    {
        deffender.health_ -= attacker.damage_;   
        
        if((int)attacker.range_ < battleRange)
        {
            return 0;
        }

        if(deffender.health_ <= 0)
        {
            deffender.health_ = 0;
            deffender.active_ = false;
            return 1;
        }else
        {
            return 2;
        }

        // return 4;
    }

    void Fight()
    {
        for(int i = 0; i < 3; ++i)
        {
            int battleRange = Random.Range(0, 3);
            
            if(survivorList_[i].active_)
            {
                if((int)survivorList_[i].range_ >= battleRange)
                {
                    if(zombieList_[i].active_)
                    {
                        AttackZombie(survivorList_[i], zombieList_[i], i);
                    // }

                    // else if(zombieList_[i - 1] != null && zombieList_[i - 1].active_){
                    //     AttackZombie(survivorList_[i], zombieList_[i - 1], i);
                    // }

                    // else if(zombieList_[i + 1] != null && zombieList_[i + 1].active_){
                    //     AttackZombie(survivorList_[i], zombieList_[i + 1], i);
                    }else{
                        bool stop = false;
                        for(int j = 0; j < 3 && !stop; j++)
                        {
                            if(zombieList_[j].active_)
                            {
                                AttackZombie(survivorList_[j], zombieList_[j], j);
                                stop = true;
                            }
                        }
                    }             
                }else
                {
                    Debug.Log("Survivor " + i + " Can't reach the enemy");
                }
            }

            /////////////////////

            if(zombieList_[i].active_)
            {
                if((int)zombieList_[i].range_ >= battleRange)
                {
                    if(survivorList_[i].active_)
                    {
                        AttackSurvivor(zombieList_[i], survivorList_[i], i);
                    }

                    else if(survivorList_[i - 1] != null && survivorList_[i - 1].active_){
                        AttackSurvivor(zombieList_[i], survivorList_[i - 1], i);
                    }

                    else if(survivorList_[i + 1] != null && survivorList_[i + 1].active_){
                        AttackSurvivor(zombieList_[i], survivorList_[i + 1], i);
                    }              
                }else
                {
                    Debug.Log("Zombie " + i + " Can't reach the enemy");
                }
            }
        }
    }

    bool CheckRemaining(List<Character> list)
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

    void Update()
    {
        // while(GameRunning_)
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

            Debug.Log(" ");
            Debug.Log(" ---------- ");

        }else if (Input.GetKeyDown(KeyCode.Space) && !GameRunning_)
        {
            Debug.Log("Game Ended");
        }
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     Debug.Log("Next round");
        //     GameRunning_ = true;
        // }
    }
}
