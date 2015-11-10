using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {

	private Rigidbody2D playerRigidbody;
	private int currentScore = 0;
	public Text scoreTextUI;
	private Vector2 myScreenPosition;
	private float countdown = 10;
	private bool isPlayerAlive = true;
	// Use this for initialization
	void Start () {
		isPlayerAlive = true;
		currentScore = 0;
		countdown = 10;
		scoreTextUI.text = "Score: " + currentScore;

		playerRigidbody = this.gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print("I AM SPACEBAR");

			playerRigidbody.velocity = new Vector2(0,0);

			Vector2 tempForce = new Vector2(0,200);

			playerRigidbody.AddForce(tempForce);
		}
		if (isPlayerAlive) {
			checkPlayerPosition ();
		};


	}
	void countdownDec(){
//		InvokeRepeating ("countdownDec", 1, 10);
//		scoreTextUI.text = countdown.ToString();
		countdown--;
	}

	void OnCollisionEnter2D(Collision2D thingIAmCollidingWith){
//		
		if (thingIAmCollidingWith.gameObject.tag == "obstacle") {
//			print(thingIAmCollidingWith.gameObject.tag);
			Die();
		};
	
	}
	void OnTriggerEnter2D(Collider2D thingIAmCollidingWith){
		if (thingIAmCollidingWith.gameObject.tag == "coin") {

			currentScore = currentScore + 1;
			scoreTextUI.text = "Score: " + currentScore;
			print("Got Money! Now I have " +  currentScore);
			Destroy(thingIAmCollidingWith.gameObject);
		};
	}
	void checkPlayerPosition () {
		myScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

		if (myScreenPosition.y > Screen.height || myScreenPosition.y < 0) {
			Die();
		};
	}
	void Die(){
//		InvokeRepeating ("countdownDec", 1, 1);
		isPlayerAlive = false;
		scoreTextUI.text = "Game Over";
		GameOver ();
	}
	void GameOver(){
		Application.LoadLevel (Application.loadedLevel);
	}
}
