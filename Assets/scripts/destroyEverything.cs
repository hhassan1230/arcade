using UnityEngine;
using System.Collections;

public class destroyEverything : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D thingIAmCollidingWith){
		if (thingIAmCollidingWith.gameObject.tag != "background" || thingIAmCollidingWith.gameObject.tag != "floor") {
			Debug.Log(thingIAmCollidingWith.gameObject.name);

			Destroy(thingIAmCollidingWith.gameObject);
		}
		// list with gameobject within array.
		
	}
}
