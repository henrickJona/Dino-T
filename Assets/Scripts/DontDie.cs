using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDie : MonoBehaviour {
	public static DontDie COU;

	// Use this for initialization
	void Awake () {
		if (COU == null) {
			DontDestroyOnLoad (gameObject);
			COU = this;


		}else if(COU != this){
			Destroy (gameObject);


		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
