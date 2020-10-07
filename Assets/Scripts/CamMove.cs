using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {
	public GameObject Cam1;
	public GameObject Cam2;
	public float up;
	public float down;
	public bool upto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!upto) {
			down += down*Time.deltaTime;
			Cam1.SetActive (true);
			Cam2.SetActive (false);
			Cam1.transform.Translate (0, down, 0);
			if (down > 10) {
				upto = true;
				down = -0.02f;
			} else if(down < 0){
				down += down*Time.deltaTime;
				if (down < -20) {
					upto = true;
					down = 0.02f;
				}
			}
		} else {
			up += up*Time.deltaTime;
			Cam1.SetActive (false);
			Cam2.SetActive (true);
			Cam2.transform.Translate (0, up, 0);
			if (up < -30) {
				upto = false;
				up = 0.02f;
			} else if(up > 0){
				up += up*Time.deltaTime;
				if (up > 60) {
					upto = false;
					up = -0.02f;
				}
			}
		}

	}
}
