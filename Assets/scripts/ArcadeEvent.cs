using UnityEngine;
using System.Collections;

public class ArcadeEvent : MonoBehaviour {
	public GameObject arcade;
	private bool promptGame;
	private string machine;

	// Use this for initialization
	void Start () {
		promptGame = false;
		machine = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (promptGame) {
			settingNewLevel ();
		}
	}

//	OnTriggerEnter( Collider thingIAmCollidingWith ){
//			if(thingIAmCollidingWith.gameObject.tag == "Player"){
//			print("I am colliding with the player");
//		}
	void OnTriggerEnter(Collider other) {
			machine = arcade.gameObject.tag;
			print("I am colliding with the " + arcade.gameObject.tag);
		if(other.gameObject.tag == "Player"){
			promptGame = true;

//				print("I am colliding with the " + arcade.gameObject.tag);
		}
	}

	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		var machine = arcade.gameObject.tag;
		if(other.gameObject.tag == "Player"){
			promptGame = false;
			print("I am no longer colliding with " + machine);
		}
	}

	public void settingNewLevel(){
			if (Input.GetKeyDown (KeyCode.P)) {
				print ("I am pressing P");
				switch (machine) {
				case "Arcade_Runner":           
					// Do Something
					Application.LoadLevel ("RunningIntroScene");
					
					break;
				case "Arcade_Driver":
					// Do Something
					Application.LoadLevel ("DrivingIntroScene");
					break;
				case "Arcade_Shooter":
					// Do Something
					Application.LoadLevel ("ShooterIntroScene");
					break;
				default:
					// Do Something
					print ("You got a Snack");
					break;
				}
		}
	}
		
}
