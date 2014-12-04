using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour 
{
	private BaseCharacterClass class1;

	void Start(){
				class1 = new BaseBrawlerClass ();
				Debug.Log (class1.CharacterClassName);
				Debug.Log (class1.CharacterClassDescription);
				Debug.Log (class1.MainStat);
				Debug.Log (class1.SecondMainStat);
				Debug.Log (class1.BonusStat);
		}


	/*private BaseCharacterClass class1 = new BaseKnightClass();
	private BaseBrawlerClass class2 = new BaseBrawlerClass ();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.Stamina.ToString());
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.Strength.ToString ());
	}*/
}
