using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinalTechDemo : MonoBehaviour {

	NavMeshAgent player;

	// Use this for initialization
	void Start () {
		player = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		//This lets me move the player according to my mouse
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if ( Physics.Raycast(ray, out hit, 100)){
				player.SetDestination (hit.point);
			}
		}
		
	}
}
