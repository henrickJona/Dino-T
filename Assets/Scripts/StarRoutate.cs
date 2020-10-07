using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRoutate : MonoBehaviour {
	public float upda;
	public GameObject Explosion;
	GameObject ExplosionCopy;
	public AudioSource Explode;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0, upda*Time.deltaTime , 0));
	}

	void OnTriggerEnter(){
		
		Explode.Play();

		ExplosionCopy = Instantiate (Explosion, transform.position, transform.rotation);
		Destroy (gameObject);

		Destroy (ExplosionCopy, 1);
	}
}
