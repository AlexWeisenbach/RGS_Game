using UnityEngine;
using System.Collections;

public class WiringPiece_4state : MonoBehaviour {

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
			state = 3;
		else if(state == 3)
			state = 4;
		else if(state == 4)
			state = 1;
	}
}
