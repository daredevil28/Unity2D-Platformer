﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Item", menuName = "Inventory/Item/Health")]
public class HealthObject : Item
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Health;
    }
}