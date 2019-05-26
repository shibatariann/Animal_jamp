using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class warp : MonoBehaviour {

	int numa =0;
	public Text death;

	int warpcount = 0;
	// Use this for initialization
	void Start () {
		numa = score.getdeathcount();

	}

	
	// Update is called once per frame
	void Update () {
		death.text = numa.ToString ();
		}
			
	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Player")) {
			warpcount += 1;
			if (warpcount == 1) {
				transform.position += new Vector3 (-1.5f, 0, -6);

			}
			if (warpcount == 2) {
				score.die ();
				SceneManager.LoadScene ("gameover3");
}
		}
	}
}
