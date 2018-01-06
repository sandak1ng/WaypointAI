using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener3B : MonoBehaviour {

	bool open = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("l")) {
			if (open)
				this.transform.Translate (0, 3, 0);
			else
				this.transform.Translate (0, -3, 0);

			open = !open;
		}
	}
}
