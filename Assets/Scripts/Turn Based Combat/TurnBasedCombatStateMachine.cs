using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour 
{
	private bool hasAddedXP = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		CALCMDAMAGE,
		ADDSTATUSEFFECTS,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleStates currentState;


	// Use this for initialization
	void Start () 
	{
		hasAddedXP = false;
		totalTurnCount = 1;
		currentState = BattleStates.START;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//DISPLAY CURRENT STATE
		Debug.Log (currentState);
		switch (currentState) 
		{
		case (BattleStates.START):
			//SETUP BATTLE FUNCTION
			//create enemy
			battleStateStartScript.PrepareBattle();
			//choose who goes first based on agility
				break;
		case (BattleStates.PLAYERCHOICE):  //player chooses the ability they want to use
			break;
		case (BattleStates.ENEMYCHOICE):
			//coded AI goes here
			battleStateEnemyChoiceScript.EnemyCompleteTurn();
			//enemyDidCompleteTurn = true;
			//CheckWhoGoesNext();
			break;
		case (BattleStates.CALCMDAMAGE):  //we calculate damage done by player, look for exisiting status effects and add that damage
			battleCalcScript.CalculateTotalPlayerDamage(playerUsedAbility);
			checkWhoGoesNext();
			break;
		case (BattleStates.ADDSTATUSEFFECTS):  //we try to add a status effect if it exisits
			battleStateAddStatusEffectsScript.CheckAbilityForStatusEffects(playerUsedAbility);
			break;
		case(BattleStates.ENDTURN):
			totalTurnCount += 1;
			playerDidCompleteTurn = false;
			enemyDidCompleteTurn = false;
			Debug.Log (totalTurnCount);
			break;
		case (BattleStates.LOSE):
			break;
		case (BattleStates.WIN):
			if(!hasAddedXP)
			{
				IncreaseExperience.AddExperience();
				hasAddedXP = true;
			}
			break;
				
		}
	}

	void OnGUI()
	{
		if (GUILayout.Button("NEXT STATE")) 
		{
			if(currentState==BattleStates.START)
			{
				currentState = BattleStates.PLAYERCHOICE;
			}

			else if(currentState==BattleStates.PLAYERCHOICE)
			{
				currentState = BattleStates.ENEMYCHOICE;
			}

			else if(currentState==BattleStates.ENEMYCHOICE)
			{
				currentState = BattleStates.LOSE;
			}

			else if(currentState==BattleStates.LOSE)
			{
				currentState = BattleStates.WIN;
			}

			else if(currentState==BattleStates.WIN)
			{
				currentState = BattleStates.START;
			}
	}
}
}
