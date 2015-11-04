using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class parallax : MonoBehaviour {
	
	
	public List<SpriteRenderer> bg = new List<SpriteRenderer>();
	private float bgSize;
	public float bgVelocity;
	// Use this for initialization
	
	void Start () {
		bgSize = bg[0].GetComponent<Renderer>().bounds.size.x;
		bg[1].transform.position = Vector2.zero;
		bg[0].transform.position = Vector2.left * bgSize;
		bg[2].transform.position = Vector2.right * bgSize;
		
	}
	
	// Update is called once per frame
	void Update () {
		moveRight();
	}
	void moveRight(){
//		bgVelocity = 3.0f;
		bg [0].transform.position -= (Vector3.right * Time.deltaTime * bgVelocity);
		bg [1].transform.position -= (Vector3.right * Time.deltaTime * bgVelocity);
		bg [2].transform.position -= (Vector3.right * Time.deltaTime * bgVelocity);
		if (bg [1].transform.position.x <= -bgSize) {
			bg.Insert(3, bg[0]);
			bg.RemoveAt(0);
			bg[2].transform.position = new Vector2(bg[1].transform.position.x + bgSize, 0);
		}
		
	}
	
}
