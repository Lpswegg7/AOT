using UnityEngine;
using System.Collections;

public class BasePlayer  
{
	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;

	private int stamina;    //defense modifier
	private int agility;    //determines who goes first in battle
	private int magic;     //magical damage modifier
	private int strength; //physical damage modifier
	private int health;   //health modifier



	/*public string PlayerName
	{
		get{return playerName;}
		set{playerName = value;}
	}*/
	//Short hand of the code above
	public string PlayerName{ get; set; }

	public int PlayerLevel{ get; set; }


	public BaseCharacterClass PlayerClass{ get; set; }
	
	public int Stamina{ get; set; }
	public int Magic{ get; set; }
	public int Agility{ get; set; }	
	public int Health{ get; set; }	
	public int Strength{ get; set; }



}
