using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
	public static int deathcount = 0;
	public static int getdeathcount(){
		return deathcount;
	}
	public static void die (){
		deathcount += 1;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
