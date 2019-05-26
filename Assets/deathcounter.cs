using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathcounter : MonoBehaviour {

	public Text sannkaku;


	// Use this for initialization
	void Start () {
		int resultdeathcount = score.getdeathcount();
		sannkaku.text = ("Death:" + resultdeathcount.ToString ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
