using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	
	public float ofsset;
	public float Control = 0;
	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float cont;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (x == 1) {
			transform.Translate(-Time.deltaTime * ofsset, 0, 0);
		} else if (y == 1) {
			transform.Translate(0, -Time.deltaTime * ofsset, 0);
		} else if (z == 1) {
			transform.Translate(0, 0, -Time.deltaTime * ofsset);
		}


		//transform.Translate (Vector3.forward * Time.deltaTime* ofsset);
			Destroy (gameObject, 34);
		

	}
}
