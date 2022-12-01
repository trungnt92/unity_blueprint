 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsData", menuName = "GameData/ItemsData", order = 1)]
public class ItemsData : ScriptableObject
{
    public List<BaseItem> allItems;

    public BaseItem GetRandomItem()
    {
        var idx = Random.Range(0, allItems.Count);
        return allItems[idx];
    }
}
