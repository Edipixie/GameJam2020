using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {
	
	GravityAttractor planet;
	Rigidbody myrigidbody;
	
	void Awake () {
		planet = GameObject.FindGameObjectWithTag("Player").GetComponent<GravityAttractor>();
		myrigidbody = GetComponent<Rigidbody> ();

		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		//myrigidbody.useGravity = false;
		//myrigidbody.constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	void FixedUpdate () {
		// Allow this body to be influenced by planet's gravity
		planet.Attract(myrigidbody);
	}
}