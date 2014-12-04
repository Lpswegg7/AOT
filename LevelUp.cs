using UnityEngine;
using System.Collections;

public class LevelUp  
{
	public int maxPlayerLevel = 50;
	public void LevelUpCharacter()
	{
		//Check to see if curret xp > than required xp
		if (GameInformation.CurrentXP > GameInformation.RequiredXP) 
		{
			GameInformation.CurrentXP -= GameInformation.RequiredXP;
		} 

		else 
		{
			GameInformation.CurrentXP = 0;
		}

		if (GameInformation.PlayerLevel < maxPlayerLevel) 
		{
			GameInformation.PlayerLevel += 1;
		} 

		else 
		{
			GameInformation.PlayerLevel = maxPlayerLevel;

		}
				
		//give the player stat points
				//randomly decide to give up items
				//give them a move or ability
				//give money
				//determine the next amount of required xp
	}

	private void DeterminRequiredXP()
	{
		int temp = (GameInformation.PlayerLevel * 1000) + 250;
		GameInformation.RequiredXP = temp;
	}

	/*
	private int DetermineXPForNextLevel(int playerLevel)
	{
				playerLevel += 1;
				int levels = 50;
				float xpLevel1 = 500.0f;
				float xpLevel150 = 400000.0f;
				float temp1 = Mathf.LogType (xpLevel150 / xpLevel1);
				float b = temp1 / (levels - 1);
				float temp2 = (MathfExp (b) - 1);
				float a = (xpLevel1) / temp2;
				int oldxp = (int)(a * Mathf.Exp ((float)b * (playerLevel - 1)));
				int newxp = (int)(a * Mathf.Exp ((float)b * (playerLevel)));
				int temp = newxp - oldxp;
				temp = (int)Mathf.Round ((float)temp / 10.0f) * 10;
				return temp;
	}
	*/

	/*
	//IF I WANT TO ADD MONEY
	private void DetermineMoneyToGive()
	{
		if (GameInformation.PlayerLevel <= 10) 
		{
						//give a certain amount of money
		}
	}
	*/
}
