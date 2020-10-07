using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMove : MonoBehaviour {
	public bool t;
	public Animator anime;
	// Use this for initialization
	void Start () {
		t = true;
	}
	
	// Update is called once per frame
	void Update () {
		anime.SetBool ("Idle",t);
	}
}
