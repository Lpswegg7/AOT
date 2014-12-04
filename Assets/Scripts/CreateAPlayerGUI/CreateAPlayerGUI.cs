using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates{
		CLASSSELECTION, //display all class types
		STATALLOCATION, //allocate stats where the layer wants to
		FINALSETUP //add name and misc items
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions ();
	public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;
	
	}
	
	// Update is called once per frame
	void Update () {
		switch(currentState){
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
	
	}
}
	void onGUI(){
		displayFunctions.DisplayMainItems ();
		if(currentState == CreateAPlayerStates.CLASSSELECTION){
			//Displayer class selection function
			displayFunctions.DisplayClassSelections();
		}

		if(currentState == CreateAPlayerStates.STATALLOCATION){
			//Displayer class selection function
			displayFunctions.DisplayStatAllocation();
		}

		if(currentState == CreateAPlayerStates.FINALSETUP){
			//Displayer class selection function
			displayFunctions.DisplayFinalSetup();
		}
	}
}
