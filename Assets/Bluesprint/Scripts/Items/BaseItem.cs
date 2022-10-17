using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "GameData/ItemData", order = 1)]
public class BaseItem : ScriptableObject
{
    public ItemType itemType;
    public GameObject prefab;
    public Texture2D icon;
    public string itemName;
    public string description;

    public EffectType effectType = EffectType.DamageEffect;

    [SerializeReference]
    public BaseEffect effectData = new DamageEffect();

    private void OnValidate()
    {
        switch (effectType)
        {
            case EffectType.StatusEffect:
                if (effectData == null || (effectData != null && effectData.GetType() != typeof(Statusffect)))
                {
                    effectData = new Statusffect();
                }
                break;

            case EffectType.DamageEffect:
            default:
                if (effectData == null || (effectData != null && effectData.GetType() != typeof(DamageEffect)))
                {
                    effectData = new DamageEffect();
                }
                break;
        }
    }
}

public enum ItemType
{
    None,
    Buff,
    Debuff,
    Bouns
}


