using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {

	private Rigidbody2D playerRigidbody;
	public float obstacleMoveX = 0.0f;
	// Use this for initialization
	void Start () {
		playerRigidbody = this.gameObject.GetComponent<Rigidbody2D> ();

		Vector2 tempVelocity = new Vector2(obstacleMoveX, 0);
		playerRigidbody.velocity = (tempVelocity);
	}
	
	// Update is called once per frame
	void Update () {
//		transform.rotation = Quaternion.identity;



	}

}
