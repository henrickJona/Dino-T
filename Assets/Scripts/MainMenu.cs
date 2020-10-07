using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public GameObject cam;
	public float cal;
	public float calz;
	public float calx;
	public bool test;
	public float a1;
	public float a2;
	public float a3;
	public Vector3 nome;
	public Quaternion nom2;
	public Vector3 Vira;
	public Quaternion ViraR;
	// Use this for initialization
	void Start () {
		if(Time.timeScale == 0){

			Time.timeScale =1;

		}
		a1 = cal;
		a2 = calx;
		a3 = calz;
		nome = cam.transform.position;
		nom2 = cam.transform.rotation;
		Vira = new Vector3(-2.1f, -186,354);
		ViraR = new Quaternion(transform.rotation.x, -31,transform.rotation.z,110);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartGame(string name){
		SceneManager.LoadScene (name);

	}
	public void Option(){
		cam.transform.position = Vira;
		cam.transform.rotation = ViraR;
	}
	public void Back(){
		cam.transform.position = nome;
		cam.transform.rotation = nom2;

	}
	public void Quit(){
		Application.Quit ();
	}
	public void ShowLeaderboardUI(){
		//PlayServices.ShowLeaderbord (GPGSIds.leaderboard_score);
	}
}
