using UnityEngine;
using System.Collections;

public class RotateSaw : MonoBehaviour {
	private GameObject saw;
	private float sawRotation;
	private float rotationVector;
	// Use this for initialization
	void Start () {
		saw = this.gameObject;
//		var rotationVector = transform.rotation.eulerAngles;
//		print (rotationVector.z);
		sawRotation = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		sawRotation += 5;
		saw.transform.rotation = Quaternion.Euler(0, 0, sawRotation);
//		print (saw.transform.rotation);
////		sawRotation = saw.transform.rotation.z;
//		sawRotation ++;

//		rotationVector.z = 5;
//		transform.rotation = Quaternion.Euler(rotationVector);
	}
}
