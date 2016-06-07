using UnityEngine;
using System.Collections;

public class Hako : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion q = Input.gyro.attitude;
		Quaternion qq = Quaternion.AngleAxis(-90.0f, Vector3.left);
		q.x *= -1.0f;
		q.y *= -1.0f;
		this.transform.localRotation = qq * q;
	}
}
