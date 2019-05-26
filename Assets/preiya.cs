using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preiya : MonoBehaviour {
	
	int Jumpcount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Jumpcount == 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 5.5f, 0);
				Jumpcount += 1;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3(-1.5f, 1, -3.48f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3(1.5f, 1, -3.48f);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position = new Vector3(0, 1, -3.48f);
		}
	}
	private void OnCollisionEnter(Collision coll){
		Jumpcount = 0;
	}

}
