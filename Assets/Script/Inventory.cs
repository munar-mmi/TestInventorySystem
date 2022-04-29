using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<SimpleItem> items;

    public void AddItem(SimpleItem item)
    {
        item.AddItem(items);
    }

    public void RemoveItem(SimpleItem item)
    {
        item.RemoveItem(items);
    }
}
