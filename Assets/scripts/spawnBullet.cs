using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnBullet : MonoBehaviour {
	public List<GameObject> levels;
	private Vector3 tmpPosition;
	private float xPosition;
	private float yPosition;
	private Vector3 bulletSize;
	// Use this for initialization
	void Start () {
		bulletSize = new Vector3 (1.0f, 1.0f, 1.0f); 
		if(levels[0].transform.localScale == bulletSize){
			levels[0].transform.localScale = new Vector3(2.0f,2.0f,0.0f);
		}
		InvokeRepeating ("createBullet", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void createBullet () {
//		
		xPosition = transform.position.x - 2.0f;
		yPosition = transform.position.y + 0.2f;
		Vector3 tmpPosition = new Vector3 (xPosition, yPosition, transform.position.z);
		var currentBullet = levels [0];
		print (currentBullet);
		Instantiate (currentBullet, (tmpPosition), transform.rotation);
//		currentBullet.transform.localScale += Vector3(2.0,2.0,0);
	}
}
