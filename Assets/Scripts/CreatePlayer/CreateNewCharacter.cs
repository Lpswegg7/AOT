using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isKnightClass;
	private bool isBrawlerClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () 
	{
		newPlayer = new BasePlayer ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
				playerName = GUILayout.TextArea (playerName, 10);
				isKnightClass = GUILayout.Toggle (isKnightClass, "Knight Class");
				isBrawlerClass = GUILayout.Toggle (isBrawlerClass, "Brawler Class");
				if (GUILayout.Button ("Create")) {
						if (isKnightClass) {
								newPlayer.PlayerClass = new BaseKnightClass ();
						} else if (isBrawlerClass) {
								newPlayer.PlayerClass = new BaseBrawlerClass ();
						}

			CreateNewPlayer();
			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();
						

				}
		//Load a new scene
				if (GUILayout.Button ("Load")) {
						Application.LoadLevel ("tset");
				}

	}

	//When we hit the create button it will save all the information in the GameInformation Script
	private void StoreNewPlayerInfo()
	{
		GameInformation.PlayerName = newPlayer.PlayerName; 
	    GameInformation.PlayerLevel = newPlayer.PlayerLevel; 
		GameInformation.Stamina = newPlayer.Stamina; 
		GameInformation.Magic = newPlayer.Magic; 
		GameInformation.Strength = newPlayer.Strength; 
		GameInformation.Agility = newPlayer.Agility;
		GameInformation.Health = newPlayer.Health;

	}

	private void CreateNewPlayer()
	{
		newPlayer.PlayerLevel = 1;
		newPlayer.Health = newPlayer.PlayerClass.Health;
		newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Magic = newPlayer.PlayerClass.Magic;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.PlayerName = playerName;
		Debug.Log ("Player Name: " + newPlayer.PlayerName);
		Debug.Log ("Player Class:" + newPlayer.PlayerClass.CharacterClassName);
		Debug.Log ("Player Level" + newPlayer.PlayerLevel);
		Debug.Log ("Player Stamina" + newPlayer.Stamina);
		Debug.Log ("Player Agility" + newPlayer.Agility);
		Debug.Log ("Player Magic" + newPlayer.Magic);
		Debug.Log ("Player Strength" + newPlayer.Strength);
		Debug.Log ("Player Health" + newPlayer.Health);
}
}
