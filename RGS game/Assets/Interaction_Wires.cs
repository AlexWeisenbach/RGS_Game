using UnityEngine;
using System.Collections;

public class Interaction_Wires : MonoBehaviour {

	// Use this for initialization
	public GameObject wireToActivate;
	public GameObject wireToDeactivate;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Activate()
	{
		wireToActivate.SetActive(false);
		wireToDeactivate.SetActive(true);
	}
}
