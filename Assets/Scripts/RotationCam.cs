using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour {
	public GameObject player;
	public GameObject cam;
	public bool test;
	public Vector3 nome;
	public Quaternion nom2;
	public Vector3 Vira;
	public Quaternion ViraR;
	// Use this for initialization
	void Start () {
		nome = cam.transform.position;
		nom2 = cam.transform.rotation;
		Vira = new Vector3(-8, 97,-968);
		ViraR = new Quaternion(30, transform.rotation.y,transform.rotation.z,110);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (player.transform.position.y < -240) {


			cam.transform.position = Vira;
			cam.transform.rotation = ViraR;

			

		} else if (player.transform.position.y > -245) {
			
			cam.transform.position = nome;
			cam.transform.rotation = nom2;


			
		}	

	}
}
