using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    None, Bullet
}

public class Inventory
{
    public List<Item> items = new List<Item>();
}

public class Item
{
    public ItemType itemType;
    public int number;

    public Item(ItemType itemType, int number = 1)
    {
        this.itemType = itemType;
        this.number = number;
    }

    public bool Use(int n = 1)
    {
        if (CanUse(n))
        {
            number -= n;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CanUse(int n = 1)
    {
        return number - n > 0;
    }
}

//TODO
//public class Bullet : Item
//{
//    public Bullet(ItemType itemType, int number = 1) : base(itemType, number)
//    {
//        this.itemType = itemType;
//        this.number = number; 
//    }
//}
