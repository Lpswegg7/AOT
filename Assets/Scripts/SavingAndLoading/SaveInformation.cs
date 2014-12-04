using UnityEngine;
using System.Collections;

public class SaveInformation  {

	public static void SaveAllInformation()
	{
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("AGILITY", GameInformation.Agility);
		PlayerPrefs.SetInt ("MAGIC", GameInformation.Magic);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("HEALTH", GameInformation.Health);

		/* USE THIS CODE IF GAME HAS ITEMS
		if (GameInformation.EquipmentOne != null) 
		{
			PPSerialization.Save("EQUIPMENT1", GameInformation.EquipmentOne);
				}
				*/
		//JUST TO SHOW THAT IT IS WORKING
		Debug.Log("SAVED ALL INFORMATION");

	}
}
