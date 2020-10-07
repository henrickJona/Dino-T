using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {
	public int Coin= 0;
	public int Score;
	public int CharacterSelect;
	public static GameControl control;
	public Text Coinn;
	public string SceneName;
	public Button i;
	public int viu = 0;
	public int CoinAdqui = 0;
	// Use this for initialization
	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;


		}else if(control != this){
			Destroy (gameObject);


		}
	}
	void Start(){
		viu =  PlayerPrefs.GetInt ("viu");
		CharacterSelect =  PlayerPrefs.GetInt ("CharacterSelected");
		CoinAdqui = PlayerPrefs.GetInt ("CoinAdqui");
		Coin = PlayerPrefs.GetInt ("Coin");

	}
		
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt ("CharacterSelected", CharacterSelect);
		PlayerPrefs.SetInt ("Coin", Coin);
		Coinn.text = PlayerPrefs.GetInt("Coin").ToString();

		SceneName = SceneManager.GetActiveScene ().name;;
		if (SceneName == "inicio") {
			
			i.enabled = false;
			i.image.enabled = false;
			Coinn.enabled = false;

		} else {
			i.image.enabled = true;
			i.enabled = true;
			Coinn.enabled = true;
		}
	}

}
