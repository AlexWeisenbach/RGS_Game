using UnityEngine;
using System.Collections;

public class PDA_ventatmos : MonoBehaviour {

	// Use this for initialization
	public GameObject roomManager;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		roomManager.SendMessage("VentAtmosphere");
		transform.parent.gameObject.SetActive(false);
	}
}
