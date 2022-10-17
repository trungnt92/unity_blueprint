using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public enum EffectType
{
    DamageEffect,
    StatusEffect
}

public abstract class BaseEffect
{
	protected Character character;

	public virtual void Apply(Character character)
    {
        this.character = character;
        character.effects.Add(this);
    }

    public virtual void TearDown()
    {
        character.effects.Remove(this);
    }

    public abstract BaseEffect Clone();
}


