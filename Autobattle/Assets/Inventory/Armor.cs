using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    public ArmorType name_;
    public int defense_;
    public int uses_;

    public virtual void Init()
    {
        name_ = ArmorType.none;
        defense_ = 0;
        uses_ = 0;
    }

}

public enum ArmorType {
    lether,
    metal,
    none,
}
