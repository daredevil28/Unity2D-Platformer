using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Item", menuName = "Inventory/Inventory")]
public class Inventory : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>(9);
    private InventoryDisplay _inventoryDisplayScript;
    public bool AddItem(Item _item, int _amount)
    {
        _inventoryDisplayScript = GameObject.Find("Inventory").GetComponent<InventoryDisplay>();

        // for (int i = 0; i < Container.Count; i++)
        // {
        //     if (Container[i].item == _item)
        //     {
        //         Container[i].AddAmount(_amount);
        //         _inventoryDisplayScript.UpdateDisplay();
        //         hasItem = true;
        //         break;
        //     }
        // }
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item.name == "Empty")
            {
                Container.RemoveAt(i);
                Container.Insert(i,new InventorySlot(_item, _amount));
                _inventoryDisplayScript.UpdateDisplay();
                return true;
            }
        }
        return false;
    }

    public Item UseItem(int index, Item emptyObject)
    {
        Item item = Container[index].item;
        
        Container.RemoveAt(index);
        Container.Insert(index,new InventorySlot(emptyObject, 1));
        
        return item;
    }
}

[System.Serializable]
public class InventorySlot
{
    public Item item;
    public int amount;

    public InventorySlot(Item _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
    
}