using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float axis3 = Input.GetAxis("axis3");
		transform.position += new Vector3 (axis3, 0, 0);
//		Debug.Log (Input.GetAxis ("Horizontal"));
//		transform.position = new Vector3 (transform.position.x + Input.GetAxis ("Horizontal"), transform.position.y, transform.position.z);

//		if(Input.GetAxisRaw("Horizontal") < 0){
//			//左に傾いている
//			transform.position += new Vector3(-0.1f, 0, 0);
//		}else if(0 < Input.GetAxisRaw("Horizontal")){
//			//右に傾いている
//			transform.position += new Vector3(0.1f, 0, 0);
//		}else{
//			//左右方向には傾いていない
//		}

//		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * 30, 0, 0);
	}
}
