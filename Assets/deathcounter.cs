using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathcounter : MonoBehaviour {

	public Text sannkaku;
	int resultdeathcount;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		resultdeathcount = score.getdeathcount();
		sannkaku.text = "Death:" + resultdeathcount.ToString ();

	}

}
