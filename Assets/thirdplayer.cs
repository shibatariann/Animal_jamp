using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdplayer : MonoBehaviour {
	int l_num = 2;
	int Jumpcount = 0;

	　　// Use this for initialization
	　　void Start () {
		　　//初めは真ん中スタート！
		　　transform.position += new Vector3(0, 0, 5.6f*Time.deltaTime);
		　　}

	　　void Update(){
		　　/*初めに，今自分がどこにいるのかを見つけ，そのあとにどこに移動したいのかを推したキーによって判断させる．ほかのところに移動しても，1フレーム分しか移動しないので，ずっと横に移動し続けるということはない*/
		　　　　if (l_num == 1) { //rightにいるとき
			　　　　　　if(Input.GetKeyDown("up")){//upを押したら
				　　　　　　　　transform.position += new Vector3(1.5f, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 2;
			　　　　　　}else if(Input.GetKeyDown("left")){//centerを押したら
				　　　　　　　　transform.position += new Vector3(3, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 3;
			　　　　　　}else{//upもcenterも押していなかったら
				　　　　　　　　//その位置で前に進む
				　　　　　　　　transform.position += new Vector3(0, 0, -5.6f * Time.deltaTime);
				　　　　　　}
		　　　　}else if (l_num == 2) {//centerにいるとき
			　　　　　　if (Input.GetKeyDown("right")){//rightを押したら
				　　　　　　　　transform.position += new Vector3(-1.5f, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 1;
			　　　　　　}else if (Input.GetKeyDown("left")){//leftを押したら
				　　　　　　　　transform.position += new Vector3(1.5f, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 3;
			　　　　　　}else{//rightもleftも押していなかったら
				　　　　　　　　//その位置で前に進む
				　　　　　　　　transform.position += new Vector3(0, 0, -5.6f * Time.deltaTime);
				　　　　　　}
		　　　　}else if (l_num == 3) {//leftにいるとき
			　　　　　　if (Input.GetKeyDown("right")){//rightを押したら
				　　　　　　　　transform.position += new Vector3(-3, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 1;
			　　　　　　}else if (Input.GetKeyDown("up")){//upを押したら
				　　　　　　　　transform.position += new Vector3(-1.5f, 0, -5.6f * Time.deltaTime);
				　　　　　　　　l_num = 2;
			　　　　　　}else{//rightもupも押していなかったら
				　　　　　　　　//その位置で前に進む
				　　　　　　　　transform.position += new Vector3(0, 0, -5.6f * Time.deltaTime);
				　　　　　　}
			　　　　}
		if (Jumpcount == 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, 5.5f, 0);
				Jumpcount += 1;
			}
		}
		　　}
	private void OnCollisionEnter(Collision coll){
		Jumpcount = 0;
	}

	
	}

