using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerController : MonoBehaviour {
	bool grappleEnabled;
	GameObject objectGrappled;
	// Use this for initialization
	void Start () {
		grappleEnabled = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire2")) {
			if (grappleEnabled)
			{
				GameObject.Find("Controller").BroadcastMessage("UseGrapple", objectGrappled);
			}
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "CibleGrappin")
		{
			grappleEnabled = true;
			objectGrappled = other.gameObject;
		}
	}
	void OnTriggerExit (Collider other) {
		if (other.tag == "CibleGrappin")
		{
			grappleEnabled = false;
		}
	}
			
}
