using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AddManager : MonoBehaviour {
	public CanvasGroup Panel;
	public GameObject sd;
	public int jo;

	// Use this for initialization
	public void ShowAd () {
		
		if(Advertisement.IsReady()){
			Advertisement.Show ("rewardedVideo", new ShowOptions(){ resultCallback = HandleAdResult});	
		}

	}
	private void HandleAdResult(ShowResult r){
		switch(r){
		case ShowResult.Finished:
			Debug.Log ("Hello");
			PlayerController.ScoreI = 2 * (PlayerController.ScoreI);
			PlayerController.Coin = 2 * (PlayerController.Coin);
			GameControl.control.viu = 1;
			Panel.alpha = 1;
			Panel.blocksRaycasts = true;
			sd.SetActive (false);
		
			break;
		case ShowResult.Skipped:
			
			break;
		case ShowResult.Failed:
			break;
		default:

			break;

		}

	}
	public void Back(){
		Panel.alpha = 0;
	}
}
