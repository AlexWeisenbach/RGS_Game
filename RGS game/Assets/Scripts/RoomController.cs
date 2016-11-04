using UnityEngine;
using System.Collections;

public class RoomController : MonoBehaviour {

	// Use this for initialization
	public GameObject pda;
	public GameObject dialogueBox;

		
	public bool pdaActive = false;
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown("c") && !pdaActive)
		{
			pda.SetActive(true);
			pdaActive = true;
		}	
		else if(Input.GetKeyDown("c") && pdaActive)
		{
			pda.SetActive(false);
			pdaActive = false;
		}*/
	}

	void OpenPDA()
	{
		if(!pdaActive)
		{
			pda.SetActive(true);
			pdaActive = true;
		}
		else if (pdaActive)
		{
			pda.SetActive(false);
			pdaActive = false;
		}
	}

	void OpenCommand()
	{
		GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
		for(int x = 0; x < doors.Length; x++)
		{
			doors[x].SendMessage("Open");
		}
		pdaActive = false;
		//door1top.SendMessage("Open");
		//door1bot.SendMessage("Open");
	}

	void CreateDialogue(string s)
	{
		dialogueBox.transform.parent.gameObject.SetActive(true);
		dialogueBox.SendMessage("Appear", s);
	}

	void VentAtmosphere()
	{
		GameObject[] flames = GameObject.FindGameObjectsWithTag("Fire");
		foreach(GameObject f in flames)
		{
			f.SetActive(false);
		}
		pdaActive = false;
	}

}
