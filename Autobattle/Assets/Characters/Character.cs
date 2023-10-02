

[System.Serializable]
public class Character
{
    public string name_;
    public float health_;
    public int damage_;
    public bool active_;
    public RangeType range_;
    public DamageType damageType_;
    public Weapon weapon;
    public Armor armor;
    public int criticChance_;


    public virtual void OnDeath()
    {
        
    }

    public virtual void Init()
    {

    }
    
}
