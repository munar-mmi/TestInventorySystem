using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Simple Item", fileName = "NewSimpleItem")]
public class SimpleItem : ScriptableObject
{
    public string itemName, itemDescription;
    public Sprite itemIcon;

    public virtual void AddItem(List<SimpleItem> items)
    {
        if (items.Count < 64)
        {
            items.Add(this);
        }
    }

    public virtual void RemoveItem(List<SimpleItem> items)
    {
        items.Remove(this);
    }
}
