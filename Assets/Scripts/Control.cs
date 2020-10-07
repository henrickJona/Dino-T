using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
	public static Control contr;
	public GameObject DinoLowGa;
	public GameObject DinoRapGa;
	public GameObject DinoBatGa;
	public GameObject DinoGokGa;
	public GameObject DinoIronManGa;
	public bool dash = false;
	// Use this for initialization
	void Awake(){
		if (contr == null) {
			contr = this;
		}
	}
	void Start () {
		if(GameControl.control.CharacterSelect == 0){

			DinoLowGa.SetActive (true);
			DinoRapGa.SetActive (false);
			DinoBatGa.SetActive (false);
			DinoGokGa.SetActive (false);

		}else if(GameControl.control.CharacterSelect == 1){
			DinoLowGa.SetActive (false);
			DinoRapGa.SetActive (true);
			DinoBatGa.SetActive (false);
			DinoGokGa.SetActive (false);

		}else if(GameControl.control.CharacterSelect == 2){
			DinoLowGa.SetActive (false);
			DinoRapGa.SetActive (false);
			DinoBatGa.SetActive (true);
			DinoGokGa.SetActive (false);

		}else if(GameControl.control.CharacterSelect == 3){
			DinoLowGa.SetActive (false);
			DinoRapGa.SetActive (false);
			DinoBatGa.SetActive (false);
			DinoGokGa.SetActive (true);

		}else if(GameControl.control.CharacterSelect == 4){
			DinoLowGa.SetActive (false);
			DinoRapGa.SetActive (false);
			DinoBatGa.SetActive (false);
			DinoGokGa.SetActive (false);
			DinoIronManGa.SetActive (true);

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Dash(){
		dash = true;
	}
}
