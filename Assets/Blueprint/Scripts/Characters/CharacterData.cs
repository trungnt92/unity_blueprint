using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "GameData/CharacterData", order = 1)]
public class CharacterData : ScriptableObject
{
	public int hp;
	public int mp;
	public int armor;
	public int atk;

	public Character CreateCharacter()
    {
		var newChar = new Character();
		newChar.hp = this.hp;
		newChar.mp = this.mp;
		newChar.armor = this.armor;
		newChar.atk = this.atk;
		return newChar;
    }
}