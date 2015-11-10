using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class levelGen : MonoBehaviour {

	public List<GameObject> levels;
	private int currentLevel;
	// Use this for initialization
	void Start () {
		currentLevel = 0;
		InvokeRepeating ("createRock", 3, 3);
		// give position
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createRock () {
		currentLevel ++;
		int randomPick = Random.Range (0, 3);
		Instantiate (levels[randomPick]);
//		Instantiate ([currentLevel + randomPick]);
	}

}
