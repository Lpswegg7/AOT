using UnityEngine;
using System.Collections;

public class BattleStateStart 
{
	private BasePlayer newEnemy = new BasePlayer();//will change to BaseEnemy later
	private StatCalculations statCalcationsScript = new StateCalculations ();
	private BaseCharacterClass[] classTypes = new BaseCharacterClass[]
	{
		new BaseKnightClass(), new BaseBrawlerClass()
	};
	private string[] enemyNames = new string[] {"Dealy Enemy","Fierce Enemy","Subtle Enemy","Powerful Enemy"};
	private int playerStamina;
	private int playerAgility;
	private int playerMagic;
	private int playerStrength;
	private int playerHealth;


	public void PrepareBattle()
	{
		//create enemy
		CreateNewEnemy ();
		//choose who goes first based on luck
	}


	private void CreateNewEnemy()
	{
		newEnemy.PlayerName = enemyNames[Random.Range (0,enemyNames.Length+1)];
		newEnemy.PlayerLevel = Random.Range (GameInformation.PlayerLevel - 2, GameInformation.PlayerLevel + 2);
		newEnemy.PlayerClass = classTypes[Random.Range (0, classTypes.Length+1)];  //randomly chooses class out of the array above
		newEnemy.Stamina = statCalculationsScript.CalculateStat (newEnemy.Stamina, StatCalculations.StatType.STAMINA, newEnemy.PlayerLevel,true);
		newEnemy.Agility = statCaculationsScript.CalculateStat (newEnemy.Agility, StatCalculations.StatType.AGILITY, newEnemy.PlayerLevel, true);
		newEnemy.Magic = statCaculationsScript.CalculateStat (newEnemy.Magic, StatCalculations.StatType.MAGIC, newEnemy.PlayerLevel,true);
		newEnemy.Strength = statCaculationsScript.CalculateStat (newEnemy.Strength, StatCalculations.StatType.STRENGTH, newEnemy.PlayerLevel,true);
		newEnemy.Health = statCaculationsScript.CalculateStat (newEnemy.Health, StatCalculations.StatType.HEALTH, newEnemy.PlayerLevel,true);
	}

	private void ChooseWhoGoesFirst()
	{
		if (GameInformation.Agility >= newEnemy.Agility) {
			//player goes first
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
				}
		if (GameInformation.Agility < newEnemy.Agility) {
			//enemy is going to go first
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
				}
		//if (GameInformation.Agility == newEnemy.Agility) {
		//    CAN DECIDE IF I WANT THIS LATER
		//		}
	}

	private void DeterminePlayerVitals()
	{
		playerStamina = statCalcationsScript.CalculateStat (GameInformation.Stamina, StatCalculations.StatType.STAMINA, GameInformation.PlayerLevel, false);
		playerMagic = statCalcationsScript.CalculateStat (GameInformation.Magic, StatCalculations.StatType.MAGIC, GameInformation.PlayerLevel, false);
		playerHealth = statCalcationsScript.CalculateHeal (playerStamina);//we are calculating our health
		playerMagic = statCalcationsScript .CalculateEnergy (playerMagic);//we are calculating our energy
		GameInformation.PlayerHealth = playerHealth;
		GameInformation.PlayerEnergy = playerMagic;
	}
}