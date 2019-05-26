using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneclear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.N)) {
			SceneManager.LoadScene ("stage2");
		}
		if (Input.GetKey (KeyCode.M)) {
			SceneManager.LoadScene ("start");

		}
	}
}
