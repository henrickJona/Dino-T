using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour {
	public CharacterController player;
	public Animator anime;
	public bool Jumper = false;
	public bool Dash = false;
	public float verticalVelocity;
	public GameObject Cam;
	public GameObject AuxCam;
	public float gravity = 14.0f;
	public float jumpforce= 10.0f;
	public float timerDash = 0;
	public float timer = 0;
	public float ofsset;
	public float moveSpeed;
	public float contr;
	public bool t;
	public bool j;
	public bool tDash;
	public bool jDash;
	public CanvasGroup Panel;
	public float aux;
	public float lastInc;
	public float fra;
	public ParticleSystem Broke;
	public bool extra;
	public float z;
	public ParticleSystem Dust;
	public AudioSource JUMP;
	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();

	}

	// Update is called once per frame
	void Update () {
		if(!player.isGrounded ){
			Dust.Play(true);
		}
		if (player.transform.position.z < -466 && !extra) {
			player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, z);

		}
		if (player.transform.position.z < -500 && player.transform.position.z > -530) {
			if (Time.time > lastInc + 0.30) {
				aux ++;
				lastInc = Time.time;
			}

			if (aux % 2 ==0) {
				Panel.alpha = 0.0f;
			} else {
				Panel.alpha = 0.2f;
			}
		}if (player.transform.position.z < -530 && player.transform.position.z > -560) {
			if (Time.time > lastInc + 0.30) {
				aux ++;
				lastInc = Time.time;
			}

			if (aux % 2 ==0 ) {
				Panel.alpha = 0.2f;
			} else {
				Panel.alpha = 0.4f;
			}
		}if (player.transform.position.z < -560) {
			if (Time.time > lastInc + 0.30) {
				aux ++;
				lastInc = Time.time;
			}

			if (aux % 2 ==0 ) {
				Panel.alpha = 0.4f;
			} else {
				Panel.alpha = 0.6f;
			}
		}if (player.transform.position.z > -500) {


			Panel.alpha = 0;
		}
		verticalVelocity = -gravity * Time.deltaTime;
		/*if(player.isGrounded){
			if (Input.touchCount > 0) {
				verticalVelocity = jumpforce;
			} else {
				verticalVelocity -= gravity * Time.deltaTime;
			}
		}*/
		if (player.isGrounded && Input.GetButtonDown("Jump") ) {
			JUMP.Play ();
				t = true;


		}

		if (t || j) {
			t = false;
			j = true;

			timer += Time.deltaTime;

			verticalVelocity = jumpforce;

			Jumper = true;
			if (timer > 0.4) {
				Jumper = false;
				j = false;
				timer = 0;


			}



		} else {
			verticalVelocity -= gravity * Time.deltaTime;
		}

		Vector3 moveVector = new Vector3 (0, verticalVelocity, 0);
		player.Move (moveVector* Time.deltaTime);

		if (Input.GetButton("SideR") && transform.position.x < -60 && Time.timeScale == 1) {
			contr = moveSpeed * Time.deltaTime;

			transform.Translate (contr, 0, 0);
		} else if (Input.GetButton("SideL") && transform.position.x > 29 && Time.timeScale == 1) {
			contr = -moveSpeed*Time.deltaTime;
			transform.Translate (contr, 0, 0);
		}
		if (transform.position.x > -60 && transform.position.x < 29 && Time.timeScale == 1) {
			if (Input.GetButton ("SideL")) {
				contr = -moveSpeed * Time.deltaTime;
			} else if (Input.GetButton ("SideR")) {
				contr = moveSpeed * Time.deltaTime;
			}

			transform.Translate (contr, 0, 0);
		}


		if (Dash == true) {
			timerDash += Time.deltaTime;
			z = -467;

			Cam.GetComponent<Camera> ().fieldOfView = fra +=0.2f ;


			if (timerDash > 1.8f ){
				Cam.GetComponent<Camera> ().fieldOfView = 36;
				Dash = false;
				fra = 36;

				timerDash = 0;


			}
		}




		anime.SetBool ("Dash", Dash);
		anime.SetBool ("Jump", Jumper);
	}
	bool Analisa(float analise){
		if (analise > 0) {
			return true;
		} else {
			return false;
		}
	}
	public void Dashh(){

		Dash = true;

	}
	void OnCollisionEnter(Collision Col){

		if (Col.gameObject.tag == "Obs" && Dash) {
			
			Destroy (Col.gameObject);

			Broke.Play(true);


		}
		if (Col.gameObject.tag == "OBS" || Col.gameObject.tag == "Obs") {
			extra = true;


			z = player.transform.position.z;

			extra = false;
		}


	}
	void OnTriggerEnter(Collider Col){

		if (Col.gameObject.tag == "In") {


			AuxCam.SetActive (true);
			Cam.SetActive (false);



		}else if(Col.gameObject.tag == "Out"){
			AuxCam.SetActive (false);
			Cam.SetActive (true);
		}


	}


}

