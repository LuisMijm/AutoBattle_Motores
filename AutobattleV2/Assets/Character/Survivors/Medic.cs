using UnityEngine;


public class Medic : Survivor
{
    public MainScript mc_;
    int healAmount_;

    public Medic()
    {
        Init();
    }

    public override  void Init()
    {
        // base.Init();
        name_ = "Medic";
        health_ = Random.Range(5, 15);
        damage_ = Random.Range(5, 15);
        range_ = RangeType.mid_range;
        active_ = true;
        if(weapon_ == null)
        {
            weapon_ = new Weapon();
        }
        weapon_.Init();
    }

    void Start()
    {
        GameObject mainObj = GameObject.Find("MainObj");
        mc_ = mainObj.GetComponent<MainScript>();
        
        healAmount_ = 5;
    }

    void Update()
    {
        if(active_)
        {
            foreach (Character survivor in mc_.survivorList_){
                if(survivor.active_)
                {
                    survivor.health_ += healAmount_;
                }
            }

            Debug.Log("A medic patched up all survivors");
        }
    }
}
