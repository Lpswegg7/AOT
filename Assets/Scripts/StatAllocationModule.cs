using UnityEngine;
using System.Collections;

public class StatAllocationModule 
{
	private string[] statNames = new string[5] {"Stamina","Agility","Magic","Strength","Health"};
	private string[] statDescriptions = new string[5]
	{"Defense Modifier", "Determines who goes first", "Magical damage modifier","Physical damage modifier", "Health modifier"};
	private bool[] statSelections = new bool[5]; 

	private int[] pointsToAllocate = new int[5]; //starting stat values for the chosen class, 
	private int[] baseStatPoints = new int[5]; //starting stat values for the chosen class

	private int availPoints = 5;//amount of points available at the start
	private bool didRunOnce = false;

	public void DisplayStatAllocationModule()
	{
		if (!didRunOnce) 
		{
			RetrieveStatBaseStatPoints ();//only need this to run once so we put it in this if statment
			didRunOnce = true;
		}
		DisplayStatToggleSwitches ();
		DisplayStatIncreaseDecreaseButtons ();

	}

	private void DisplayStatToggleSwitches()
	{
		for (int i = 0; i < statNames.Length; i++) 
		{
			statSelections [i] = GUI.Toggle (new Rect (10, 60 * i + 10, 100, 50), statSelections [i], statNames [i]);
			GUI.Label (new Rect(100,60 * i + 10,50,50),pointsToAllocate[i].ToString());
			if (statSelections [i]) 
			{
								GUI.Label (new Rect (20, 60 * i + 30, 150, 100), statDescriptions [i]);
			}
		}
	}

	private void DisplayStatIncreaseDecreaseButtons(){
		for (int i = 0; i < pointsToAllocate.Length; i++) {
			//The plus minus buttons will only display when you have points to allocate
			if (pointsToAllocate [i] >= baseStatPoints [i] && availPoints > 0) {
				if (GUI.Button (new Rect (200, 60 * i + 10, 50, 50), "+")) {
					pointsToAllocate[i] += 1;//whatever buttons player adds point to the stat
					--availPoints;//takes away from our available poits
								}
			}
			if(pointsToAllocate[i] > baseStatPoints[i]){
				if (GUI.Button (new Rect (260, 60 * i + 10, 50, 50), "-")) {
					pointsToAllocate[i] -=1;
					++availPoints;
					}
			}
		}
	}
	private void RetrieveStatBaseStatPoints()
	{
		BaseCharacterClass cClass = new BaseBrawlerClass (); //setup temporary cClass
		pointsToAllocate [0] = cClass.Stamina;//Storying the stamina from the basebrawler class in the 0 index of our array which we define above
		baseStatPoints [0] = cClass.Stamina;
		pointsToAllocate [1] = cClass.Strength;
		baseStatPoints [1] = cClass.Strength;
		pointsToAllocate [2] = cClass.Magic;
		baseStatPoints [2] = cClass.Magic;
		pointsToAllocate [3] = cClass.Agility;
		baseStatPoints [3] = cClass.Agility;
		pointsToAllocate [4] = cClass.Health;
		baseStatPoints [4] = cClass.Health;
	}



	

}
