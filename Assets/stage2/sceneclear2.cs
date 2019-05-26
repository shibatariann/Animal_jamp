using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneclear2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {if (Input.GetKey(KeyCode.N)) {
			SceneManager.LoadScene ("stage3");
		}
		if (Input.GetKey (KeyCode.M)) {
			point.conan ();
			SceneManager.LoadScene ("start");

		}
		
	}
}
