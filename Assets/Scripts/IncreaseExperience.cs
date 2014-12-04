using UnityEngine;
using System.Collections;

public static class IncreaseExperience 
{
	private static int xpToGive;

	//create new instance of the level up class, which is being cached into this levelUp variable
	private static LevelUp levelUpScript = new LevelUp();

	//created a static fuction that will add experience to the player
	public static void AddExperience()
	{
		xpToGive = GameInformation.PlayerLevel * 100; //Whatever our player level is times 100 will give us our experience gain
		GameInformation.CurrentXP += xpToGive; //we are going to add xpToGive value to the GameInformation
		CheckToSeeIFPlayerLeveled();

		Debug.Log (xpToGive);
	}

	/*IF WE WANT TO GIVE XP FOR FINDING AN AREA
	 * public static void AddExplorationExperience()
	 * {
	 * 
	 * }
	 **/

	public static void AddExperienceFromBattleLoss()
	{
		xpToGive = GameInformation.PlayerLevel * 10;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIFPlayerLeveled();

		Debug.Log (xpToGive);
	}

	private static void CheckToSeeIFPlayerLeveled()
	{
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) 
		{
			//then the player has leveled up
			levelUpScript.LevelUpCharacter();//now we can call our level up script and access anything that is public in that class
			//CREATE LEVEL UP SCRIPT
			
		}
	}

}
