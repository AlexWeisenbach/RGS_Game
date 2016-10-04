using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	SpriteRenderer sprite;
	public Sprite player_up;
	public Sprite player_down; 
	public Sprite player_left;
	public Sprite player_right;

	public float playerSpeed = 3;
	Vector2 direction;

	BoxCollider2D boxc;
	public LayerMask blocking;


	void Start () {
		sprite = GetComponent<SpriteRenderer>();
		boxc = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
		{
			direction = Vector3.up;
			sprite.sprite = player_up;
			if(Check_wall(direction))
			{
				transform.Translate(Vector3.up * Time.deltaTime * playerSpeed);
			}
			
		}	
		else if(Input.GetKey("d"))
		{
			direction = Vector3.right;
			sprite.sprite = player_right;
			if(Check_wall(direction))
			{
				transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
			}
		}
		else if(Input.GetKey("s"))
		{
			direction = Vector3.down;
			sprite.sprite = player_down;
			if(Check_wall(direction))
			{
				transform.Translate(Vector3.down * Time.deltaTime * playerSpeed);
			}
			
		}
		else if(Input.GetKey("a"))
		{
			direction = Vector3.left;
			sprite.sprite = player_left;
			if(Check_wall(direction))
			{
				transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
			}
			
		}

		if(Input.GetKey("space"))
		{
			boxc.enabled = false;
			RaycastHit2D interact = Physics2D.Raycast(transform.position, direction, blocking);
			boxc.enabled = true;
			if(interact.collider != null && interact.collider.CompareTag("Interactable") && interact.distance <= 1f)
			{
				interact.collider.SendMessage("Activate");
			}
		}

	}

	bool Check_wall(Vector2 d)
	{
		boxc.enabled = false;
		RaycastHit2D r = Physics2D.Raycast(transform.position, d, blocking);
		boxc.enabled = true;
		if(r.transform != null && r.collider.CompareTag("Wall"))
		{
			return r.distance >= .5;
		}
		return true;
	}






}
