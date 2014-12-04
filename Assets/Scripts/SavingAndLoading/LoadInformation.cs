using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation()
	{
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Strength = PlayerPrefs.GetInt ("STRENGTH");
		GameInformation.Stamina = PlayerPrefs.GetInt ("STAMINA");
		GameInformation.Magic = PlayerPrefs.GetInt ("MAGIC");
		GameInformation.Agility = PlayerPrefs.GetInt ("AGILITY");
		GameInformation.Health = PlayerPrefs.GetInt ("HEALTH");
		/*USE THIS CODE IF WE PUT ITEMS IN THE GAME
		 * if(PlayerPrefs.GetString("EQUIPMENTITEM1") !=null){
		 * GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
		 * }*/

	}
}
