using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryDisplay : MonoBehaviour
{
    public Inventory inventory;

    private GameObject[] _inventorySlots;
    private GameObject[] _inventoryIcons;
    private Player playerScript;

    public Item defaultObject;
    // Start is called before the first frame update
    void Start()
    {
        _inventorySlots = GameObject.FindGameObjectsWithTag("InventorySlot");
        _inventoryIcons = GameObject.FindGameObjectsWithTag("InventoryIcon");
        playerScript = GameObject.Find("Character").GetComponent<Player>();
        UpdateDisplay();
        
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < 9; i++)
        {
            if (inventory.Container[i].item.name != "Empty")
            {
                _inventoryIcons[i].GetComponent<Image>().sprite = inventory.Container[i].item.sprite;
            }
            else
            {
                _inventoryIcons[i].GetComponent<Image>().sprite = null;
            }
            
            Debug.Log("Completed");
        }
    }
    public void UseItem(int index)
    {
       Item item = inventory.UseItem(index, defaultObject);
       switch (item.type)
       {
           case ItemType.Health:
               var health = item as HealthObject;
               playerScript.health += health.restoreHealthValue;
               break;
           case ItemType.Invisibility:
               var invis = item as InvisibilityObject;
               playerScript.invisibilityTimer += invis.invisibilityTimer;
               break;
           case ItemType.Strength:
               var strength = item as StrengthObject;
               playerScript.attackStrength += strength.strengthValue;
               break;
       }

       UpdateDisplay();
    }
}
