using UnityEngine;
using System.Collections;

public class ItemsManager : MonoBehaviour
{
    public ItemsData itemsData;
    public GameObject itemParent;

    private void Awake()
    {
        SpawnItems(10);
    }

    void SpawnItems(int numItems)
    {
        for (int i = 0; i < numItems; i++)
        {
            var item = itemsData.GetRandomItem();
            var pos = RandomPos();
            var newItem = Instantiate(item.prefab, pos, item.prefab.transform.rotation, itemParent.transform);
            var effectCmp = newItem.AddComponent<EffectComponent>();
            effectCmp.effect = item.effectData.Clone();
        }
    }

    Vector3 RandomPos()
    {
        var y = 0.5f;
        var x = Random.Range(-21, 21);
        var z = Random.Range(-21, 21);
        return new Vector3(x, y, z);
    }
}

