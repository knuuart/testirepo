using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision c){
		rb.AddForce (Vector3.up * 10f, ForceMode.Impulse);
	}
}
