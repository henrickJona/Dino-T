using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {
	public AudioSource Loop;
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
	public CanvasGroup FastPanel;
	public float aux;
	public float lastInc;
	public float fra;
	public ParticleSystem Broke;
	public static int Coin;
	public static int ScoreI;
	public ParticleSystem Dust;
	public GameObject sd;
	public AudioSource JUMP;
	public bool extra;
	public float z;
	private Collider Aux;
	public Text Coi;
	public Button DDash;
	public GameObject DeathScreen;
	public  Text CoinText;
	public  Text Score;
	public  Text Scorejk;
	public Vector3 nome;
	public Quaternion nom2;
	public Vector3 Vira;
	public int Contt = 0;
	public int flo;
	public bool guarda;
	public Quaternion ViraR;
	// Use this for initialization

	void Start () {
		guarda = true;
		ScoreI = 0;
		Coin = 0;
		nome = Cam.transform.position;
		nom2 = Cam.transform.rotation;
		Vira = new Vector3(-8, 97,-968);
		ViraR = new Quaternion(30, transform.rotation.y,transform.rotation.z,110);
		if(Time.timeScale == 0){
			
			Time.timeScale =1;

		}
			player = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Contt > 10){
			DDash.image.color = Color.yellow;
			DDash.enabled = true;
		}else{
			
			DDash.image.color = Color.grey;
			DDash.enabled = false;
		}
		/*
		if (Dash) {
			//GameControl.control.Coin += Coin;
			Dash = false;
		}*/

		StartCoroutine (Scoree());
		//Debug.Log (player.transform.position);
		//Debug.Log (z);
		Coi.text =  Coin.ToString();
		CoinText.text = Coin.ToString ();
		Scorejk.text = ScoreI.ToString ();
		Coi.text = Coin.ToString ();
		Score.text = ScoreI.ToString ();
		if(!player.isGrounded ){
			Dust.Play(true);
		}
		if (player.transform.position.z < -466 && !extra) {
			
			player.transform.position = new Vector3 (transform.position.x, transform.position.y, z);


		}

		Score.text = ScoreI.ToString ()+" m";
		if (z > -466 && !extra) {
			
			player.transform.position = new Vector3 (transform.position.x, transform.position.y, -466);


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
		}if (player.transform.position.z < -560 || player.transform.position.y <= -412) {
			if (Time.time > lastInc + 0.30) {
				aux ++;
				lastInc = Time.time;
			}
		

			if(guarda){
				
				for  (int i = 0; i < 1;i++){
					GameControl.control.CoinAdqui = Coin;
					Debug.Log (GameControl.control.Coin);

					GameControl.control.Coin += Coin;

					Debug.Log (GameControl.control.Coin);
					guarda = false;
				}


			}

			/*if (ScoreI > PlayServices.GetPlayerScore (GPGSIds.leaderboard_score)) {
				PlayServices.PostScore ((long)ScoreI, GPGSIds.leaderboard_score);
			}*/
			DeathScreen.SetActive (true);
			sd.SetActive (true);
			Loop.Pause ();

			if (Time.timeScale == 1) {

				Time.timeScale = 0;
			}
			CoinText.text = Coin.ToString ();
			Scorejk.text = ScoreI.ToString ();
			Coi.text = Coin.ToString ();
			Score.text = ScoreI.ToString ();






			Dash = true;
			if (aux % 2 ==0 ) {
				
				Panel.alpha = 0.4f;
			} else {
				Panel.alpha = 0.6f;
			}
		}
		if (player.transform.position.z > -500) {
			

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

		if (player.isGrounded && Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began ) {
			
			if (!EventSystem.current.IsPointerOverGameObject (Input.GetTouch (0).fingerId)) {
				t = true;

				JUMP.Play ();

			} else {
				t = false;

			}
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
		contr = Input.acceleration.x*moveSpeed;
		if (Input.acceleration.x > 0 && player.transform.position.x < -60 && Time.timeScale == 1) {
			transform.Translate (contr, 0, 0);
		} else if (Input.acceleration.x < 0 && player.transform.position.x > 29 && Time.timeScale == 1) {
			transform.Translate (contr, 0, 0);
		}
		if (player.transform.position.x > -60 && player.transform.position.x < 29 && Time.timeScale == 1) {
			transform.Translate (contr, 0, 0);
		}
			
		
		if (Control.contr.dash == true && Contt > 10) {
			timerDash += Time.deltaTime;


			//Debug.Log("Pé na");
			if (Time.time > lastInc + 0.30) {
				aux ++;
				lastInc = Time.time;
			}

			if (aux % 2 ==0) {
				FastPanel.alpha = 0.2f;
			} else {
				FastPanel.alpha = 0.4f;
			}
	
			player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -467);
			z = -467;
			Cam.GetComponent<Camera> ().fieldOfView = fra +=0.2f ;


			if (timerDash > 1.8f ){
				Contt = 0;
				FastPanel.alpha = 0;
				Cam.GetComponent<Camera> ().fieldOfView = 36;
				Control.contr.dash = false;
				fra = 25;
				aux = 0;
				timerDash = 0;


			}
		}
	
		if(extra){
			flo++;

		}
		if(flo > 20){
			extra = false;
			flo = 0;
		}

		anime.SetBool ("Dash", Control.contr.dash);
		anime.SetBool ("Jump", Jumper);
	}
	bool Analisa(float analise){
		if (analise > 0) {
			return true;
		} else {
			return false;
		}
	}

	void OnCollisionEnter(Collision Col){

	
		if (Col.gameObject.tag == "Obs" && Control.contr.dash) {
			
			Destroy (Col.gameObject);
			Broke.Play(true);

		}

		if (Col.gameObject.tag == "OBS" || Col.gameObject.tag == "Obs") {
			
			extra = true;
			//player.transform.position.z -= 1.5;
			player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z--);
			//Debug.Log (player.transform.position.z);
			z = player.transform.position.z;

		}


	}
	IEnumerator Scoree(){
		while (Time.timeScale == 1) {
			yield return new WaitForSeconds(.5f);
			ScoreI++;
			StopAllCoroutines ();


		}
	}

			
		
	void OnTriggerEnter(Collider Col){

		if (Col.gameObject.tag == "In") {
			AuxCam.SetActive (true);
			Cam.SetActive (false);

		} else if (Col.gameObject.tag == "Out") {
			AuxCam.SetActive (false);
			Cam.SetActive (true);
		} else if (Col.gameObject.tag != "Out" && Col.gameObject.tag != "In" && Col != Aux) {
			Aux = Col;
			Coin++;
			Contt++;

		}else if(Col.gameObject.tag == "InLake"){
			Cam.transform.position = Vira;
			Cam.transform.rotation = ViraR;
		}else if(Col.gameObject.tag == "OutLake"){
			Cam.transform.position = nome;
			Cam.transform.rotation = nom2;
		}


	}
		

}

