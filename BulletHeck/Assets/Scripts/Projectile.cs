using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	// This field would be private, but we want to view it in the Inspector
	public WeaponType    _type;
	SpriteRenderer rend;
	public Rigidbody2D rb;

	// This public property masks the field _type & takes action when it is set
	public WeaponType    type {
		get {
			return( _type );
		}
		set {
			SetType( value );
		}
	}

	public void SetType( WeaponType eType ) {
		// Set the _type
		_type = eType;
		WeaponDefinition def = Main.GetWeaponDefinition( _type );
		rend.material.color = def.projectileColor;
	}

	void Awake(){
		rend = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
