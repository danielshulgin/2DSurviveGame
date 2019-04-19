using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeneger : MonoBehaviour
{
    public Stats stats = new Stats();
    public Inventory inventory = new Inventory();

    void Start()
    {
        inventory.items.Add(new Item(ItemType.bullet, 20));    
    }
}
