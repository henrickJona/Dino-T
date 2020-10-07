using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawn : MonoBehaviour {
	public GameObject Log;
	GameObject logCopy;
	public float test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		test += test * Time.deltaTime;
		if (test > 2) {
			test = 0;
			logCopy = Instantiate (Log, Log.transform.position, Log.transform.rotation);
			Destroy (logCopy, 20);
		}

	}
}
