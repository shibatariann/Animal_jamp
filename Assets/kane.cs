using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class kane : MonoBehaviour {


	//int ashi = 0;
	//public Text cuin;
	// Use this for initialization
	void Start () {
		//ashi = point.getcoincount();
	}
	
	// Update is called once per frame
	void Update () {
		//cuin.text = ashi.ToString ();
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.CompareTag("Player")){
			point.coin();
			Debug.Log ("get" + point.getcoincount ());
			Destroy (this.gameObject);
		}
	}
		
}
