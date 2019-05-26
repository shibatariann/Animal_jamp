using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.M)) {
			SceneManager.LoadScene ("start");
		}
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene ("stage2");
		}
		
	}
}
