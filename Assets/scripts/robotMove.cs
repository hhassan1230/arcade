using UnityEngine;
using System.Collections;

public class robotMove : MonoBehaviour {
	private Rigidbody2D playerRigidbody;
	private int currentScore = 0;
//	public Text scoreTextUI;
	private Vector2 myScreenPosition;
	private float countdown = 10;
	private bool isPlayerAlive = true;
	// Use this for initialization
	void Start () {
		isPlayerAlive = true;
		currentScore = 0;
		countdown = 10;
		playerRigidbody = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			playerRigidbody.velocity = new Vector2(0,0);
			
			Vector2 tempForce = new Vector2(0,350);
			
			playerRigidbody.AddForce(tempForce);
		};
		if (isPlayerAlive) {
			checkPlayerPosition ();
		};
	}
	void checkPlayerPosition () {
		myScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
		
		if (myScreenPosition.y > Screen.height || myScreenPosition.y < 0 || myScreenPosition.x < 0 || myScreenPosition.x > Screen.width) {
			Die();
		};
	}
	void Die(){
		//		InvokeRepeating ("countdownDec", 1, 1);
		isPlayerAlive = false;
//		scoreTextUI.text = "Game Over";
		GameOver ();
	}
	void GameOver(){
		Application.LoadLevel (Application.loadedLevel);
	}
	void OnCollisionEnter2D(Collision2D thingIAmCollidingWith){
		//		
		if (thingIAmCollidingWith.gameObject.tag == "obstacle") {
			//			print(thingIAmCollidingWith.gameObject.tag);
			Die();
		};
		
	}
	void OnTriggerEnter2D(Collider2D thingIAmCollidingWith){
		if (thingIAmCollidingWith.gameObject.tag == "saw" || thingIAmCollidingWith.gameObject.tag == "bullet") {
			Die();
		};

	}
}
