using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Item", menuName = "Assets/Items/New Item"), Serializable]
public class ItemTool : BaseItem, IMyItemUsage
{
    public int MaxDurability;
    public int Durability;
    public string HarvestType;
    public int HarvestDamage;
    public int SecondaryDamage;

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public void Break()
    {
        throw new NotImplementedException();
    }
    public void Use()
    {
        Debug.Log($"{Name}, {HarvestType}, {HarvestDamage}, TOOL HAS BEEN USED");
    }
}


