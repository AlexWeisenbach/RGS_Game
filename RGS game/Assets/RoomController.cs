using UnityEngine;
using System.Collections;

public class RoomController : MonoBehaviour {

	// Use this for initialization
	public GameObject pda;
	public GameObject dialogueBox;
		
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("c"))
		{
			pda.SetActive(true);
		}	
	}

	void OpenCommand()
	{
		GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
		for(int x = 0; x < doors.Length; x++)
		{
			doors[x].SendMessage("Open");
		}
		//door1top.SendMessage("Open");
		//door1bot.SendMessage("Open");
	}

	void CreateDialogue(string s)
	{
		dialogueBox.transform.parent.gameObject.SetActive(true);
		dialogueBox.SendMessage("Appear", s);
	}

}
