using UnityEngine;
using System.Collections;

public class StatCalculations 
{
	private float enemyStaminaModifier = 0.15f;  //15%
	private float enemyAgilityModifier = 0.15f;  //15%
	private float enemyMagicModifier = 0.1f;  //10%
	private float enemyStrengthModifier = 0.1f;  //10%
	private float enemyHealthModifier = 1;//100%
	private float enemyStatModifier;
	public enum StatType
	{
		STAMINA,
		AGILITY,
		MAGIC,
		STRENGTH,
		HEALTH
	}

	public int CalculateStat(int statVal, StatType statType, int level ,bool isEnemy)
	{
		if (isEnemy) {
						SetModifier ();
						return (statVal + (int)((statVal * statModifier) * level));
				}
		
				
	}

	public void SetModifier(StatType statType)
	{
		if (statType == StatType.STAMINA) 
		{
			statModifier = enemyStaminaModifier;
		}
		
		if (statType == StatType.AGILITY) 
		{
			statModifier = enemyAgilityModifier;
		}
		
		if (statType == StatType.MAGIC) 
		{
			statModifier = enemyMagicModifier;
		}
		
		if (statType == StatType.STRENGTH) 
		{
			statModifier = enemyStrengthModifier;
		}
		
		if (statType == StatType.HEALTH) 
		{
			statModifier = enemyHealthModifier;
		}
	}
	
}
