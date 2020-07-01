using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Item", menuName = "Inventory/Item/Default")]
public class ItemObject : Item
{
    public void Awake()
    {
        type = ItemType.Default;
    }
}
