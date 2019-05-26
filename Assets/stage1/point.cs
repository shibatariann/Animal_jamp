using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour {
		public static int coincount = 0;
		public static int getcoincount(){
			return coincount;
		}
		public static void coin (){
			coincount += 1;
		}
	public static void conan (){
		coincount = 0;
		}
		// Use this for initialization
		void Start () {

		}


}
