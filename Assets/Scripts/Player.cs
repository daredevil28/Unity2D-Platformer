using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Inventory inventory;
    public int health;
    public int attackStrength;
    public float invisibilityTimer;
    private bool invisible;
    private SpriteRenderer sr;
    private Color tmp;

    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        tmp = sr.color;
    }

    void Update()
    {
        if (invisibilityTimer > 0)
        {
            tmp.a = 0.2f;
            sr.color = tmp;
            invisibilityTimer -= Time.deltaTime;
        }
        else
        {
            tmp.a = 1f;
            sr.color = tmp;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<ingameItem>();
        if (item)
        {
            if (inventory.AddItem(item.item, 1))
            {
                Destroy(other.gameObject);
            }
        }
    }

    
}
