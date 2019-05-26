using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {


	public Text samii;

	// Use this for initialization
	void Start () {
		int resultcoincount = point.getcoincount ();
		samii.text = ("coin:" + resultcoincount.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
