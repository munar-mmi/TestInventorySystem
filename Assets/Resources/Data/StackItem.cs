using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Stack Item", fileName = "NewStackItem")]
public class StackItem : SimpleItem
{
    public int stackSize;

    public override void AddItem(List<SimpleItem> items)
    {
        if (items.Contains(this))
        {
            RaiseStack();
        }
        else
        {
            items.Add(this);
        }
    }

    public override void RemoveItem(List<SimpleItem> items)
    {
        if (items.Contains(this))
        {
            ReduceStack();
            if (stackSize <= 0)
            {
                stackSize = 1;
                items.Remove(this);
            }
        }
    }

    public void RaiseStack()
    {
        stackSize++;
    }

    public void ReduceStack()
    {
        stackSize--;
    }
}
