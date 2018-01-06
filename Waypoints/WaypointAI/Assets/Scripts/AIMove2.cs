using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove2 : MonoBehaviour {

	public Transform[] Waypoint;
	public float speed;

	private int current;
	
	// Update is called once per frame
	void Update () {
		//Keeps moving until you reach the current waypoint
		if (transform.position != Waypoint [current].position) {
			Vector3 pos = Vector3.MoveTowards (transform.position, Waypoint [current].position, speed * Time.deltaTime);
			//Waypoint reached, moved onto the next object
			GetComponent<Rigidbody> ().MovePosition (pos);
		} else
			current = (current + 1) % Waypoint.Length;
	}
}
