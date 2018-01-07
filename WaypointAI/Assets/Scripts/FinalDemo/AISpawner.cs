using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour {

	//This code is from the tutorial available at: https://www.youtube.com/watch?v=jQSIDNoUWX0

	public GameObject nagent;
	public GameObject goalObject;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnAgent", 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnAgent(){
		GameObject na = (GameObject)Instantiate (nagent, this.transform.position, Quaternion.identity);
		na.GetComponent<WalkToGoal>().goal = goalObject.transform;
		Invoke ("SpawnAgent", Random.Range (2, 5));
	}
}
