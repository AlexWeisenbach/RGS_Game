using UnityEngine;
using System.Collections;

public class Interaction_PDA : MonoBehaviour {

	public GameObject roomManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Activate()
	{
		roomManager.SendMessage("OpenPDA");
	}
}
