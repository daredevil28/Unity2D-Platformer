using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Food Item", menuName = "Inventory/Item/Potion")]
public class PotionObject : Item
{
    public int restoreHealthValue;
    public int strengthValue;
    public int invisibilityValue;
    public void Awake()
    {
        type = ItemType.Potion;
    }
}
