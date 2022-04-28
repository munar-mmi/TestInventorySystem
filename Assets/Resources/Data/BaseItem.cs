using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : ScriptableObject
{
    public string itemName = "Item name";
    public string itemDescription = "Item description";
    public Sprite itemIcon = null;

    public virtual void PutToInventory(List<BaseItem> items)
    {
        if (items.Count < 64)
        {
            items.Add(this);
        }
    }

    public virtual void RemoveItemInInventory(List<BaseItem> items)
    {
        items.Remove(this);
    }
}