using UnityEngine;

    [CreateAssetMenu(fileName = "New Invisibility Item", menuName = "Inventory/Item/Invisibility")]
    public class InvisibilityObject : Item
    {
        public int invisibilityTimer;
        
        public void Awake()
        {
            type = ItemType.Invisibility;
        }
    }
