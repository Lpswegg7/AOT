using UnityEngine;
using System.Collections;

public class TsetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		Debug.Log ("Player Name:" + GameInformation.PlayerName);
		Debug.Log ("Player Level: " + GameInformation.PlayerLevel);
		//Debug.Log ("Player Class:" + GameInformation.PlayerClass.CharacterClassName);
		Debug.Log ("Player Level" + GameInformation.PlayerLevel);
		Debug.Log ("Player Stamina" + GameInformation.Stamina);
		Debug.Log ("Player Agility" + GameInformation.Agility);
		Debug.Log ("Player Magic" + GameInformation.Magic);
		Debug.Log ("Player Strength" + GameInformation.Strength);
		Debug.Log ("Player Health" + GameInformation.Health);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
