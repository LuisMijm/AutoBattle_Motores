
[System.Serializable]
public class Character
{

    public string name_;
    public float health_;
    public int damage_;
    public bool active_;
    public int criticChance_;
    public RangeType range_;
    public Weapon weapon_;
    public Armour armour_;
    public CharacterControler controler_;
    public DamageType damageType_;


    public virtual void OnDeath(){}
}
