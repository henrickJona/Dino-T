using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
	public GameObject light1;
	public GameObject light2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackToMenu(string nome){
		if(GameControl.control.viu == 1){
			GameControl.control.Coin += GameControl.control.CoinAdqui;
			GameControl.control.viu = 0;
			GameControl.control.CoinAdqui = 0;
		}
		SceneManager.LoadScene (nome);
		if(Time.timeScale == 0){
			Time.timeScale = 1;

			light1.SetActive (true);
			light2.SetActive (true);


		}


	}

	public void PauseS(){
		
		if (Time.timeScale == 1) {
			light1.SetActive (false);
			light2.SetActive (false);
			Time.timeScale = 0;
		}else if(Time.timeScale == 0){
			light1.SetActive (true);
			light2.SetActive (true);
			Time.timeScale =1;

		}
	}
	public void Quit(){
		Application.Quit ();
		if(GameControl.control.viu == 1){
			GameControl.control.Coin += GameControl.control.CoinAdqui;
			GameControl.control.viu = 0;
			GameControl.control.CoinAdqui = 0;
		}
	}
}
