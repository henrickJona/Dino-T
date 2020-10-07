using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CSMenu : MonoBehaviour {
	public GameObject _1;
	public GameObject _2;
	public GameObject _3;
	public GameObject _4;
	public GameObject _5;
	public int cont;
	public ArrayList vetor = new ArrayList();
	GameObject aux;
	GameObject aux2;
	public Vector3 _11;
	public bool purchased_1;
	public bool purchased_2;
	public bool purchased_3;
	public bool purchased_4;
	public GameObject Purchased;
	public GameObject DinoRap;
	public GameObject DinoGok;
	public GameObject DinoBat;
	public GameObject DinoIronMan;
	public int CharacterSelected;
	public Toggle Check;
	public ParticleSystem Confetti;

	public int _DinoR;
	public int _DinoB;
	public int _DinoG;
	public int _DinoI;

	// Use this for initialization

	void Start () {
		CharacterSelected = PlayerPrefs.GetInt ("CharacterSelected");

		if (PlayerPrefs.GetInt("CharacterSelected") == 0) {
			
			Check.isOn = true;
		} else {
			Check.isOn = false;
		}



		_11 = _1.transform.position;
		vetor.Add (_1);
		vetor.Add (_2);
		vetor.Add (_3);
		vetor.Add (_4);
		vetor.Add (_5);
		_1.gameObject.SetActive (true);
		_DinoR = PlayerPrefs.GetInt ("_dinoR");
		_DinoB = PlayerPrefs.GetInt ("_dinoB");
		_DinoG = PlayerPrefs.GetInt ("_dinoG");
		_DinoI = PlayerPrefs.GetInt ("_dinoI");
		if(_DinoR == 0) {
			purchased_1 = false;
		} else {
			purchased_1 = true;
		}
		if (_DinoB == 0) {
			purchased_2 = false;
		} else {
			purchased_2 = true;
		}
		if (_DinoG == 0) {
			purchased_3 = false;
		} else {
			purchased_3 = true;
		}
		if (_DinoI == 0) {
			purchased_4 = false;
		} else {
			purchased_4 = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void Right(){
		
		if (cont <= 3) {
			
			if(cont == 0 && purchased_1){
				cont++;

				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					
					Check.isOn = false;
				}
				return;
			}else if(cont == 1 && purchased_2){
				cont++;

				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}else if(cont == 2 && purchased_3){
				cont++;

				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}else if(cont == 3 && purchased_4){
				cont++;

				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}
			if(cont == 0 && !purchased_1){
				cont++;
				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (true);
					DinoGok.SetActive (false);
					DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				return;
			}else if(cont == 1 && !purchased_2){
				cont++;
				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
					DinoRap.SetActive (false);
					DinoGok.SetActive (false);
				DinoBat.SetActive (true);
				DinoIronMan.SetActive (false);
				return;
			}else if(cont == 2 && !purchased_3){
				cont++;
				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
					Purchased.SetActive (false);
					DinoRap.SetActive (false);
					DinoGok.SetActive (true);
					DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				return;
			}else if(cont == 3 && !purchased_4){
				cont++;
				aux = (GameObject) vetor [cont];
				aux2 =(GameObject) vetor [cont-1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (true);
				return;
			}
				

			}
					

	}
	public void Charge(string scene){
		SceneManager.LoadScene (scene);

	}
	public void Left(){
		
		if (cont >= 1) {
			
				
			if(cont == 1){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}


			if(cont == 2 && purchased_1){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}else if(cont == 3 && purchased_2){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}else if(cont == 4 && purchased_3){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}else if(cont == 5 && purchased_4){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (true);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				if (cont == PlayerPrefs.GetInt("CharacterSelected") ) {
					Check.isOn = true;
				} else {
					Check.isOn = false;
				}
				return;
			}
		if(cont == 2 && !purchased_1){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (true);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				return;
		}else if(cont == 3 && !purchased_2){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (true);
				DinoIronMan.SetActive (false);
				return;
		}else if(cont == 4 && !purchased_3){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (false);
				DinoGok.SetActive (true);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (false);
				return;
			}else if(cont == 5 && !purchased_4){
				cont--;

				aux = (GameObject)vetor [cont];
				aux2 = (GameObject)vetor [cont + 1];
				aux2.gameObject.SetActive (false);
				aux.transform.position = _11;
				aux.gameObject.SetActive (true);
				Purchased.SetActive (false);
				DinoRap.SetActive (false);
				DinoGok.SetActive (false);
				DinoBat.SetActive (false);
				DinoIronMan.SetActive (true);
				return;
			}
				

			}



	}
	public void Buy(){
		if(cont == 1 && GameControl.control.Coin >= 1500){
			Confetti.Play ();
			DinoRap.SetActive (false);
			Purchased.SetActive(true);
			purchased_1 = true;
			GameControl.control.Coin -= 1500;
			PlayerPrefs.SetInt ("_dinoR", 1);
			if (cont == CharacterSelected) {
				Check.isOn = true;

			} else {
				Check.isOn = false;
			}
		}else if(cont == 2 && GameControl.control.Coin >= 2500){
			Confetti.Play ();
			DinoBat.SetActive (false);
			Purchased.SetActive(true);
			purchased_2 = true;
			GameControl.control.Coin -= 2500;
			PlayerPrefs.SetInt ("_dinoB", 1);
			if (cont == CharacterSelected) {
				Check.isOn = true;
			} else {
				Check.isOn = false;
			}
		}else if(cont == 3 && GameControl.control.Coin >= 3500){
			Confetti.Play ();
			DinoGok.SetActive (false);
			Purchased.SetActive(true);
			purchased_3 = true;
			GameControl.control.Coin -= 3500;
			PlayerPrefs.SetInt ("_dinoG", 1);
			if (cont == CharacterSelected) {
				Check.isOn = true;
			} else {
				Check.isOn = false;
			}
		}else if(cont == 4 && GameControl.control.Coin >= 5000){
			Confetti.Play ();
			DinoIronMan.SetActive (false);
			Purchased.SetActive(true);
			purchased_4 = true;
			GameControl.control.Coin -= 5000;
			PlayerPrefs.SetInt ("_dinoI", 1);
			if (cont == CharacterSelected) {
				Check.isOn = true;
			} else {
				Check.isOn = false;
			}
		}
	}
	public void Select(){
		
		if(cont == CharacterSelected && cont  == 0){
			
				Check.isOn = true;

			return;
		}else if(cont != CharacterSelected && cont  == 0){
			PlayerPrefs.SetInt ("CharacterSelected", cont);
			Check.isOn = true;
			CharacterSelected = cont;
			GameControl.control.CharacterSelect = CharacterSelected;
			return;
		}
		if(cont == CharacterSelected && cont  == 1){
			Check.isOn = true;
		
			return;
		}else if(cont != CharacterSelected && cont  == 1){
			Check.isOn = true;
			PlayerPrefs.SetInt ("CharacterSelected", cont);
			CharacterSelected = cont;
			GameControl.control.CharacterSelect = CharacterSelected;
			return;
		}if(cont == CharacterSelected && cont  == 2){
			Check.isOn = true;
	
			return;
		}else if(cont != CharacterSelected && cont  == 2){
			Check.isOn = true;
			PlayerPrefs.SetInt ("CharacterSelected", cont);
			CharacterSelected = cont;
			GameControl.control.CharacterSelect = CharacterSelected;
			return;
		}
		if(cont == CharacterSelected && cont  == 3){
			Check.isOn = true;
		
			return;
		}else if(cont != CharacterSelected && cont  == 3){
			Check.isOn = true;
			PlayerPrefs.SetInt ("CharacterSelected", cont);
			CharacterSelected = cont;
			GameControl.control.CharacterSelect = CharacterSelected;
			return;
		}
		if(cont == CharacterSelected && cont  == 4){
			Check.isOn = true;

			return;
		}else if(cont != CharacterSelected && cont  == 4){
			Check.isOn = true;
			PlayerPrefs.SetInt ("CharacterSelected", cont);
			CharacterSelected = cont;
			GameControl.control.CharacterSelect = CharacterSelected;
			return;
		}


	}
}
