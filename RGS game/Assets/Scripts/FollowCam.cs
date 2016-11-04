using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
	}
}
