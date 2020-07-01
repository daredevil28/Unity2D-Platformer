using UnityEngine;
[CreateAssetMenu(fileName = "New Strength Item", menuName = "Inventory/Item/Strength")]
public class StrengthObject : Item
{
    public int strengthValue;
    public void Awake()
    {
        type = ItemType.Strength;
    }
}