using UnityEngine;
using System.Collections;

public class Ice : MonoBehaviour {


	public GameObject player;

	public float lowerX;
	public float upperX;
	public float lowerY;
	public float upperY;

	Vector2 dir;

	BoxCollider2D collider;

	// Use this for initialization
	void Start () {
		collider = gameObject.GetComponent<BoxCollider2D>();
		Vector2 size = collider.size;
		lowerX = gameObject.transform.position.x - ((size.x/2) * gameObject.transform.lossyScale.x);
		upperX = gameObject.transform.position.x + ((size.x/2) * gameObject.transform.lossyScale.x);
		lowerY = gameObject.transform.position.y - ((size.y/2) * gameObject.transform.lossyScale.y);
		upperY = gameObject.transform.position.y + ((size.y/2) * gameObject.transform.lossyScale.y);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.x > lowerX && player.transform.position.x < upperX && player.transform.position.y > lowerY && player.transform.position.y < upperY)
		{
			//print("got here");
			player.GetComponent<Player>().canMove = false;
			dir = player.GetComponent<Player>().direction;
			player.transform.position = new Vector2(player.transform.position.x + dir.x, player.transform.position.y + dir.y);
		}
		else
		{
			if(player.transform.position.x > lowerX - 1 && player.transform.position.x < upperX + 1 && player.transform.position.y > lowerY - 1 && player.transform.position.y < upperY + 1)
			{
				//print("got here2");
				player.GetComponent<Player>().canMove = true;
			}
		}
	}
}
