using UnityEngine;

public enum ItemType {
Potion,
Health,
Invisibility,
Strength,
Default
}

public abstract class Item : ScriptableObject
{
    public new string name = "New Item";
    public Sprite sprite;
    public ItemType type;
}
