using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Character
{
	public int hp;
	public int mp;
	public int armor;
	public int atk;

	public List<BaseEffect> effects = new List<BaseEffect>();
}

[Serializable]
public enum CharacterStat
{
	Hp,
	Mp,
	Armor,
	Atk
}