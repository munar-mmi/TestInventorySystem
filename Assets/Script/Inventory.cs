using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<BaseItem> items;

    public void AddItem(BaseItem item)
    {
        item.PutToInventory(items);
    }

    public void RemoveItem(BaseItem item)
    {
        item.RemoveItemInInventory(items);
    }
}
