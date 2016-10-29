using UnityEngine;
using System.Collections;

public class Fog : MonoBehaviour {

	// Use this for initialization
	public GameObject screen;
	public GameObject player;

	public float lowerX;
	public float upperX;
	public float lowerY;
	public float upperY;
	BoxCollider2D collider;
	
	void Start () {
		collider = gameObject.GetComponent<BoxCollider2D>();
		Vector2 size = collider.size;
		lowerX = gameObject.transform.position.x - ((size.x/2) * gameObject.transform.lossyScale.x) - 1;
		upperX = gameObject.transform.position.x + ((size.x/2) * gameObject.transform.lossyScale.x) + 1;
		lowerY = gameObject.transform.position.y - ((size.y/2) * gameObject.transform.lossyScale.y) - 1;
		upperY = gameObject.transform.position.y + ((size.y/2) * gameObject.transform.lossyScale.y) + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.x > lowerX && player.transform.position.x < upperX && player.transform.position.y > lowerY && player.transform.position.y < upperY)
		{
			//print("got here");
			screen.SetActive(false);
		}
		else
		{
			//print("got here2");
			screen.SetActive(true);
		}
	}
}
