using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinhyouzi : MonoBehaviour {
	
	public Text samii;

	// Use this for initialization
	void Start () {
		int resultcoincount = point.getcoincount();
		Debug.Log ("get" + point.getcoincount ());
		Debug.Log ("re" + resultcoincount);
		samii.text = ("coin:" + resultcoincount.ToString() + "/5" );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
