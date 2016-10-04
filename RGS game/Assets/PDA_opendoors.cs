using UnityEngine;
using System.Collections;

public class PDA_opendoors : MonoBehaviour {

	// Use this for initialization
	public GameObject roomManager;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		roomManager.SendMessage("OpenCommand");
		transform.parent.gameObject.SetActive(false);
	}
}
