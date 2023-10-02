

[System.Serializable]
public class Character
{
    public string name_;
    public int health_;
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
public enum RangeType {
    short_range,
    mid_range,
    long_range,
    total_range
}