using UnityEngine;
using System.Collections;

public class BaseKnightClass : BaseCharacterClass 
{
	public BaseKnightClass()
	{
		CharacterClassName = "Knight";
		CharacterClassDescription = "A strong defender of the weak.";
		MainStat = MainStatBonuses.STAMINA;
		SecondMainStat = SecondStatBonuses.HEALTH;
		BonusStat = BonusStatBonuses.STRENGTH;
	}
}


