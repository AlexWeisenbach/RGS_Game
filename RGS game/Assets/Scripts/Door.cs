using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	public Vector3 open_position;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Open()
	{
		transform.position = open_position;
	}
}
