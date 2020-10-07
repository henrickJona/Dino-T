using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public GameObject Off;
	public GameObject On;
	public int lo;
	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.GetInt ("LL") == 1) {
			AudioListener.volume = 1;
			Off.SetActive (false);
			On.SetActive (true);

		} else {
			Off.SetActive (true);
			On.SetActive (false);
			AudioListener.volume = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ONN(){
		Off.SetActive (true);
		On.SetActive (false);
		if(AudioListener.volume > 0){
			AudioListener.volume = 0;
			PlayerPrefs.SetInt ("LL", 0);
		}

	}
	public void OFF(){
		Off.SetActive (false);
		On.SetActive (true);
		if(AudioListener.volume >= 0){
			AudioListener.volume = 1;	
			PlayerPrefs.SetInt ("LL", 1);
		}
	}
}
