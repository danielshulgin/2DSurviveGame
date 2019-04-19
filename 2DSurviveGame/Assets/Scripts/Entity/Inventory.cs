using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    none, bullet
}

public class Inventory
{
    public List<Item> items = new List<Item>();
}

public class Item
{
    public ItemType itemType = ItemType.none;
    public int number = 0;

    public Item(ItemType itemType, int number)
    {
        this.itemType = itemType;
        this.number = number;
    }
}
