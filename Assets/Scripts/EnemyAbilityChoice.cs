using UnityEngine;
using System.Collections;

public class EnemyAbilityChoice {

	private int totalPlayerHealth;
	private int playerHealthPercentage;
	private BaseAbility chosenAbility;


	public BaseAbility ChooseEnemyAbility()
	{
		totalPlayerHealth = GameInformation.PlayerHealth;
		playerHealthPercentage = (int)((totalPlayerHealth / 100) * 100);

		if (playerHealthPercentage >= 75) {
			return chosenAbility = new AttackAbility();
				} else if (playerHealthPercentage < 75 && playerHealthPercentage >= 25) {
			return chosenAbility = new AttackAbility();
				} else if (playerHealthPercentage < 25) {
			return chosenAbility = new AttackAbility();
				}
		return chosenAbility = new AttackAbility();
	}


}
