using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
    
    // These fields control the movement of the ship
    public float            speed = 30;
    public float            rollMult = -45;
    public float            pitchMult = 30;

	// Declare a new delegate type WeaponFireDelegate
	public delegate void WeaponFireDelegate();
	// Create a WeaponFireDelegate field named fireDelegate.
	public WeaponFireDelegate fireDelegate;

    void Update () {
    	// Pull in information from the Input class
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        
        // Change transform.position basec on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;	
        
        // Rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0f);
		
		// Use the fireDelegate to fire Weapons
		// First, make sure the button is pressed Axis("Jump")
		// Then ensure that fireDelegate isn't null to avoid an error
		if (Input.GetAxis("Jump") == 1 && fireDelegate != null) {
			fireDelegate();
		}

    }
	

	
}
