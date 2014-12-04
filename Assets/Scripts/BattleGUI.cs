using UnityEngine;
using System.Collections;

public class BattleGUI : MonoBehaviour {

	private string playerName;
	private int playerLevel;
	private int playerHealth;
	//private int playerEnergy;


	// Use this for initialization
	void Start () {
		playerName = GameInformation.PlayerName;
		playerLevel = GameInformation.PlayerLevel;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		//we need buttons for player moves
		//we need to show enemy health and other enemy info
		//we need to show player information
	}
}
