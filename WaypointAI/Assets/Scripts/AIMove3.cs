using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove3 : MonoBehaviour {

	public Transform destination;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = this.GetComponent<NavMeshAgent> ();
		agent.SetDestination (destination.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
