using UnityEngine;
using System.Collections;

public class BaseBrawlerClass : BaseCharacterClass 
{
	public BaseBrawlerClass()
	{
		CharacterClassName = "Brawler";
		CharacterClassDescription = "A strong and powerful hero.";
		MainStat = MainStatBonuses.STRENGTH;
		SecondMainStat = SecondStatBonuses.AGILITY;
		BonusStat = BonusStatBonuses.HEALTH; 

	}

}
