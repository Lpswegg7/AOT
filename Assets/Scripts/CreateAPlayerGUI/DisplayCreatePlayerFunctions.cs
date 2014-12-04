using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[]{"Knight", "Brawler","A","b","c","d"};

	public void DisplayClassSelections(){
		//A list of toggle buttons and each button will be a different class
		//selection grid
		classSelection = GUI.SelectionGrid(new Rect(50,50,250,300), classSelection, classSelectionNames, 2);
		GUI.Label (new Rect(450,50,300,300), FindClassDescription(classSelection));
		GUI.Label (new Rect(450,100,300,300), FindClassStatValues(classSelection));
		}

	private string FindClassDescription(int classSelection){
		if (classSelection == 0) {
						BaseCharacterClass tempClass = new BaseKnightClass ();
						return tempClass.CharacterClassDescription;
				} else if (classSelection == 1) {
						BaseCharacterClass tempClass = new BaseBrawlerClass ();
						return tempClass.CharacterClassDescription;
				}
			return "Hey";
		}

	private string FindClassStatValues(int classSelection){
				if (classSelection == 0) {
						BaseCharacterClass tempClass = new BaseKnightClass ();
						string tempStats = "Stamina" + tempClass.Stamina + "\n" + "Agility" + tempClass.Agility;
						return tempStats;
				} else if (classSelection == 1) {
						BaseCharacterClass tempClass = new BaseBrawlerClass ();
						string tempStats = "Stamina" + tempClass.Stamina + "\n" + "Agility" + tempClass.Agility;
						return tempStats;
				}
				return "No Stats Found";
		}

	public void DisplayStatAllocation(){
		//a list of stats with plus and minus buttons to add stats 
		//locgic to make sure the player cannot add more than stats given


	}

	public void DisplayFinalSetup(){
		//name
		//gender
		//add a description to your character, a short bio

	}

	public void DisplayMainItems(){
		GUI.Label (new Rect (Screen.width / 2, 20, 250, 250), "CREATE NEW PLAYER");
	}


}
