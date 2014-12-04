using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	//Same as Start, but starts before Start
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	//public static bool IsMale{ get; set;}
	//public static string PlayerBio{ get; set;}
	public static string PlayerName { get; set;}
	public static int PlayerLevel { get; set;}
	public static BaseCharacterClass PlayerClass { get; set;}
	public static int Stamina { get; set;}
	public static int Agility { get; set;}
	public static int Magic { get; set;}
	public static int Strength { get; set;}
	public static int Health { get; set;}
	//public static int Overpower{ get;set:}
	public static int CurrentXP { get; set;}
	public static int RequiredXP { get; set;}
}
