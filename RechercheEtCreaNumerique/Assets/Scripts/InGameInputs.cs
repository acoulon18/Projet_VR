using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInputs : MonoBehaviour {
	public GameObject character;
	// Use this for initialization
	void Start () {
		character = GameObject.Find("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void UseGrapple(GameObject objectGrappled){
		float dist = Vector3.Distance(character.transform.position, objectGrappled.transform.position) - 1f;
		character.transform.position = Vector3.MoveTowards(character.transform.position, objectGrappled.transform.position, dist);
		//character.transform.position = Vector3.Lerp(character.transform.position, objectGrappled.transform.position, 1f);
	}	

}
