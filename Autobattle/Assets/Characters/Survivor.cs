

public class Survivor : Character
{
    public SurvivorType type_;

    public override void Init()
    {

    }

}

public enum SurvivorType {
    Tank,
    Melee,
    Archer,
    Medic,
    total
}