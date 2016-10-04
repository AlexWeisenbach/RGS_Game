using UnityEngine;
using System.Collections;

public class Interaction_Text : MonoBehaviour {

	// Use this for initialization
	public GameObject roomManager;
	public string text;
	bool checkable;
	void Start () {
		checkable = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Activate()
	{
		//print("Activate called");
		if(checkable)
		{
			roomManager.SendMessage("CreateDialogue", text);
			checkable = false;
		}
	}
}
