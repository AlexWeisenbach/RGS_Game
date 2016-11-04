using UnityEngine;
using System.Collections;

public class WiringPiece : MonoBehaviour {

	// Use this for initialization
	public int state; 
	public int startState;
	void Start () {
		state = startState;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		gameObject.transform.Rotate(0f,0f, -90f);
		if(state == 1)
			state = 2;
		else if(state == 2)
			state = 1;
	}
}
