using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnBullet : MonoBehaviour {
	public List<GameObject> levels;
	private Vector3 tmpPosition;
	private float xPosition;
	private float yPosition;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("createBullet", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void createBullet () {
//		
		xPosition = transform.position.x - 1.0f;
		yPosition = transform.position.y + 0.2f;
		Vector3 tmpPosition = new Vector3 (xPosition, yPosition, transform.position.z);
		print (levels[0].transform);
		Instantiate (levels[0], (tmpPosition), transform.rotation);
	}
}
