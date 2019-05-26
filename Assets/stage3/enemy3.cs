using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemy3 : MonoBehaviour {
	int numa =0;
	public Text death;

	// Use this for initialization
	void Start () {
		numa = score.getdeathcount();

	}

	// Update is called once per frame
	void Update () {
		death.text = numa.ToString ();

	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("Player")){
			score.die();
			point.conan();
			SceneManager.LoadScene("gameover3");

		}
	}

}