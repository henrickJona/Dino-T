using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessaPrivacy : MonoBehaviour {


	public void OpenURL(){
		Application.OpenURL ("https://henrickjona.wixsite.com/dinot");
		Debug.Log ("is this working?");
	}
}
