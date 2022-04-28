using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Stack Item", fileName = "NewStackItem")]
public class StackItem : BaseItem
{
    public int StackCount;

    public override void PutToInventory(List<BaseItem> items)
    {
        while (StackCount > 0)
        {
            foreach (StackItem item in items)
            {
                if (item.GetType() == GetType() & item.itemName == itemName & item.StackCount < 64)
                {
                    item.StackCount += StackCount;
                    StackCount = 0;

                    if(item.StackCount > 64)
                    {
                        StackCount = item.StackCount % 64;
                        item.StackCount -= StackCount;
                    }
                    else
                    {
                        break;
                    }
                }
            if (StackCount > 0)
            {
                items.Add(this);
            }
            break;
            }
        }
    }
}
