using UnityEngine;
using System.Collections;

public class BaseCharacterClass 
{
	private string characterClassName;
	private string characterClassDescription;

	/**
	 * Character stats.
	 */
	//

	/** Attack priority. */
	private int agility = 1;
	/** The character's HP. */
	private int health = 10;
	/** The strength of a character's magic. */
	private int magic = 1;
	/** The character's defense ability. */
	private int stamina = 1;
	/** The character's attack ability. */
	private int strength = 1;
	

	//allows me to access this variable thats in this base class and either set it or just read it
	//I can get it which is reading it or I can set it which is giving it a value
	public string CharacterClassName
	{
		get{return characterClassName;}
		set{characterClassName = value;}
	}

	public string CharacterClassDescription
	{
		get{return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	

	public int Stamina
	{
		get{return stamina;}
		set{stamina = value;}
	}

	public int Agility
	{
		get{return agility;}
		set{agility = value;}
	}

	public int Strength
	{
		get{return strength;}
		set{strength = value;}
	}

	public int Health
	{
		get{return health;}
		set{health = value;}
	}

	public int Magic
	{
		get{return magic;}
		set{magic = value;}
	}
}
