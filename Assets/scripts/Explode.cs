using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Explode : MonoBehaviour {

	public BodyPart bodyPart;
	public int totalParts;
	public List<GameObject> parts = new List<GameObject>();

	private bool isPlayerAlive = true;
	private Vector2 myScreenPosition;
	private GameObject limb;
	private GameObject spawnLimb;
	private float randomUp;
	private float randomRight;
	// Use this for initialization
	void Start () {
		isPlayerAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
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
		Destroy(gameObject);
		OnExplode ();
		GameOver ();
	}
	void GameOver(){
		//		Application.LoadLevel (Application.loadedLevel);
		print ("I Died");
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

	public void OnExplode(){
		var t = transform;
		for (int i = 0; i < parts.Count; i++) {
			limb = parts[i];

			GameObject spawnLimb = Instantiate(limb, t.position, Quaternion.identity) as GameObject;

			randomRight = Random.Range (-500, 500);
			randomUp = Random.Range(100, 400);
			print(randomRight + " and " + randomUp);
			spawnLimb.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (randomRight));
			spawnLimb.GetComponent<Rigidbody2D>().AddForce(Vector3.up * (randomUp));
		}
	}
}
