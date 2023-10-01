

[System.Serializable]
public class Character
{
    public string name_;
    public int health_;
    public int damage_;
    public bool active_;
    public RangeType range_;

    public virtual void OnDeath()
    {
        
    }
    
}
public enum RangeType {
    short_range,
    mid_range,
    long_range,
    total_range
}